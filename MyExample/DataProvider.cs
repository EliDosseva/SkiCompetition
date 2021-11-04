using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Data = System.Collections.Generic.KeyValuePair<int, string>;

namespace MyExample
{
    internal class Competition
    {
        public int CompetitionId { get; set; }
        public string CompetitionName { get; set; }
        public string Location { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public bool Finished { get; set; }
        public int Competitors { get; set; }
    }

    internal class Competitor
    {
        public int CompetitorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string Team { get; set; }
        public int TeamId { get; set; }
        public TimeSpan Time { get; set; }
        public int Position { get; set; }
        public int Points { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
    }

    public class Location
    {
        public int LocationId { get; set; }
        public string CompetitionLocation { get; set; }
    }
    public class DataProvider
    {
        private readonly string _connectionString;

        public DataProvider(string connectionString)
        {
            _connectionString = connectionString;
        }
        #region Competitors
        public bool CreateCompetitor(string firstName, string lastName, string sex, int ID, int points)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sc = new SqlCommand("insert into Competitors ([FirstName], [LastName], [Sex], [TeamID], [Points]) " +
                    "VALUES (@FirstName, @LastName, @Sex, @TeamID, @Points)"))
                {
                    sc.Connection = con;
                    sc.Parameters.AddWithValue("@FirstName", firstName);
                    sc.Parameters.AddWithValue("@LastName", lastName);
                    sc.Parameters.AddWithValue("@Sex", sex);
                    sc.Parameters.AddWithValue("@TeamID", ID);
                    sc.Parameters.AddWithValue("@Points", points);

                    con.Open();
                    if (sc.ExecuteNonQuery() > 0)
                    {
                        MyMessages.DisplayInfo("Competitor has been registered");
                        return true;
                    }

                    MyMessages.DisplayError("Record failed");
                    return false;
                }
            }
        }
        public bool EditCompetitor(int id, string firstName, string lastName, string sex, int teamId)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sc = new SqlCommand("SET ROWCOUNT 1 UPDATE [dbo].[Competitors] SET FirstName = @FirstName, LastName = @LastName, " +
                    " Sex = @Sex, TeamID = @TeamID " +
                    " WHERE ID = @ID SET ROWCOUNT 0"))
                {
                    sc.Connection = con;
                    sc.Parameters.AddWithValue("@ID", id);
                    sc.Parameters.AddWithValue("@FirstName", firstName);
                    sc.Parameters.AddWithValue("@LastName", lastName);
                    sc.Parameters.AddWithValue("@Sex", sex);
                    sc.Parameters.AddWithValue("@TeamID", teamId);

                    con.Open();
                    if (sc.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }

                    return false;
                }
            }
        }

        public bool UpdatePoints(int ID, int points)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sc = new SqlCommand("SET ROWCOUNT 1 UPDATE [dbo].[Competitors] SET Points = Points + @Points " +
                    " WHERE ID = @ID SET ROWCOUNT 0"))
                {
                    sc.Connection = con;
                    sc.Parameters.AddWithValue("@ID", ID);
                    sc.Parameters.AddWithValue("@Points", points);

                    con.Open();
                    if (sc.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }

                    return false;
                }
            }
        }

        internal List<Competitor> GetRandomCompetitors(int number)
        {
            List<Competitor> competitors = new List<Competitor>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT TOP (@ID) Competitors.ID, [FirstName], [LastName], [Sex], Teams.TeamName FROM [dbo].[Competitors] " +
                    " JOIN [dbo].[Teams] ON Competitors.TeamID = Teams.ID ORDER BY newID()";
                using (var command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Id", number);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            competitors.Add(new Competitor
                            {
                                CompetitorId = reader.GetInt32(0),
                                FirstName = reader[1].ToString(),
                                LastName = reader[2].ToString(),
                                Sex = reader[3].ToString(),
                                Team = reader[4].ToString()
                            });
                        }
                    }
                }
            }
            return competitors;
        }

        public bool IfExist(string firstName, string lastName)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT [FirstName], [LastName] FROM [dbo].[Competitors] WHERE [FirstName] = @FirstName and [LastName] = @LastName";
                using (var command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Firstname", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);

                    if (command.ExecuteScalar() != null)
                    {
                        return true;
                    }

                    return false;
                }
            }
        }

        public bool DeleteCompetitor(int insert)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("DELETE FROM [dbo].[Competitors] WHERE ID = @ID", conn);
                command.Parameters.AddWithValue("@ID", insert);
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    MyMessages.DisplayInfo("Deletion Successful");
                    return true;
                }

                MyMessages.DisplayError("Deletion Unsuccessful");
                return false;
            }
        }

        public DataTable Competitors()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlDataAdapter sc = new SqlDataAdapter("select Competitors.ID, [FirstName], [LastName], [Sex], Teams.TeamName " +
                    "FROM [dbo].[Competitors] JOIN Teams ON Competitors.TeamID = Teams.ID; ", con);

                sc.Fill(dt);

            }
            return dt;
        }
        #endregion

        #region Competitions
        public bool CreateCompetition(Guid id, string competitionName, string location, DateTime dateStart, DateTime dateEnd, int competitors)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sc = new SqlCommand("insert into [dbo].[Competitions] " +
                                                      "([Guid], [CompetitionName], [Location], [DateStart], [DateEnd], [Finished], [Competitors]) " +
                    "VALUES (@Guid, @CompetitionName, @Location, @DateStart, @DateEnd, @Finished, @Competitors)"))
                {
                    sc.Connection = con;
                    sc.Parameters.AddWithValue("@Guid", id);
                    sc.Parameters.AddWithValue("@CompetitionName", competitionName);
                    sc.Parameters.AddWithValue("@Location", location);
                    sc.Parameters.AddWithValue("@DateStart", dateStart);
                    sc.Parameters.AddWithValue("@DateEnd", dateEnd);
                    sc.Parameters.AddWithValue("@Finished", 0);
                    sc.Parameters.AddWithValue("@Competitors", competitors);

                    con.Open();
                    if (sc.ExecuteNonQuery() > 0)
                    {
                        MyMessages.DisplayInfo("Competition has been registered");
                        return true;
                    }

                    MyMessages.DisplayError("Record failed");
                    return false;
                }
            }
        }

        internal List<Competition> GetCompetition()
        {
            List<Competition> competitions = new List<Competition>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT [ID], [CompetitionName], [Location], [DateStart], [DateEnd], [Finished], [Competitors] FROM [dbo].[Competitions]";

                using (var command = new SqlCommand(query, con))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            competitions.Add(new Competition()
                            {
                                CompetitionId = reader.GetInt32(0),
                                CompetitionName = reader[1].ToString(),
                                Location = reader[2].ToString(),
                                DateStart = DateTime.Parse(reader[3].ToString()),
                                DateEnd = DateTime.Parse(reader[4].ToString()),
                                Finished = reader.GetBoolean(5),
                                Competitors = reader.GetInt32(6)
                            });
                        }
                    }
                }

            }
            return competitions;
        }

        public bool IsFinished(int ID)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sc = new SqlCommand("UPDATE [dbo].[Competitions] SET [Finished] = 1 where ID = @ID"))
                    
                {
                    sc.Connection = con;
                    sc.Parameters.AddWithValue("@ID", ID);
                    con.Open();
                    if (sc.ExecuteNonQuery() > 0)
                    {
                        
                        return true;
                    }

                    return false;
                }
            }
        }

        public BindingList<Data> CompetitionTable()
        {
            var competitions = new BindingList<Data>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand sc = new SqlCommand("SELECT [ID], [CompetitionName] FROM [dbo].[Competitions]", con);

                con.Open();

                SqlDataReader reader = sc.ExecuteReader();

                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var competitionName = reader.GetString(1);
                    competitions.Add(new Data(id, competitionName));
                }
                reader.Close();
            }
            return competitions;
        }

        public bool EditCompetition(int ID, string competitionName, string location, DateTime dateStart, DateTime dateEnd, int competitors)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sc = new SqlCommand("SET ROWCOUNT 1 UPDATE [dbo].[Competitions] " +
                                                      "SET [CompetitionName] = @CompetitionName, [Location] = @Location, " +
                    " [DateStart] = @DateStart, [DateEnd] = @DateEnd, [Finished] = @Finished, [Competitors] = @Competitors " +
                    " WHERE [ID] = @ID SET ROWCOUNT 0"))
                {
                    sc.Connection = con;
                    sc.Parameters.AddWithValue("@ID", ID);
                    sc.Parameters.AddWithValue("@CompetitionName", competitionName);
                    sc.Parameters.AddWithValue("@Location", location);
                    sc.Parameters.AddWithValue("@DateStart", dateStart);
                    sc.Parameters.AddWithValue("@DateEnd", dateEnd);
                    sc.Parameters.AddWithValue("@Finished", 0);
                    sc.Parameters.AddWithValue("@Competitors", competitors);

                    con.Open();
                    if (sc.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }

                    MessageBox.Show("Record failed");
                    return false;
                }
            }
        }
        #endregion

        #region Teams

        public List<Team> TeamSelection()
        {
            List<Team> team = new List<Team>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT [ID], [TeamName] FROM [dbo].[Teams]";

                using (var command = new SqlCommand(query, con))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            team.Add(new Team
                            {
                                TeamID = reader.GetInt32(0),
                                TeamName = reader[1].ToString(),
                            });
                        }
                    }
                }
            }
            return team;
        }

        internal List<Competitor> GetTeamMembers(int id)
        {
            List<Competitor> competitors = new List<Competitor>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {

                con.Open();
                string query = "SELECT [FirstName],[LastName] FROM [dbo].[Competitors] JOIN [dbo].[Teams] on Competitors.TeamID = Teams.ID where TeamID = @ID";

                using (var command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@ID", id);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            competitors.Add(new Competitor
                            {
                                FirstName = reader[0].ToString(),
                                LastName = reader[1].ToString()
                            });
                        }
                    }
                }
            }
            return competitors;
        }
        #endregion

        #region Results

        internal List<Competitor> GetResults(int competitionId, string sex)
        {
            List<Competitor> competitors = new List<Competitor>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT [FirstName],[LastName], [Sex], [TeamId], [TimeInMs], [TeamName], Competitors.ID " +
                    " FROM [dbo].[Results] JOIN [dbo].[Competitors] on Competitors.ID = Results.CompetitorID " +
                    " JOIN [dbo].[Competitions] ON Competitions.ID = CompetitionID " +
                    " JOIN Teams ON Competitors.TeamID = Teams.ID " +
                    " WHERE CompetitionID = @CompetitionID and Competitors.Sex = @Sex";

                using (var command = new SqlCommand(query,con))
                {
                    command.Parameters.AddWithValue("@CompetitionID", competitionId);
                    command.Parameters.AddWithValue("@Sex", sex);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            competitors.Add(new Competitor
                            {
                                TeamId = reader.GetInt32(3),
                                CompetitorId = reader.GetInt32(6),
                                FirstName = reader[0].ToString(),
                                LastName = reader[1].ToString(),
                                Sex = reader[2].ToString(),
                                Team = reader[5].ToString(),
                                Time = TimeSpan.Parse(reader[4].ToString())
                            });
                        }
                    }
                }
            }
            return competitors;
        }

        public bool InsertResults(int id, TimeSpan time, string datetime, int competitionID, int position)
        {

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                    using (SqlCommand sc = new SqlCommand("INSERT INTO [dbo].[Results] ([CompetitorID], [TimeInMs], [StartTime], [CompetitionID], [Position]) " +
                        "VALUES (@CompetitorID, @TimeInMs, @StartTime, @CompetitionID, @Position)", con))
                    {
                        sc.Connection = con;
                        sc.Parameters.AddWithValue("@CompetitorID", id);
                        sc.Parameters.AddWithValue("@TimeInMs", time.ToString());
                        sc.Parameters.AddWithValue("@StartTime", datetime);
                        sc.Parameters.AddWithValue("@CompetitionID", competitionID);
                        sc.Parameters.AddWithValue("@Position", position);

                        con.Open();

                        if (sc.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
            }
        }

        internal List<Competitor> GetSkiersByTime(int competitionId, string sex)
        {
            List<Competitor> skiers = new List<Competitor>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT [ID],[FirstName],[LastName], dense_rank() over (ORDER BY Results.TimeInMs asc) " +
                    "FROM [dbo].[Results] JOIN [dbo].[Competitors] ON Competitors.ID = Results.CompetitorID " +
                    "WHERE Competitors.Sex = @Sex and competitionID = @CompetitionID";
                using (var command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Sex", sex);
                    command.Parameters.AddWithValue("@CompetitionID", competitionId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            skiers.Add(new Competitor
                            {
                                CompetitorId = reader.GetInt32(0),
                                FirstName = reader[1].ToString(),
                                LastName = reader[2].ToString(),
                                Position = int.Parse(reader[3].ToString())
                            });
                        }
                    }
                }
            }
            return skiers;
        }
        #endregion

        #region BigFinal
        public bool InsertBigFinalResults(int id, TimeSpan time, string datetime, int competitionID)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                    using (SqlCommand sc = new SqlCommand("INSERT INTO Results ([CompetitorID],[TimeInMs], [StartTime], [CompetitionID]) " +
                        "VALUES (@CompetitorID, @TimeInMs, @StartTime, @CompetitionID) ", con))
                    {
                        sc.Connection = con;
                        sc.Parameters.AddWithValue("@CompetitorID", id);
                        sc.Parameters.AddWithValue("@TimeInMs", time.ToString());
                        sc.Parameters.AddWithValue("@StartTime", datetime);
                        sc.Parameters.AddWithValue("@CompetitionID", competitionID);

                        con.Open();
                        if (sc.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }

                        return false;
                    }
            }
        }

        internal List<Competitor> BigFinalCompetitors(List<int> ID, string sex)
        {
            List<Competitor> competitors = new List<Competitor>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT TOP (3) Competitors.ID, [FirstName], [LastName], " +
                    "CAST(CAST(avg(CAST(CAST(Results.timeinms as datetime) AS float)) AS datetime) AS time) AverageTime " +
                " FROM [dbo].[Results] JOIN [dbo].[Competitors] ON Competitors.id = Results.CompetitorID " +
                " JOIN Competitions ON CompetitionID = Competitions.ID" +
                " JOIN (SELECT CompetitionID from Results GROUP BY CompetitionID) t " +
                " ON Results.CompetitionID = t.CompetitionID WHERE Competitions.id IN (" +
                string.Join(",", ID)
                + ")" +
                " AND Competitors.Sex = @Sex " +
                " GROUP BY Competitors.ID, [FirstName],[LastName]" +
                " ORDER BY AverageTime ";
                using (var command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Sex", sex);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            competitors.Add(new Competitor
                            {
                                CompetitorId = reader.GetInt32(0),
                                FirstName = reader[1].ToString(),
                                LastName = reader[2].ToString()
                            });
                        }
                    }
                }
            }
            return competitors;
        }

        internal DataTable BigFinalResults(string sex)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT [FirstName], [LastName], " +
                    "CAST(CAST(avg(CAST(CAST(Results.TimeInMs as datetime) AS float)) AS datetime) AS time) Result" +
                    " FROM [dbo].[Results] JOIN competitors ON Competitors.ID = Results.CompetitorID " +
                    " JOIN BigFinal ON CompetitionID = BigFinal.ID " +
                    " JOIN (SELECT CompetitionID FROM [dbo].[Results] GROUP BY [CompetitionID]) t " +
                    " ON Results.CompetitionID = t.CompetitionID and Results.StartTime = t.max_dt WHERE Results.CompetitionID in(0)" +
                    " and Competitors.Sex = @Sex " +
                    " GROP BY [FirstName], [LastName] " +
                    " ORDER BY Result", con);

                sc.SelectCommand.Parameters.AddWithValue("@Sex", sex);
                sc.Fill(dt);
            }
            return dt;
        }

        internal DataTable BigFinalQualifiers(List<int> ID, string sex)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {

                SqlDataAdapter sc = new SqlDataAdapter("SELECT TOP (3) FirstName, LastName, " +
                    "CAST(CAST(avg(CAST(CAST(Results.timeinms as datetime) AS float)) AS datetime) AS time) AverageTime" +
                    " from [dbo].[Results] JOIN Competitors ON Competitors.ID = Results.CompetitorID" +
                    " JOIN Competitions ON CompetitionID = Competitions.ID" +
                    " JOIN ( select CompetitionID, FROM [dbo].[Results] GROUP BY CompetitionID) t" +
                    " ON Results.CompetitionID = t.CompetitionID and WHERE Competitions.ID IN (" +
                    string.Join(",", ID)
                    + ")" +
                    " and Competitors.Sex = @Sex" +
                    " GROUP BY FirstName, LastName" +
                    " ORDER BY AverageTime", con);
                sc.SelectCommand.Parameters.AddWithValue("@Sex", sex);
                con.Open();
                sc.Fill(dt);
            }
            return dt;
        }
        #endregion

        #region AverageTimes
        public DataTable AverageTimeByTeam()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT dense_rank() OVER (ORDER BY sum(Points) desc) AS ' '," +
                    " [teamID], [TeamName], sum(Points) FROM [dbo].[Competitors] " +
                    "JOIN [dbo].[Teams] ON Teams.ID = TeamID GROUP BY TeamID, TeamName", con);

                sc.Fill(dt);

            }
            return dt;
        }

        internal List<Competitor> AverageTime(string sex)
        {
            List<Competitor> competitors = new List<Competitor>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT dense_rank() over (order by Points desc) , " +
                               "Competitors.ID, [FirstName],[LastName], [Sex], [TeamId], [TeamName], [Points] FROM [dbo].[Competitors] " +
                    " JOIN Teams ON Competitors.TeamID = Teams.ID " +
                    " WHERE Competitors.Sex = @Sex";

                using (var command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Sex", sex);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            competitors.Add(new Competitor
                            {
                                Position = int.Parse(reader[0].ToString()),
                                CompetitorId = reader.GetInt32(1),
                                TeamId = reader.GetInt32(5),
                                FirstName = reader[2].ToString(),
                                LastName = reader[3].ToString(),
                                Sex = reader[4].ToString(),
                                Team = reader[6].ToString(),
                                Points = reader.GetInt32(7)
                            });
                        }
                    }
                }
            }

            return competitors;
        }
        #endregion
        public DataTable TrackBar()
        {

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlDataAdapter sc = new SqlDataAdapter("SELECT * FROM [dbo].[Competitors]", con);

                con.Open();

                sc.Fill(dt);

            }
            return dt;
        }

        public List<Location> Locations()
        {
            List<Location> locations = new List<Location>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT [LocationId], [Location] FROM [dbo].[Locations]";

                using (var command = new SqlCommand(query, con))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            locations.Add(new Location()
                            {
                                LocationId = reader.GetInt32(0),
                                CompetitionLocation = (string)reader[1],
                            });
                        }
                    }
                }

            }
            return locations;
        }
    }
}


