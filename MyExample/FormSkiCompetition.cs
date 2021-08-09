using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyExample
{
    public partial class FormSkiCompetition : Form
    {
        public bool flag;
        private DataProvider dataProvider;
        private readonly string _connection = @"Data Source=EADOSSEVADW;Initial Catalog=SkiCompetition;Integrated Security=True";

        public FormSkiCompetition()
        {
            InitializeComponent();

            this.dataProvider = new DataProvider(_connection);

        }

        private void FormSkiCompetition_Load(object sender, EventArgs e)
        {
            listBoxCompetitions.DataSource = dataProvider.CompetitionTable();
            listBoxCompetitions.ValueMember = "ID";
            listBoxCompetitions.DisplayMember = "CompetitionName";
            listBoxCompetitions.SelectedIndex = -1;

            RefreshGrid();
        }

        public void GetCompetitorTime()
        {
            Random random = new Random();
            var start = TimeSpan.FromSeconds(20);
            var end = TimeSpan.FromMinutes(2);
            var difference = (int)(end.TotalMilliseconds - start.TotalMilliseconds);

            List<Skier> all = dataProvider.GetCompetitors();


            foreach (var item in all)
            {
                var randomTime = start + TimeSpan.FromMilliseconds(random.Next(difference));
                
                var id = int.Parse(listBoxCompetitions.GetItemText(listBoxCompetitions.SelectedValue));
                dataProvider.InsertResults(item.ID, randomTime, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),id);
            }
        }
        

        public void RefreshGrid()
        {
            dataGridViewCompetitors.DataSource = dataProvider.Create();
            dataGridViewTeamRank.DataSource = dataProvider.AverageTimeByTeam();
            dataGridViewMaleAvg.DataSource = dataProvider.AverageTimeMale();
            dataGridViewFemaleAvg.DataSource = dataProvider.AverageTimeFemale();
        }
        #region Commands
        private void DataGridViewCompetitors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int selected = Convert.ToInt32(dataGridViewCompetitors.SelectedRows[0].Cells[0].Value);
                dataProvider.Delete(selected);
                RefreshGrid();
            }
        }

        private void BigFinal_Click(object sender, EventArgs e)
        {
              var csf = new CompetitionSelectForm(_connection);
              csf.Show();
        }

        public void NewFormRank(object sender, EventArgs e)
        {
            var fr = new FormRank(_connection);
            fr.Show();
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxCompetitions.SelectedItem != null)
            {
                GetCompetitorTime();
                WaitForm wf = new WaitForm();
                wf.FormClosed += new FormClosedEventHandler(NewFormRank);
                wf.Show(this);

                dataGridViewMaleAvg.DataSource = dataProvider.AverageTimeMale();
                dataGridViewFemaleAvg.DataSource = dataProvider.AverageTimeFemale();

                dataGridViewTeamRank.DataSource = dataProvider.AverageTimeByTeam();
            }
        }

        private void ButtonRegisterNewCompetitor(object sender, EventArgs e)
        {
            var reg = new Register(this, _connection);

            reg.ShowDialog();
        }

        private void ButtonDeleteCompetitor(object sender, EventArgs e)
        {
            int selected = Convert.ToInt32(dataGridViewCompetitors.SelectedRows[0].Cells[0].Value);
            dataProvider.Delete(selected);
            RefreshGrid();
        }

        private void ButtonResults_Click(object sender, EventArgs e)
        {
            var id = int.Parse(listBoxCompetitions.GetItemText(listBoxCompetitions.SelectedValue));
            Random random = new Random();
            var start = TimeSpan.FromSeconds(20);
            var end = TimeSpan.FromMinutes(2);
            var difference = (int)(end.TotalMilliseconds - start.TotalMilliseconds);

            List<Skier> all = dataProvider.GetCompetitors();


            foreach (var item in all)
            {
                var randomTime = start + TimeSpan.FromMilliseconds(random.Next(difference));

                dataProvider.InsertResults(item.ID, randomTime, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), id);
            }

        }
        #endregion
    }

}
