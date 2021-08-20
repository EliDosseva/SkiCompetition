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
    public partial class EditCompetitor : Form
    {
        private FormSkiCompetition skierForm = null;
        private Skier skier = null;
        private DataProvider dataProvider;
        public EditCompetitor(FormSkiCompetition skierForm, string connection)
        {
            InitializeComponent();

            this.skierForm = skierForm;

            this.dataProvider = new DataProvider(connection);
        }

        private void EditCompetitor_Load(object sender, EventArgs e)
        {
            comboBoxTeam.ValueMember = "ID";
            comboBoxTeam.DisplayMember = "TeamName";
            //comboBoxTeam.DataSource = dataProvider.TeamSelection();
        }

        private void ButtonEditCompetitor_Click(object sender, EventArgs e)
        {
            skier = new Skier(textBoxName.Text, textBoxLastName.Text);
            skier.Team = comboBoxTeam.Text;

            var sex = comboBoxSex.GetItemText(comboBoxSex.SelectedItem);
            
            int team = int.Parse(comboBoxTeam.SelectedValue.ToString());
            int id = Convert.ToInt32(skierForm.dataGridViewCompetitors.SelectedRows[0].Cells[0].Value);
            dataProvider.EditCompetitor(id, textBoxName.Text, textBoxLastName.Text, sex, team);
            skierForm.RefreshGrid();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ComboBoxTeam_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxTeam.DataSource = dataProvider.ComboBoxTeam();
        }
    }
}
