using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyExample
{
    public partial class Register : Form
    {

        private FormSkiCompetition skierForm = null;
        private Skier skier = null;
        private DataProvider dataProvider;

        public Register(FormSkiCompetition skierForm)
        {
            InitializeComponent();
            this.skierForm = skierForm;
            var connection = @"Data Source=EADOSSEVADW;Initial Catalog=SkiCompetition;Integrated Security=True";
            this.dataProvider = new DataProvider(connection);
        }

        public Register()
        {
            var connection = @"Data Source=EADOSSEVADW;Initial Catalog=SkiCompetition;Integrated Security=True";
            this.dataProvider = new DataProvider(connection);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string sex = comboBoxSex.Text;

                skier = new Skier(textBoxName.Text, textBoxLastName.Text);
                skier.Team = comboBoxTeam.Text;

            //List<Skier> skiers = skierForm.GetSkiersByTeam((Team)comboBoxTeam.SelectedItem);
            //List<Skier> skiers = dataProvider.GetCompetitors();
            //skiers.Add(skier);


            var sexx = comboBoxSex.GetItemText(comboBoxSex.SelectedItem);

            int team = ((KeyValuePair<int, string>)comboBoxTeam.SelectedItem).Key;

            var isSuccess = dataProvider.CreateCompetitor(textBoxName.Text, textBoxLastName.Text, sexx, team);
            
            DialogResult = DialogResult.OK;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            var combo = dataProvider.ComboBoxTeam();
            comboBoxTeam.DataSource = combo;
        }

    }
}

