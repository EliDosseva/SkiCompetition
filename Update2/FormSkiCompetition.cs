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

            //listBoxResultsBoys.Items.Clear();
            //listBoxResultsGirls.Items.Clear();


            Random random = new Random();
            var start = TimeSpan.FromSeconds(20);
            var end = TimeSpan.FromMinutes(2);
            var difference = (int)(end.TotalMilliseconds - start.TotalMilliseconds);

            var allSkiers = new List<Skier>(skiers.Count);
            allSkiers.AddRange(skiers);
            //allSkiers.AddRange(boys);

            foreach (var item in allSkiers)
            {
                var randomTime = start + TimeSpan.FromMilliseconds(random.Next(difference));

                item.Time = randomTime;
                //if (item.GetType() == typeof(Boy))
                //{
                    listBoxResults.Items.Add(item.Name);
                    listBoxResults.Items.Add(randomTime);
               // }

            }
        }


        private void buttonResultSort_Click(object sender, EventArgs e)
        {
            listBoxRank.Items.Clear();
            //listBoxRankGirls.Items.Clear();


            var resBoys = skiers.OrderBy(x => x.Time).ToArray();
            for (int i = 0; i < resBoys.Length; i++)
            {                
                listBoxRank.Items.Add(i+1 + ". "+ resBoys[i].Name);
            }

            //var resGirls = girls.OrderBy(x => x.Time).ToArray();
            //for (int i = 0; i < resGirls.Length; i++)
            //{

            //    listBoxRankGirls.Items.Add(i + 1 + ". " + resGirls[i].Name);
            //}

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

        private void buttonCompetitors_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataProvider.Create();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var dc = new DeleteCompetior();

            dc.ShowDialog();
        }
    }
}
