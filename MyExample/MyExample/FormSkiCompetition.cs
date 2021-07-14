using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        
        private List<Boy> boys;
        private List<Girl> girls;
        private Dictionary<Team,List<Skier>> skiersByTeam;
        public FormSkiCompetition()
        {
            InitializeComponent();

            
            skiersByTeam = new Dictionary<Team, List<Skier>>();
            boys = new List<Boy>();
            girls = new List<Girl>();
            
        }
        public List<Skier> GetSkiersByTeam(Team key)
        {
            List<Skier> result = null;

            if (skiersByTeam.ContainsKey(key))
            {
                result = skiersByTeam[key];
            }
            else
            {
                result = new List<Skier>();
                skiersByTeam.Add(key, result);
            }

            return result;
        }

        public List<Boy> GetBoys()
        {
            return boys;
        }

        public List<Girl> GetGirls()
        {
            return girls;
        }
        private void buttonResults_Click(object sender, EventArgs e)
        {

            listBoxResultsBoys.Items.Clear();
            listBoxResultsGirls.Items.Clear();


            Random random = new Random();
            var start = TimeSpan.FromSeconds(20);
            var end = TimeSpan.FromMinutes(2);
            var difference = (int)(end.TotalMilliseconds - start.TotalMilliseconds);

            var allSkiers = new List<Skier>(girls.Count + boys.Count);
            allSkiers.AddRange(girls);
            allSkiers.AddRange(boys);

            foreach (var item in allSkiers)
            {
                var randomTime = start + TimeSpan.FromMilliseconds(random.Next(difference));

                item.Time = randomTime;
                if (item.GetType() == typeof(Boy))
                {
                    listBoxResultsBoys.Items.Add(item.Name);
                    listBoxResultsBoys.Items.Add(item.LastName);
                    listBoxResultsBoys.Items.Add(randomTime);
                }
                else
                {
                    listBoxResultsGirls.Items.Add(item.Name);
                    listBoxResultsBoys.Items.Add(item.LastName);
                    listBoxResultsGirls.Items.Add(randomTime);
                }

            }
        }


        private void buttonResultSort_Click(object sender, EventArgs e)
        {
            listBoxRankBoys.Items.Clear();
            listBoxRankGirls.Items.Clear();


            var resBoys = boys.OrderBy(x => x.Time).ToArray();
            for (int i = 0; i < resBoys.Length; i++)
            {                
                listBoxRankBoys.Items.Add(i+1 + ". "+ resBoys[i].Name);
            }

            var resGirls = girls.OrderBy(x => x.Time).ToArray();
            for (int i = 0; i < resGirls.Length; i++)
            {

                listBoxRankGirls.Items.Add(i + 1 + ". " + resGirls[i].Name);
            }

        }


        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var reg = new Register(this);
            
            if (reg.ShowDialog() == DialogResult.OK)
            {
                listBoxBoys.Items.Clear();
                listBoxGirls.Items.Clear();

                listBoxBoys.Items.AddRange(boys.ToArray());
                listBoxGirls.Items.AddRange(girls.ToArray());

            }

        }

        private void buttonTeamRank_Click(object sender, EventArgs e)
        {
            listBoxTeamRank.Items.Clear();
            foreach (KeyValuePair<Team, List<Skier>> entry in skiersByTeam)
            {
                foreach (var skier in entry.Value)
                {
                    entry.Key.AverageTime += skier.Time;
                }
                entry.Key.AverageTime = new TimeSpan((long)(entry.Key.AverageTime.TotalMilliseconds / entry.Value.Count));
            }
            
            foreach (var item in skiersByTeam.OrderBy(pair => pair.Key.AverageTime))
            {
                listBoxTeamRank.Items.Add(item.Key.Name);
            }               
            
        }
    }
}
