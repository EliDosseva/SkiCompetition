using System;
using System.Collections.Generic;
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
    public class DataProvider
    {
        private readonly string _connectionString;

        public DataProvider(string connectionString)
        {
            _connectionString = connectionString;
        }

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
                        MessageBox.Show("Record has been inserted");
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

        public Skier GetCompetitor()
        {
            Skier skier = null;
            SqlConnection con = new SqlConnection(_connectionString);
            using (SqlDataAdapter sc = new SqlDataAdapter("SELECT * FROM Competitors", con))
            {
                DataTable dt = new DataTable();
                sc.Fill(dt);
                skier = (from DataRow dr in dt.Rows
                         select new Skier()
                         {
                             Name = dr["FirstName"].ToString(),
                             LastName = dr["LastName"].ToString(),
                             Sex = dr["Sex"].ToString(),
                             Team = dr["TeamID"].ToString()
                         }).FirstOrDefault();
            }

            return skier;
        }


        public bool Delete(int insert)
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


        public List<Data> ComboBoxTeam()
        {
            var teams = new List<Data>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand sc = new SqlCommand("SELECT ID,[teamname] FROM TeamTable", con);

                con.Open();

                SqlDataReader reader = sc.ExecuteReader();

                while (reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var teamName = reader.GetString(1);
                    teams.Add(new Data(id, teamName));
                }
                reader.Close();
            }
            return teams;
        }

        public DataTable Create()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlDataAdapter sc = new SqlDataAdapter("select Competitors.id, Competitors.firstname, Competitors.lastname, competitors.sex, teamtable.teamname " +
                    "from competitors join teamtable on competitors.teamid = teamtable.id; ", con);

                sc.Fill(dt);

            }
            return dt;
        }


        public bool InsertResults(int id, TimeSpan time, string datetime, int competitionID)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                using (SqlCommand sc = new SqlCommand("insert into TableTimes (CompetitorID,TimeInMs, DateTime, CompetitionID) VALUES (@CompetitorID,@TimeInMs,@DateTime, @CompetitionID) ", con))
                {
                    sc.Connection = con;
                    sc.Parameters.AddWithValue("@CompetitorID", id);
                    sc.Parameters.AddWithValue("@TimeInMs", time.ToString());
                    sc.Parameters.AddWithValue("@Datetime", datetime.ToString());
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

        public List<Skier> BigFinalCompetitorsFemale(List<int> ID)
        {
            List<Skier> females = new List<Skier>();
            SqlConnection con = new SqlConnection(_connectionString);
            
                using (SqlDataAdapter sc = new SqlDataAdapter("SELECT TOP (3) competitors.ID, [FirstName],[LastName], cast(cast(sum(cast(CAST(TableTimes.timeinms as datetime) as float)) as datetime) as time) SumTime" +
                    " from TableTimes join competitors on competitors.id = tabletimes.competitorid" +
                    " join tablecompetitions on CompetitionID = tablecompetitions.id" +
                    " join ( select CompetitionID, max(DateTime) as max_dt from TableTimes group by CompetitionID) t" +
                    " on TableTimes.CompetitionID = t.CompetitionID and TableTimes.DateTime = t.max_dt where tablecompetitions.id in (" +
                    string.Join(",", ID)
                    + ")" +
                    " and competitors.sex = 'female' " +
                    " group by competitors.ID, [FirstName],[LastName]" +
                    " order by SumTime ", con))
                {
                    DataTable dt = new DataTable();
                    sc.Fill(dt);
                    

                    females = (from DataRow dr in dt.Rows
                               select new Skier()
                               {
                                   ID = Convert.ToInt32(dr["ID"].ToString()),
                                   Name = dr["FirstName"].ToString(),
                                   LastName = dr["LastName"].ToString(),
                               }).ToList();
                }

                return females;
        }

        public List<Skier> BigFinalCompetitorsMale(List<int> ID)
        {
            List<Skier> males = new List<Skier>();
            SqlConnection con = new SqlConnection(_connectionString);

            using (SqlDataAdapter sc = new SqlDataAdapter("SELECT TOP (3) competitors.ID, [FirstName],[LastName], cast(cast(sum(cast(CAST(TableTimes.timeinms as datetime) as float)) as datetime) as time) SumTime" +
                " from TableTimes join competitors on competitors.id = tabletimes.competitorid" +
                " join tablecompetitions on CompetitionID = tablecompetitions.id" +
                " join ( select CompetitionID, max(DateTime) as max_dt from TableTimes group by CompetitionID) t" +
                " on TableTimes.CompetitionID = t.CompetitionID and TableTimes.DateTime = t.max_dt where tablecompetitions.id in (" +
                string.Join(",", ID)
                + ")" +
                " and competitors.sex = 'male' " +
                " group by competitors.ID, [FirstName],[LastName]" +
                " order by SumTime ", con))
            {
                DataTable dt = new DataTable();
                sc.Fill(dt);


                males = (from DataRow dr in dt.Rows
                           select new Skier()
                           {
                               ID = Convert.ToInt32(dr["ID"].ToString()),
                               Name = dr["FirstName"].ToString(),
                               LastName = dr["LastName"].ToString(),
                           }).ToList();
            }

            return males;
        }

        public DataTable TimesMale()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT [FirstName],[LastName],tabletimes.TimeInMs FROM TableTimes join competitors on competitors.id = tabletimes.competitorid " +
                    "where competitors.sex = 'male' and datetime = (select max(datetime) from tabletimes)", con);

                sc.Fill(dt);

            }
            return dt;
        }

        public DataTable TimesFemale()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT [FirstName],[LastName],tabletimes.TimeInMs FROM TableTimes join competitors on competitors.id = tabletimes.competitorid " +
                    "where competitors.sex = 'female'and datetime = (select max(datetime) from tabletimes)", con);

                sc.Fill(dt);

            }
            return dt;
        }

        public DataTable TimesFemaleBigFinal()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT FirstName, cast(cast(sum(cast(CAST(TableTimes.timeinms as datetime) as float)) as datetime) as time) SumTime" +
                    " from TableTimes join competitors on competitors.id = tabletimes.competitorid " +
                    " join tablecompetitions on CompetitionID = tablecompetitions.id " +
                    " join ( select CompetitionID, max(DateTime) as max_dt from TableTimes group by CompetitionID) t " +
                    " on TableTimes.CompetitionID = t.CompetitionID and TableTimes.DateTime = t.max_dt where TableTimes.CompetitionID in(10)" +
                    " and competitors.sex = 'female' " +
                    " group by firstName " +
                    " order by SumTime", con);

                sc.Fill(dt);

            }
            return dt;
        }

        public DataTable TimesMaleBigFinal()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT FirstName, cast(cast(sum(cast(CAST(TableTimes.timeinms as datetime) as float)) as datetime) as time) SumTime" +
                    " from TableTimes join competitors on competitors.id = tabletimes.competitorid " +
                    " join tablecompetitions on CompetitionID = tablecompetitions.id " +
                    " join ( select CompetitionID, max(DateTime) as max_dt from TableTimes group by CompetitionID) t " +
                    " on TableTimes.CompetitionID = t.CompetitionID and TableTimes.DateTime = t.max_dt where TableTimes.CompetitionID in(10) " +
                    " and competitors.sex = 'male' " +
                    " group by firstName " +
                    " order by SumTime", con);

                sc.Fill(dt);

            }
            return dt;
        }

        public List<Skier> GetFemales()
        {
            List<Skier> females = new List<Skier>();
            SqlConnection con = new SqlConnection(_connectionString);
            using (SqlDataAdapter sc = new SqlDataAdapter("SELECT [ID],[FirstName],[LastName],tabletimes.TimeInMs FROM TableTimes join competitors on competitors.id = tabletimes.competitorid " +
                    "where competitors.sex = 'female' and datetime = (select max(datetime) from tabletimes)", con))
            {
                DataTable dt = new DataTable();
                sc.Fill(dt);
                females = (from DataRow dr in dt.Rows
                           select new Skier()
                           {
                               ID = Convert.ToInt32(dr["ID"].ToString()),
                               Name = dr["FirstName"].ToString(),
                               LastName = dr["LastName"].ToString(),
                               Time = TimeSpan.Parse(dr["TimeInMs"].ToString())
                           }).ToList();
            }

            return females;
        }

        public List<Skier> GetMales()
        {
            List<Skier> females = new List<Skier>();
            SqlConnection con = new SqlConnection(_connectionString);
            using (SqlDataAdapter sc = new SqlDataAdapter("SELECT [ID],[FirstName],[LastName],tabletimes.TimeInMs FROM TableTimes join competitors on competitors.id = tabletimes.competitorid " +
                    "where competitors.sex = 'male'and datetime = (select max(datetime) from tabletimes)", con))
            {
                DataTable dt = new DataTable();
                sc.Fill(dt);
                females = (from DataRow dr in dt.Rows
                           select new Skier()
                           {
                               ID = Convert.ToInt32(dr["ID"].ToString()),
                               Name = dr["FirstName"].ToString(),
                               LastName = dr["LastName"].ToString(),
                               Time = TimeSpan.Parse(dr["TimeInMs"].ToString())
                           }).ToList();
            }

            return females;
        }
        public DataTable SumResults()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT [CompetitorID],(TimeInMs) FROM TableTimes", con);

                sc.Fill(dt);

            }
            return dt;
        }

        public DataTable AverageTimeByTeam()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT TeamName, cast(cast(avg(cast(CAST(TableTimes.timeinms as datetime) as float)) as datetime) as time) AvgTime from TableTimes " +
                    "join competitors on competitors.id = tabletimes.competitorid " +
                    "join teamtable on competitors.teamid = teamtable.id group by teamname order by [AvgTime]", con);

                sc.Fill(dt);

            }
            return dt;
        }
        public DataTable AverageTimeMale()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT FirstName, cast(cast(avg(cast(CAST(TableTimes.timeinms as datetime) as float)) as datetime) as time) AvgTime from TableTimes " +
                    "join competitors on competitors.id = tabletimes.competitorid where competitors.sex = 'male'" +
                    "group by ID,firstname order by [AvgTime]", con);

                sc.Fill(dt);

            }
            return dt;
        }
        public DataTable AverageTimeFemale()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT FirstName, cast(cast(avg(cast(CAST(TableTimes.timeinms as datetime) as float)) as datetime) as time) AvgTime from TableTimes " +
                    "join competitors on competitors.id = tabletimes.competitorid where competitors.sex = 'female'" +
                    "group by ID,firstname order by [AvgTime]", con);

                sc.Fill(dt);

            }
            return dt;
        }

        public DataTable BigFinalMale(List<int> ID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                CompetitionSelectForm csf = new CompetitionSelectForm(_connectionString);

                SqlDataAdapter sc = new SqlDataAdapter("SELECT TOP (3) FirstName, cast(cast(sum(cast(CAST(TableTimes.timeinms as datetime) as float)) as datetime) as time) SumTime" +
                    " from TableTimes join competitors on competitors.id = tabletimes.competitorid" +
                    " join tablecompetitions on CompetitionID = tablecompetitions.id" +
                    " join ( select CompetitionID, max(DateTime) as max_dt from TableTimes group by CompetitionID) t" +
                    " on TableTimes.CompetitionID = t.CompetitionID and TableTimes.DateTime = t.max_dt where tablecompetitions.id in (" +
                    string.Join(",", ID)
                    + ")"+
                    " and competitors.sex = 'male'" +
                    " group by firstName" +
                    " order by SumTime", con);

                con.Open();
                sc.Fill(dt);

            }
            return dt;
        }

        public DataTable BigFinalFemale(List<int> ID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlDataAdapter sc = new SqlDataAdapter("SELECT TOP (3) FirstName, cast(cast(sum(cast(CAST(TableTimes.timeinms as datetime) as float)) as datetime) as time) SumTime" +
                    " from TableTimes join competitors on competitors.id = tabletimes.competitorid" +
                    " join tablecompetitions on CompetitionID = tablecompetitions.id" +
                    " join ( select CompetitionID, max(DateTime) as max_dt from TableTimes group by CompetitionID) t" +
                    " on TableTimes.CompetitionID = t.CompetitionID and TableTimes.DateTime = t.max_dt where tablecompetitions.id in (" +
                    string.Join(",", ID)
                    + ")" +
                    " and competitors.sex = 'female'" +
                    " group by firstName" +
                    " order by SumTime", con);

                con.Open();
                sc.Fill(dt);

            }
            return dt;
        }


        
        public DataTable CompetitionTable()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT Id, CompetitionName from tablecompetitions", con);
                
                sc.Fill(dt);

            }
            return dt;
        }

       
    }
}


