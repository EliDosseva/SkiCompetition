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
        public FormSkiCompetition()
        {
            InitializeComponent();
            string connection = @"Data Source=EADOSSEVADW;Initial Catalog=SkiCompetition;Integrated Security=True";
            skiers = new List<Skier>();
 
            this.dataProvider = new DataProvider(connection);

        }

        public List<Skier> GetSkiers()
        {
            return skiers;
        }

        private void buttonResults_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            var start = TimeSpan.FromSeconds(20);
            var end = TimeSpan.FromMinutes(2);
            var difference = (int)(end.TotalMilliseconds - start.TotalMilliseconds);

            List<Skier> all = dataProvider.GetCompetitors();


            foreach (var item in all)
            {
                var randomTime = start + TimeSpan.FromMilliseconds(random.Next(difference));
                dataProvider.InsertResults(item.ID, randomTime, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
            }

        }

        private void buttonResultSort_Click(object sender, EventArgs e)
        {

            

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var reg = new Register(this);

            reg.ShowDialog();
        }

        private void buttonTeamRank_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selected = Convert.ToInt32(dataGridViewCompetitors.SelectedRows[0].Cells[0].Value);
            dataProvider.Delete(selected);
            RefreshGrid();
        }

        private void FormSkiCompetition_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
         public void RefreshGrid()
        {
            dataGridViewCompetitors.DataSource = dataProvider.Create();
        }

        private void dataGridViewCompetitors_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                int selected = Convert.ToInt32(dataGridViewCompetitors.SelectedRows[0].Cells[0].Value);
                dataProvider.Delete(selected);
                RefreshGrid();
            }
        }

        private void VitoshaCompetition_Click(object sender, EventArgs e)
        {
            var fr = new FormRank();

            fr.ShowDialog();


            //var sorted = females.GroupBy(r => r.ID).Select(x => x.Select(v=>v.Time).ToList()).ToList();

            

            dataGridViewTeamRank.DataSource = dataProvider.AverageTimeByTeam();
            dataGridViewMaleAvg.DataSource = dataProvider.AverageTimeMale();
            dataGridViewFemaleAvg.DataSource = dataProvider.AverageTimeFemale();
        }
    }

}
