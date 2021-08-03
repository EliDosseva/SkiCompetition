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
        
        private List<Skier> skiers;
        private DataProvider dataProvider;
        private readonly string _connection = @"Data Source=EADOSSEVADW;Initial Catalog=SkiCompetition;Integrated Security=True";

        public FormSkiCompetition()
        {
            InitializeComponent();

            skiers = new List<Skier>();

            this.dataProvider = new DataProvider(_connection);

        }

        public List<Skier> GetSkiers()
        {
            return skiers;
        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            var id = int.Parse(listBox1.GetItemText(listBox1.SelectedValue));
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

        public void ListBox()
        {
            Random random = new Random();
            var start = TimeSpan.FromSeconds(20);
            var end = TimeSpan.FromMinutes(2);
            var difference = (int)(end.TotalMilliseconds - start.TotalMilliseconds);

            List<Skier> all = dataProvider.GetCompetitors();


            foreach (var item in all)
            {
                var randomTime = start + TimeSpan.FromMilliseconds(random.Next(difference));
                
                var id = int.Parse(listBox1.GetItemText(listBox1.SelectedValue));
                dataProvider.InsertResults(item.ID, randomTime, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),id);
            }
        }
        
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var reg = new Register(this, _connection);

            reg.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selected = Convert.ToInt32(dataGridViewCompetitors.SelectedRows[0].Cells[0].Value);
            dataProvider.Delete(selected);
            RefreshGrid();
        }

        private void FormSkiCompetition_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = dataProvider.CompetitionTable();
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "CompetitionName";

            RefreshGrid();

            dataGridViewTeamRank.DataSource = dataProvider.AverageTimeByTeam();
        }
        public void RefreshGrid()
        {
            dataGridViewCompetitors.DataSource = dataProvider.Create();
        }

        private void dataGridViewCompetitors_KeyDown(object sender, KeyEventArgs e)
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

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                ListBox();
                WaitForm wf = new WaitForm(_connection);
                wf.Show(this);


                dataGridViewMaleAvg.DataSource = dataProvider.AverageTimeMale();
                dataGridViewFemaleAvg.DataSource = dataProvider.AverageTimeFemale();

                dataGridViewTeamRank.DataSource = dataProvider.AverageTimeByTeam();
            }
        }
    }

}
