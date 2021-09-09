using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyExample
{
    public partial class FrmCompetitionSelect : Form
    {
        
        private readonly DataProvider dataProvider;
        public FrmCompetitionSelect(string connection)
        {
            InitializeComponent();
            this.dataProvider = new DataProvider(connection);
        }

        private void CompetitionSelectForm_Load(object sender, EventArgs e)
        {
            listBoxCompetitions.DataSource = dataProvider.CompetitionTable();
            //listBoxCompetitions.ValueMember = "ID";
            //listBoxCompetitions.DisplayMember = "CompetitionName";
            listBoxCompetitions.SelectedIndex = -1;
        }

        private void ButtonGetBigFinalCompetitors(object sender, EventArgs e)
        {
            List<int> competitionIDs = new List<int>();
            foreach (var item in listBoxCompetitions.SelectedItems)
            {
                var items = ((KeyValuePair<int, string>)item).Key;
                competitionIDs.Add(items);
            }

            dataGridViewMale.DataSource = dataProvider.BigFinalQualifiers(competitionIDs, "male");
            dataGridViewFemale.DataSource = dataProvider.BigFinalQualifiers(competitionIDs, "female");
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            List<int> IDs = new List<int>();
            
            Random random = new Random();
            var start = TimeSpan.FromSeconds(20);
            var end = TimeSpan.FromMinutes(2);
            var difference = (int)(end.TotalMilliseconds - start.TotalMilliseconds);
            foreach (var item in listBoxCompetitions.SelectedItems)
            {
                var items = ((KeyValuePair<int, string>)item).Key;
                IDs.Add(items);
            }
            var finalistsFemale = dataProvider.BigFinalCompetitors(IDs, "female");
            var finalistsMale = dataProvider.BigFinalCompetitors(IDs, "male");
           
            foreach (var item in finalistsFemale)
            {
                
                var randomTime = start + TimeSpan.FromMilliseconds(random.Next(difference));
                dataProvider.InsertBigFinalResults(item.CompetitorId, randomTime, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),0);
            }

            foreach (var item in finalistsMale)
            {

                var randomTime = start + TimeSpan.FromMilliseconds(random.Next(difference));
                dataProvider.InsertBigFinalResults(item.CompetitorId, randomTime, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),0);
            }
            var fsc = new FrmSkiCompetition();
            fsc.BigFinalForm();
        }

        private void ButtonOKCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
