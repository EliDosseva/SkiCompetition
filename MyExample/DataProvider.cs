using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data = System.Collections.Generic.KeyValuePair<int, string>;

namespace MyExample
{
    public class Result
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public TimeSpan TimeInMs { get; set; }
    }

    public class Competition
    {
        public int ID { get; set; }
        public string CompetitionName { get; set; }
        public string Location { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public bool Finished { get; set; }
    }

    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
    }

    public class DataProvider
    {
        private readonly string _connectionString;

        public DataProvider(string connectionString)
        {
            _connectionString = connectionString;
        }
        #region Competitors
        public bool CreateCompetitor(string firstName, string lastName, string sex, int ID)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sc = new SqlCommand("insert into Competitors (FirstName, LastName, Sex, TeamID) VALUES (@FirstName, @LastName, @Sex, @TeamID)"))
                {
                    sc.Connection = con;
                    sc.Parameters.AddWithValue("@FirstName", firstName);
                    sc.Parameters.AddWithValue("@LastName", lastName);
                    sc.Parameters.AddWithValue("@Sex", sex);
                    sc.Parameters.AddWithValue("@TeamID", ID);

                    con.Open();
                    if (sc.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Competitor has been registered");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Record failed");
                        return false;
                    }

                }
            }
        }
        public bool EditCompetitor(int ID, string firstName, string lastName, string sex, int teamId)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sc = new SqlCommand("SET ROWCOUNT 1 update Competitors set FirstName = @FirstName, LastName = @LastName, Sex = @Sex, TeamID = @TeamID " +
                    " where ID = @ID SET ROWCOUNT 0"))
                {
                    sc.Connection = con;
                    sc.Parameters.AddWithValue("@ID", ID);
                    sc.Parameters.AddWithValue("@FirstName", firstName);
                    sc.Parameters.AddWithValue("@LastName", lastName);
                    sc.Parameters.AddWithValue("@Sex", sex);
                    sc.Parameters.AddWithValue("@TeamID", teamId);

                    con.Open();
                    if (sc.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Competitor's data has been edited");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Record failed");
                        return false;
                    }

                }
            }
        }

        public List<Skier> GetCompetitors()
        {
            List<Skier> competitors = new List<Skier>();

            SqlConnection con = new SqlConnection(_connectionString);
            using (SqlDataAdapter sc = new SqlDataAdapter("SELECT * FROM Competitors", con))
            {
                DataTable dt = new DataTable();

                sc.Fill(dt);
                competitors = (from DataRow dr in dt.Rows
                               select new Skier()
                               {
                                   ID = Convert.ToInt32(dr["ID"].ToString()),
                                   Name = dr["FirstName"].ToString(),
                                   LastName = dr["LastName"].ToString(),
                                   Sex = dr["Sex"].ToString(),
                                   Team = dr["TeamID"].ToString()
                               }).ToList();
            }
            return competitors;
        }


        public bool DeleteCompetitor(int insert)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from Competitors WHERE ID = @ID", conn);
                command.Parameters.AddWithValue("@ID", insert);
                int rows = command.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Deletion Successfull");
                    return true;
                }
                else
                    MessageBox.Show("Deletion Unsuccessfull");
                return false;
            }
        }

        public DataTable Competitors()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlDataAdapter sc = new SqlDataAdapter("select Competitors.id, Competitors.FirstName, Competitors.LastName, competitors.Sex, Teams.TeamName " +
                    "from competitors join Teams on Competitors.teamid = Teams.id; ", con);

                sc.Fill(dt);

            }
            return dt;
        }
        #endregion

        #region Competitions
        public bool CreateCompetition(Guid id, string competitionName, string location, SelectionRange date)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sc = new SqlCommand("insert into Competitions (Guid, CompetitionName, Location, DateStart, DateEnd, Finished) VALUES (@Guid, @CompetitionName, @Location, @DateStart, @DateEnd, @Finished)"))
                {
                    sc.Connection = con;
                    sc.Parameters.AddWithValue("@Guid", id);
                    sc.Parameters.AddWithValue("@CompetitionName", competitionName);
                    sc.Parameters.AddWithValue("@Location", location);
                    sc.Parameters.AddWithValue("@DateStart", date.Start);
                    sc.Parameters.AddWithValue("@DateEnd", date.End);
                    sc.Parameters.AddWithValue("@Finished", 0);

                    con.Open();
                    if (sc.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Competition has been registered");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Record failed");
                        return false;
                    }

                }
            }
        }

        public List<Competition> GetCompetition()
        {
            List<Competition> competitions = new List<Competition>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT Id, CompetitionName,Location, DateStart, DateEnd, Finished from Competitions";

                using (var command = new SqlCommand(query, con))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            competitions.Add(new Competition()
                            {
                                ID = (int)reader[0],
                                CompetitionName = (string)reader[1],
                                Location = (string)reader[2],
                                DateStart = DateTime.Parse(reader[3].ToString()),
                                DateEnd = DateTime.Parse(reader[4].ToString()),
                                Finished = reader.GetBoolean(5)
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
                using (SqlCommand sc = new SqlCommand("update Competitions set finished = 1 where ID = @ID"))
                    
                {
                    sc.Connection = con;
                    sc.Parameters.AddWithValue("@ID", ID);
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

        public BindingList<Data> CompetitionTable()
        {
            var competitions = new BindingList<Data>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand sc = new SqlCommand("SELECT Id, CompetitionName from Competitions", con);

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
        #endregion

        #region Teams
        public DataTable ComboBoxTeam()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlDataAdapter sc = new SqlDataAdapter("SELECT ID,[teamname] FROM Teams", con);

                con.Open();

                sc.Fill(dt);
            }
            return dt;
        }

        public List<Team> TeamSelection()
        {
            List<Team> team = new List<Team>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT ID, TeamName FROM Teams";

                using (var command = new SqlCommand(query, con))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            team.Add(new Team()
                            {
                                TeamID = (int)reader[0],
                                TeamName = (string)reader[1],
                            });
                        }
                    }
                }

            }
            return team;
        }

        public List<Skier> GetTeamMembers(int id)
        {
            List<Skier> competitors = new List<Skier>();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlDataAdapter sc = new SqlDataAdapter("select [FirstName],[LastName] from Competitors join Teams on Competitors.teamid = Teams.id where teamID = @ID", con);

                sc.SelectCommand.Parameters.AddWithValue("@ID", id);
                con.Open();
                sc.Fill(dt);
                competitors = (from DataRow dr in dt.Rows
                               select new Skier()
                               {
                                   Name = dr["FirstName"].ToString(),
                                   LastName = dr["LastName"].ToString()
                               }).ToList();
            }
            return competitors;
        }
        #endregion

        #region Results
        public List<Result> GetResults(int competitionId, string sex)
        {
            List<Result> results = new List<Result>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT [FirstName],[LastName], Results.TimeInMs FROM Results join competitors on competitors.id = Results.competitorid " +
                    " join competitions on competitions.id = CompetitionID " +
                    " where CompetitionID = @CompetitionID and competitors.sex = @Sex";

                using (var command = new SqlCommand(query,con))
                {
                    command.Parameters.AddWithValue("@CompetitionID", competitionId);
                    command.Parameters.AddWithValue("@Sex", sex);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(new Result
                            {
                                FirstName = (string)reader[0],
                                LastName = reader[1].ToString(),
                                TimeInMs = TimeSpan.Parse(reader[2].ToString())
                            });
                        }
                    }
                }
            }

            return results;
        }


        public bool InsertResults(int id, TimeSpan time, string datetime, int competitionID)
        {

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                try
                {
                    using (SqlCommand sc = new SqlCommand("insert into Results (CompetitorID,TimeInMs, StartTime, CompetitionID) VALUES (@CompetitorID,@TimeInMs,@StartTime, @CompetitionID)", con))
                    {
                        sc.Connection = con;
                        sc.Parameters.AddWithValue("@CompetitorID", id);
                        sc.Parameters.AddWithValue("@TimeInMs", time.ToString());
                        sc.Parameters.AddWithValue("@StartTime", datetime.ToString());
                        sc.Parameters.AddWithValue("@CompetitionID", competitionID);

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
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                    }

                }
                return true;
            }
        }

        public List<Skier> GetSkiersByTime(int competitionID, string sex)
        {
            List<Skier> skiers = new List<Skier>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT [ID],[FirstName],[LastName],Results.TimeInMs FROM Results join competitors on competitors.id = Results.competitorid " +
                    "where competitors.sex = @Sex and competitionID = @CompetitionID order by timeinms", con);

                sc.SelectCommand.Parameters.AddWithValue("@Sex", sex);
                sc.SelectCommand.Parameters.AddWithValue("@CompetitionID", competitionID);

                DataTable dt = new DataTable();
                sc.Fill(dt);
                skiers = (from DataRow dr in dt.Rows
                          select new Skier()
                          {
                              ID = Convert.ToInt32(dr["ID"].ToString()),
                              Name = dr["FirstName"].ToString(),
                              LastName = dr["LastName"].ToString(),
                              Time = TimeSpan.Parse(dr["TimeInMs"].ToString())
                          }).ToList();

            }


            return skiers;
        }
        #endregion

        #region BigFinal
        public bool InsertBigFinalResults(int id, TimeSpan time, string datetime, int competitionID)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sc = new SqlCommand("insert into Results (CompetitorID,TimeInMs, StartTime, CompetitionID) VALUES (@CompetitorID,@TimeInMs,@StartTime, @CompetitionID) ", con))
                {
                    sc.Connection = con;
                    sc.Parameters.AddWithValue("@CompetitorID", id);
                    sc.Parameters.AddWithValue("@TimeInMs", time.ToString());
                    sc.Parameters.AddWithValue("@StartTime", datetime.ToString());
                    sc.Parameters.AddWithValue("@CompetitionID", competitionID);



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

        public List<Skier> BigFinalCompetitors(List<int> ID, string sex)
        {
            List<Skier> competitors = new List<Skier>();
            SqlConnection con = new SqlConnection(_connectionString);

            using (SqlDataAdapter sc = new SqlDataAdapter("SELECT TOP (3) Competitors.ID, [FirstName],[LastName], cast(cast(avg(cast(CAST(Results.timeinms as datetime) as float)) as datetime) as time) AverageTime " +
                " from Results join Competitors on Competitors.id = Results.CompetitorID " +
                " join Competitions on CompetitionID = Competitions.id " +
                " join ( select CompetitionID, max(StartTime) as max_dt from Results group by CompetitionID) t " +
                " on Results.CompetitionID = t.CompetitionID and Results.StartTime = t.max_dt where Competitions.id in (" +
                string.Join(",", ID)
                + ")" +
                " and competitors.sex = @Sex " +
                " group by competitors.ID, [FirstName],[LastName]" +
                " order by AverageTime ", con))
            {
                sc.SelectCommand.Parameters.AddWithValue("@Sex", sex);
                DataTable dt = new DataTable();
                sc.Fill(dt);


                competitors = (from DataRow dr in dt.Rows
                               select new Skier()
                               {
                                   ID = Convert.ToInt32(dr["ID"].ToString()),
                                   Name = dr["FirstName"].ToString(),
                                   LastName = dr["LastName"].ToString(),
                               }).ToList();
            }

            return competitors;
        }


        public DataTable BigFinalResults(string sex)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT FirstName, LastName, cast(cast(avg(cast(CAST(Results.timeinms as datetime) as float)) as datetime) as time) Result" +
                    " from Results join competitors on competitors.id = Results.competitorid " +
                    " join BigFinal on CompetitionID = BigFinal.id " +
                    " join ( select CompetitionID, max(StartTime) as max_dt from Results group by CompetitionID) t " +
                    " on Results.CompetitionID = t.CompetitionID and Results.StartTime = t.max_dt where Results.CompetitionID in(0)" +
                    " and competitors.sex = @Sex " +
                    " group by FirstName, LastName " +
                    " order by Result", con);

                sc.SelectCommand.Parameters.AddWithValue("@Sex", sex);
                sc.Fill(dt);

            }
            return dt;
        }

        public DataTable BigFinalQualifiers(List<int> ID, string sex)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                CompetitionSelectForm csf = new CompetitionSelectForm(_connectionString);

                SqlDataAdapter sc = new SqlDataAdapter("SELECT TOP (3) FirstName, LastName, CAST(CAST(avg(CAST(CAST(Results.timeinms as datetime) as float)) as datetime) as time) AverageTime" +
                    " from Results join competitors on competitors.id = Results.competitorid" +
                    " join Competitions on CompetitionID = Competitions.id" +
                    " join ( select CompetitionID, max(StartTime) as max_dt from Results group by CompetitionID) t" +
                    " on Results.CompetitionID = t.CompetitionID and Results.StartTime = t.max_dt where Competitions.id in (" +
                    string.Join(",", ID)
                    + ")" +
                    " and competitors.sex = @Sex" +
                    " group by FirstName, LastName" +
                    " order by AverageTime", con);
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
                SqlDataAdapter sc = new SqlDataAdapter("SELECT TeamID, TeamName, cast(cast(avg(cast(CAST(Results.timeinms as datetime) as float)) as datetime) as time) AverageTime from Results " +
                    "join competitors on competitors.id = Results.competitorid " +
                    "join Teams on competitors.teamid = Teams.id group by teamID, TeamName order by [AverageTime]", con);

                sc.Fill(dt);

            }
            return dt;
        }

        public DataTable AverageTime(string sex)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT FirstName, LastName, cast(cast(avg(cast(CAST(Results.timeinms as datetime) as float)) as datetime) as time) AverageTime from Results " +
                    "join competitors on competitors.id = Results.competitorid where competitors.sex = @Sex " +
                    "group by ID,FirstName, LastName order by [AverageTime]", con);

                sc.SelectCommand.Parameters.AddWithValue("@Sex", sex);
                sc.Fill(dt);

            }
            return dt;
        }
        #endregion
        public DataTable TrackBar()
        {

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlDataAdapter sc = new SqlDataAdapter("SELECT * FROM Competitors", con);

                con.Open();

                sc.Fill(dt);

            }
            return dt;
        }

    }
}


