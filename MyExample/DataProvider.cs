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
        public int CompetitionId { get; set; }
        public string CompetitionName { get; set; }
        public string Location { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public bool Finished { get; set; }
        public int Competitors { get; set; }
    }
    public class Competitor
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
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
    }

    public class Location
    {
        public int LocationID { get; set; }
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
                using (SqlCommand sc = new SqlCommand("insert into Competitors (FirstName, LastName, Sex, TeamID, Points) VALUES (@FirstName, @LastName, @Sex, @TeamID, @Points)"))
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
                        MessageBox.Show("Competitor has been registered", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public bool UpdatePoints(int ID, int points)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sc = new SqlCommand("SET ROWCOUNT 1 update Competitors set Points = Points + @Points " +
                    " where ID = @ID SET ROWCOUNT 0"))
                {
                    sc.Connection = con;
                    sc.Parameters.AddWithValue("@ID", ID);
                    sc.Parameters.AddWithValue("@Points", points);

                    con.Open();
                    if (sc.ExecuteNonQuery() > 0)
                    {
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

        public List<Competitor> GetCompetitors(int number)
        {
            List<Competitor> competitors = new List<Competitor>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT top (@ID) Competitors.ID, FirstName, LastName, Sex, Teams.TeamName FROM Competitors " +
                    " join Teams on Competitors.teamid = Teams.id order by newID()";
                using (var command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Id", number);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            competitors.Add(new Competitor()
                            {
                                CompetitorId = (int)reader[0],
                                FirstName = (string)reader[1],
                                LastName = (string)reader[2],
                                Sex = (string)reader[3],
                                Team = (string)reader[4]
                            });
                        }
                    }
                }
            }
            return competitors;
        }

        public bool IfExist(string firstName, string lastName)
        {
            List<Competitor> competitors = new List<Competitor>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT firstName,LastName FROM Competitors where firstName = @Firstname and LastName = @LastName";
                using (var command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Firstname", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);

                    if (command.ExecuteScalar() != null)
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
        public bool CreateCompetition(Guid id, string competitionName, string location, DateTime dateStart, DateTime dateEnd, int competitors)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sc = new SqlCommand("insert into Competitions (Guid, CompetitionName, Location,  DateStart, DateEnd, Finished, Competitors) " +
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
                string query = "SELECT Id, CompetitionName,Location, DateStart, DateEnd, Finished, Competitors from Competitions";

                using (var command = new SqlCommand(query, con))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            competitions.Add(new Competition()
                            {
                                CompetitionId = (int)reader[0],
                                CompetitionName = (string)reader[1],
                                Location = (string)reader[2],
                                DateStart = DateTime.Parse(reader[3].ToString()),
                                DateEnd = DateTime.Parse(reader[4].ToString()),
                                Finished = reader.GetBoolean(5),
                                Competitors = (int)reader[6]
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

        public bool EditCompetition(int ID, string competitionName, string location, DateTime dateStart, DateTime dateEnd, int competitors)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sc = new SqlCommand("SET ROWCOUNT 1 update Competitions set CompetitionName = @CompetitionName, Location = @Location, " +
                    "  DateStart = @DateStart, DateEnd = @DateEnd, Finished = @Finished, Competitors = @Competitors " +
                    " where ID = @ID SET ROWCOUNT 0"))
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
                    else
                    {
                        MessageBox.Show("Record failed");
                        return false;
                    }

                }
            }
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
        public List<Competitor> GetResults(int competitionId, string sex)
        {
            List<Competitor> competitors = new List<Competitor>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT [FirstName],[LastName], sex, TeamId, Results.TimeInMs, TeamName, Competitors.ID " +
                    " FROM Results join competitors on competitors.id = Results.competitorid " +
                    " join competitions on competitions.id = CompetitionID " +
                    " join Teams on Competitors.teamid = Teams.id " +
                    " where CompetitionID = @CompetitionID and competitors.sex = @Sex";

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
                                TeamId = (int)reader[3],
                                CompetitorId = (int)reader[6],
                                FirstName = (string)reader[0],
                                LastName = reader[1].ToString(),
                                Sex = (string)reader[2],
                                Team = (string)reader[5],
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
                try
                {
                    using (SqlCommand sc = new SqlCommand("insert into Results (CompetitorID,TimeInMs, StartTime, CompetitionID, Position) " +
                        "VALUES (@CompetitorID,@TimeInMs,@StartTime, @CompetitionID, @Position)", con))
                    {
                        sc.Connection = con;
                        sc.Parameters.AddWithValue("@CompetitorID", id);
                        sc.Parameters.AddWithValue("@TimeInMs", time.ToString());
                        sc.Parameters.AddWithValue("@StartTime", datetime.ToString());
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
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Error");
                    }
                }
                return true;
            }
        }

        public List<Competitor> GetSkiersByTime(int competitionID, string sex)
        {
            List<Competitor> skiers = new List<Competitor>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT [ID],[FirstName],[LastName], dense_rank() over (order by Results.timeinms asc) " +
                    "FROM Results join competitors on competitors.id = Results.competitorid " +
                    "where competitors.sex = @Sex and competitionID = @CompetitionID order by timeinms";
                using (var command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Sex", sex);
                    command.Parameters.AddWithValue("@CompetitionID", competitionID);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            skiers.Add(new Competitor
                            {
                                CompetitorId = (int)reader[0],
                                FirstName = (string)reader[1],
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
                SqlDataAdapter sc = new SqlDataAdapter("select dense_rank() over (order by sum(points) desc) as ' ', teamID, TeamName, sum(points) Points from Competitors " +
                    "join Teams on teams.id = teamid group by TeamID, TeamName", con);

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
                SqlDataAdapter sc = new SqlDataAdapter("SELECT dense_rank() over (order by Points desc) as ' ', FirstName, LastName, Points from Competitors " +
                    " where competitors.sex = @Sex " +
                    "group by Points, ID,FirstName, LastName", con);

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

        public List<Location> Locations()
        {
            List<Location> locations = new List<Location>();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT LocationID, Location FROM Locations";

                using (var command = new SqlCommand(query, con))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            locations.Add(new Location()
                            {
                                LocationID = (int)reader[0],
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


