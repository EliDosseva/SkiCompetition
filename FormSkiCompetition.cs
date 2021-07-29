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
        //private Dictionary<Team,List<Skier>> skiersByTeam;
        private DataProvider dataProvider;
        public FormSkiCompetition()
        {
            InitializeComponent();
            string connection = @"Data Source=EADOSSEVADW;Initial Catalog=SkiCompetition;Integrated Security=True";
            skiers = new List<Skier>();
            //skiersByTeam = new Dictionary<Team, List<Skier>>();
            
            this.dataProvider = new DataProvider(connection);

        }
        //public List<Skier> GetSkiersByTeam(Team key)
        //{
        //    List<Skier> result = null;

        //    if (skiersByTeam.ContainsKey(key))
        //    {
        //        result = skiersByTeam[key];
        //    }
        //    else
        //    {
        //        result = new List<Skier>();
        //        skiersByTeam.Add(key, result);
        //    }

        //    return result;
        //}

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

                dataGridViewMale.DataSource = dataProvider.TimesMale();
                dataGridViewFemale.DataSource = dataProvider.TimesFemale();
            }

        }

        private void buttonResultSort_Click(object sender, EventArgs e)
        {

            List<Skier> females = dataProvider.GetFemales();
            List<Skier> males = dataProvider.GetMales();


            //var sorted = females.GroupBy(r => r.ID).Select(x => x.Select(v=>v.Time).ToList()).ToList();

            listBoxRankFemale.Items.Add(dataProvider.SumResults());
            listBoxRankMale.Items.Add(dataProvider.SumResults());


            var resFemale = females.OrderBy(x => x.Time).ToArray();
            for (int i = 0; i < resFemale.Length; i++)
            {                
                listBoxRankFemale.Items.Add(i+1 + ". "+ resFemale[i].Name +" " + resFemale[i].LastName);
            }

            var resMale = males.OrderBy(x => x.Time).ToArray();
            for (int i = 0; i < resMale.Length; i++)
            {
                listBoxRankMale.Items.Add(i+1 + ". "+ resMale[i].Name + " " + resMale[i].LastName);
            }

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var reg = new Register(this);

            reg.ShowDialog();
        }

        private void buttonTeamRank_Click(object sender, EventArgs e)
        {
        //    listBoxTeamRank.Items.Clear();
        //    foreach (KeyValuePair<Team, List<Skier>> entry in skiersByTeam)
        //    {
        //        foreach (var skier in entry.Value)
        //        {
        //            entry.Key.AverageTime += skier.Time;
        //        }
        //        entry.Key.AverageTime = new TimeSpan((long)(entry.Key.AverageTime.TotalMilliseconds / entry.Value.Count));
        //    }
            
        //    foreach (var item in skiersByTeam.OrderBy(pair => pair.Key.AverageTime))
        //    {
        //        listBoxTeamRank.Items.Add(item.Key.Name);
        //    }               
            
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
    }

}
