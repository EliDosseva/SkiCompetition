using System;
using System.Windows.Forms;

namespace MyExample
{
    public partial class EditCompetitor : Form
    {
        private readonly FormSkiCompetition skierForm;
        private readonly DataProvider dataProvider;
        public EditCompetitor(FormSkiCompetition skierForm, string connection)
        {
            InitializeComponent();

            this.skierForm = skierForm;

            this.dataProvider = new DataProvider(connection);
        }

        private void ButtonEditCompetitor_Click(object sender, EventArgs e)
        {
            skierForm.RefreshGrid();
            this.Close();
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            var sex = comboBoxSex.GetItemText(comboBoxSex.SelectedItem);

            int team = int.Parse(comboBoxTeam.SelectedValue.ToString());
            int id = Convert.ToInt32(skierForm.dataGridViewCompetitors.SelectedRows[0].Cells[1].Value);
            dataProvider.EditCompetitor(id, textBoxName.Text, textBoxLastName.Text, sex, team);
        }
    }
}
