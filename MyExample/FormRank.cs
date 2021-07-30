﻿using System;
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

        public FormRank()
        {
            InitializeComponent();
            string connection = @"Data Source=EADOSSEVADW;Initial Catalog=SkiCompetition;Integrated Security=True";
            this.dataProvider = new DataProvider(connection);
        }

        private void FormRank_Load(object sender, EventArgs e)
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
