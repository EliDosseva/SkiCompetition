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
    public partial class FormRank : Form
    {
        private DataProvider dataProvider;

        public FormRank(string connection)
        {
            InitializeComponent();
            this.dataProvider = new DataProvider(connection);
        }

        private void FormRank_Load(object sender, EventArgs e)
        {
           
            dataGridViewMale.DataSource = dataProvider.TimesMale();
            dataGridViewFemale.DataSource = dataProvider.TimesFemale();
            
        }

        private void buttonResultSort_Click(object sender, EventArgs e)
        {
            List<Skier> females = dataProvider.GetFemales();
            List<Skier> males = dataProvider.GetMales();

            listBoxRankFemale.Items.Add(dataProvider.SumResults());
            listBoxRankMale.Items.Add(dataProvider.SumResults());


            var resFemale = females.OrderBy(x => x.Time).ToArray();
            for (int i = 0; i < resFemale.Length; i++)
            {
                listBoxRankFemale.Items.Add(i + 1 + ". " + resFemale[i].Name + " " + resFemale[i].LastName);
            }

            var resMale = males.OrderBy(x => x.Time).ToArray();
            for (int i = 0; i < resMale.Length; i++)
            {
                listBoxRankMale.Items.Add(i + 1 + ". " + resMale[i].Name + " " + resMale[i].LastName);
            }
        }
    }
}
