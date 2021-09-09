using System;
using System.Windows.Forms;

namespace MyExample
{
    internal partial class FrmEditCompetitor : Form
    {
        private readonly FrmSkiCompetition skierForm;
        private readonly DataProvider dataProvider;

        internal FrmEditCompetitor(FrmSkiCompetition skierForm, string connection)
        {
            InitializeComponent();

            this.skierForm = skierForm;

            this.dataProvider = new DataProvider(connection);
        }

        private void ButtonEditCompetitor_Click(object sender, EventArgs e)
        {
            skierForm.RefreshGrid();
            Close();
        }

        internal void ButtonApply_Click(object sender, EventArgs e)
        {
            var sex = comboBoxSex.GetItemText(comboBoxSex.SelectedItem);

            int team = int.Parse(comboBoxTeam.SelectedValue.ToString());
            //int id = Convert.ToInt32(skierForm.dataGridViewCompetitors.SelectedRows[0].Cells[1].Value);
            dataProvider.EditCompetitor(skierForm.competitorId, textBoxName.Text, textBoxLastName.Text, sex, team);
        }

        internal void CompetitorInfo(DataGridView data)
        {
            textBoxName.Text = ((Competitor)data.SelectedRows[0].DataBoundItem).FirstName;
            textBoxName.ReadOnly = true;
            textBoxLastName.Text = ((Competitor)data.SelectedRows[0].DataBoundItem).LastName;
            textBoxLastName.ReadOnly = true;
            comboBoxTeam.SelectedIndex = -1;
            comboBoxTeam.Text = ((Competitor)data.SelectedRows[0].DataBoundItem).Team;
            comboBoxTeam.Enabled = false;
            comboBoxSex.Text = ((Competitor)data.SelectedRows[0].DataBoundItem).Sex;
            comboBoxSex.Enabled = false;
            buttonApply.Visible = false;
            Text = "Information";
        }

        internal void Edit(DataGridViewRow row)
        {
            textBoxName.Text = row.Cells[2].Value.ToString();
            textBoxLastName.Text = row.Cells[3].Value.ToString();
            comboBoxTeam.Text = row.Cells[5].Value.ToString();
            comboBoxSex.Text = row.Cells[4].Value.ToString();

            comboBoxTeam.ValueMember = "TeamID";
            comboBoxTeam.DisplayMember = "TeamName";
            comboBoxTeam.DataSource = dataProvider.TeamSelection();
            comboBoxTeam.SelectedIndex = -1;
            comboBoxTeam.Text = row.Cells[5].Value.ToString();
        }

    }
}
