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

        public bool Delete(int ID, string firstName, string lastName)
        {

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from Competitors WHERE (ID = @ID) or (FirstName = @FirstName and LastName = @LastName)", conn);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);


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

        public bool DeleteByID(int ID)
        {

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("delete from Competitors WHERE ID = @ID", conn);
                command.Parameters.AddWithValue("@ID", ID);
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

                while(reader.Read())
                {
                    var id = reader.GetInt32(0);
                    var teamName = reader.GetString(1);
                    teams.Add(new Data(id,teamName));
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
    }
}


