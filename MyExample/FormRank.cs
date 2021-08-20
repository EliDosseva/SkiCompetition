using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyExample
{
    [Serializable]
    public partial class FormRank : Form
    {
        private FormSkiCompetition skierForm = null;
        private DataProvider dataProvider;

        public FormRank(FormSkiCompetition skierForm, string connection)
        {
            InitializeComponent();
            this.skierForm = skierForm;

            this.dataProvider = new DataProvider(connection);
        }

        private void ButtonOKCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Results()
        {
            int competitionId = int.Parse(skierForm.listBoxCompetitions.SelectedValue.ToString());


            if (((Competition)skierForm.listBoxCompetitions.SelectedItem).Finished == true)
            {
                dataGridViewMale.DataSource = dataProvider.GetResults(competitionId, "male");
                dataGridViewFemale.DataSource = dataProvider.GetResults(competitionId, "female");
            }
            else
            {
                Random random = new Random();
                var start = TimeSpan.FromSeconds(20);
                var end = TimeSpan.FromMinutes(2);
                var difference = (int)(end.TotalMilliseconds - start.TotalMilliseconds);
                List<Skier> all = dataProvider.GetCompetitors();

                foreach (var item in all)
                {
                    var randomTime = start + TimeSpan.FromMilliseconds(random.Next(difference));
                    dataProvider.InsertResults(item.ID, randomTime, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), competitionId);
                }
                dataProvider.IsFinished(competitionId);

                skierForm.dataGridViewMaleAvg.DataSource = dataProvider.AverageTime("male");
                skierForm.dataGridViewFemaleAvg.DataSource = dataProvider.AverageTime("female");
                skierForm.dataGridViewTeamRank.DataSource = dataProvider.AverageTimeByTeam();
            }

            dataGridViewMale.DataSource = dataProvider.GetResults(competitionId, "male");
            dataGridViewFemale.DataSource = dataProvider.GetResults(competitionId, "female");


            listBoxRankFemale.DataSource = dataProvider.GetSkiersByTime(competitionId, "female");
            listBoxRankMale.DataSource = dataProvider.GetSkiersByTime(competitionId, "male");
        }

    }
}
