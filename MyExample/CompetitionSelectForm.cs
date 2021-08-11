using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyExample
{
    public partial class CompetitionSelectForm : Form
    {
        
        private DataProvider dataProvider;
        public CompetitionSelectForm(string connection)
        {
            InitializeComponent();
            this.dataProvider = new DataProvider(connection);
        }

        private void CompetitionSelectForm_Load(object sender, EventArgs e)
        {
            listBoxCompetitions.DataSource = dataProvider.CompetitionTable();
            listBoxCompetitions.ValueMember = "ID";
            listBoxCompetitions.DisplayMember = "CompetitionName";
            listBoxCompetitions.SelectedIndex = -1;
        }

        private void ButtonGetBigFinalCompetitors(object sender, EventArgs e)
        {
            WaitForm wf = new WaitForm();
            wf.FormClosed += new FormClosedEventHandler(GetBigFinalCompetitors);
            wf.Show(this);
            
        }

        
        private void GetBigFinalCompetitors(object sender, EventArgs e)
        {
            List<int> competitionIDs = new List<int>();
            foreach (var item in listBoxCompetitions.SelectedItems)
            {
                competitionIDs.Add(int.Parse(((DataRowView)item).Row["ID"].ToString()));
            }

            dataGridViewMale.DataSource = dataProvider.BigFinalMale(competitionIDs);
            dataGridViewFemale.DataSource = dataProvider.BigFinalFemale(competitionIDs);
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
                IDs.Add(int.Parse(((DataRowView)item).Row["ID"].ToString()));
            }
            var finalistsFemale = dataProvider.BigFinalCompetitorsFemale(IDs);
            var finalistsMale = dataProvider.BigFinalCompetitorsMale(IDs);


            foreach (var item in finalistsFemale)
            {
                
                var randomTime = start + TimeSpan.FromMilliseconds(random.Next(difference));
                dataProvider.InsertResults(item.ID, randomTime, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),10);
            }

            foreach (var item in finalistsMale)
            {

                var randomTime = start + TimeSpan.FromMilliseconds(random.Next(difference));
                dataProvider.InsertResults(item.ID, randomTime, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), 10);
            }
            var fsc = new FormSkiCompetition();
            fsc.BigFinalForm();

            //var fsc = new FormSkiCompetition();
            //WaitForm wf = new WaitForm();
            //wf.FormClosed += new FormClosedEventHandler(fsc.BigFinalForm);
            //wf.Show(this);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
