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
    public partial class Register : Form
    {
        private FormSkiCompetition skierForm = null;
        private Skier skier = null;
        private DataProvider dataProvider;

        public Register(FormSkiCompetition skierForm, string connection)
        {
            InitializeComponent();
            this.skierForm = skierForm;
            
            this.dataProvider = new DataProvider(connection);
        }

        private void Register_Load(object sender, EventArgs e)
        {
            var combo = dataProvider.ComboBoxTeam();
            comboBoxTeam.DataSource = combo;
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
                skier = new Skier(textBoxName.Text, textBoxLastName.Text);
                skier.Team = comboBoxTeam.Text;


            var sex = comboBoxSex.GetItemText(comboBoxSex.SelectedItem);

            int team = ((KeyValuePair<int, string>)comboBoxTeam.SelectedItem).Key;

            var isSuccess = dataProvider.CreateCompetitor(textBoxName.Text, textBoxLastName.Text, sex, team);
            skierForm.RefreshGrid();
            DialogResult = DialogResult.OK;
        }

    }
}

