using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyExample
{
    public partial class Register : Form
    {
        private FormSkiCompetition skierForm = null;
        private Skier skier = null;
        public Register(FormSkiCompetition skierForm)
        {
            InitializeComponent();
            this.skierForm = skierForm;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string sex = comboBoxSex.Text;
            if (sex.Equals("male"))
            {
                skier = new Boy(textBoxName.Text, textBoxLastName.Text);
                skier.Team = comboBoxTeam.Text;
                skierForm.GetBoys().Add((Boy)skier);

            }
            else if(sex.Equals("female"))
            {
                skier = new Girl(textBoxName.Text, textBoxLastName.Text);
                skier.Team = comboBoxTeam.Text;
                skierForm.GetGirls().Add((Girl)skier);

            }
            else
                return;
            
            List<Skier> skiers = skierForm.GetSkiersByTeam((Team)comboBoxTeam.SelectedItem);

            skiers.Add(skier);

            DialogResult = DialogResult.OK;

            using (SqlConnection con = new SqlConnection(@"Data Source=EADOSSEVADW;Initial Catalog=SkiCompetition;Integrated Security=True"))
            {
                using (SqlCommand sc = new SqlCommand("insert into StartList (FirstName, LastName, Sex, Team) VALUES (@FirstName, @LastName, @Sex, @Team)"))
                {
                    sc.Connection = con;
                    sc.Parameters.AddWithValue("@FirstName", textBoxName.Text);
                    sc.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                    sc.Parameters.AddWithValue("@Sex", comboBoxSex.GetItemText(comboBoxSex.SelectedItem));
                    sc.Parameters.AddWithValue("@Team", comboBoxTeam.GetItemText(comboBoxTeam.SelectedItem));

                    con.Open();
                    if(sc.ExecuteNonQuery()>0)
                    {
                        MessageBox.Show("Record has been inserted");                        
                    }
                    else
                    {
                        MessageBox.Show("Record failed");
                    }

                }

                    
            }
            
        }

    }
}
