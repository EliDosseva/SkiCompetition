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

        private void FormRank_Load(object sender, EventArgs e)
        {
            dataGridViewFemale.Columns[0].Visible = false;
            dataGridViewFemale.Columns[3].Visible = false;
            dataGridViewFemale.Columns[4].Visible = false;
            dataGridViewFemale.Columns[5].Visible = false;
            dataGridViewFemale.Columns[7].Visible = false;
            dataGridViewFemale.Columns[8].Visible = false;

            dataGridViewFemale.Columns[1].HeaderText = "First name";
            dataGridViewFemale.Columns[2].HeaderText = "Last name";

            dataGridViewMale.Columns[0].Visible = false;
            dataGridViewMale.Columns[3].Visible = false;
            dataGridViewMale.Columns[4].Visible = false;
            dataGridViewMale.Columns[5].Visible = false;
            dataGridViewMale.Columns[7].Visible = false;
            dataGridViewMale.Columns[8].Visible = false;

            dataGridViewMale.Columns[1].HeaderText = "First name";
            dataGridViewMale.Columns[2].HeaderText = "Last name";

            dataGridViewFemale.ClearSelection();
            dataGridViewMale.ClearSelection();

            //listBoxRankFemale.ValueMember = "FirstName";
        }

        private void ButtonOKCloseForm_Click(object sender, EventArgs e)
        {
            skierForm.RefreshGrid();
            this.Close();
        }

        public void Results()
        {
            int competitionId = int.Parse(skierForm.listBoxCompetitions.SelectedValue.ToString());
            int competitorsCount = ((Competition)skierForm.listBoxCompetitions.SelectedItem).Competitors;


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
                List<Competitor> all = dataProvider.GetCompetitors(competitorsCount);

                foreach (var item in all)
                {
                    var randomTime = start + TimeSpan.FromMilliseconds(random.Next(difference));
                    dataProvider.InsertResults(item.CompetitorId, randomTime, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), competitionId, item.Position);
                }
                dataProvider.IsFinished(competitionId);

                skierForm.dataGridViewMaleAvg.DataSource = dataProvider.AverageTime("male");
                skierForm.dataGridViewFemaleAvg.DataSource = dataProvider.AverageTime("female");
                skierForm.dataGridViewTeamRank.DataSource = dataProvider.AverageTimeByTeam();

                dataGridViewMale.DataSource = dataProvider.GetResults(competitionId, "male");
                dataGridViewFemale.DataSource = dataProvider.GetResults(competitionId, "female");

                

                List<Competitor> males = dataProvider.GetSkiersByTime(competitionId, "male");
                List<Competitor> females = dataProvider.GetSkiersByTime(competitionId, "female");

                var competitors = males.Concat(females);
                foreach (var item in competitors)
                {
                    switch(item.Position)
                    {
                        case 1:
                            item.Points += 10;
                            break;
                        case 2:
                            item.Points += 9;
                            break;
                        case 3:
                            item.Points += 8;
                            break;
                        case 4:
                            item.Points += 7;
                            break;
                        case 5:
                            item.Points += 6;
                            break;
                        case 6:
                            item.Points += 5;
                            break;
                        case 7:
                            item.Points += 4;
                            break;
                        case 8:
                            item.Points += 3;
                            break;
                        case 9:
                            item.Points += 2;
                            break;
                        case 10:
                            item.Points += 1;
                            break;
                    }
                    dataProvider.UpdatePoints(item.CompetitorId, item.Points);
                }

                buttonOK.Text = "Finish competition";
                
            }
            listBoxRankFemale.DataSource = dataProvider.GetSkiersByTime(competitionId, "female");
            listBoxRankMale.DataSource = dataProvider.GetSkiersByTime(competitionId, "male");

        }

        private void DataGridViewMale_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            skierForm.DataGridViewDoubleClick(sender, e, dataGridViewMale);
            dataGridViewFemale.ClearSelection();
            dataGridViewMale.ClearSelection();
        }

        private void DataGridViewFemale_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            skierForm.DataGridViewDoubleClick(sender, e, dataGridViewFemale);
            dataGridViewFemale.ClearSelection();
            dataGridViewMale.ClearSelection();
        }
    }
}
