using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MyExample
{
    [Serializable]
    internal partial class FrmResults : Form
    {
        private FrmSkiCompetition skierForm;
        private DataProvider dataProvider;

        public FrmResults(FrmSkiCompetition skierForm, string connection)
        {
            InitializeComponent();
            this.skierForm = skierForm;
            this.dataProvider = new DataProvider(connection);
        }

        private void FormRank_Load(object sender, EventArgs e)
        {
            dataGridViewFemale.Columns[0].Visible = false;
            dataGridViewFemale.Columns[3].Visible = false;
            dataGridViewFemale.Columns[4].Visible = false;
            dataGridViewFemale.Columns[5].Visible = false;
            dataGridViewFemale.Columns[7].Visible = false;
            dataGridViewFemale.Columns[8].Visible = false;
            
            dataGridViewFemale.Columns[1].HeaderText = "First name";
            dataGridViewFemale.Columns[2].HeaderText = "Last name";

            dataGridViewMale.Columns[0].Visible = false;
            dataGridViewMale.Columns[3].Visible = false;
            dataGridViewMale.Columns[4].Visible = false;
            dataGridViewMale.Columns[5].Visible = false;
            dataGridViewMale.Columns[7].Visible = false;
            dataGridViewMale.Columns[8].Visible = false;

            dataGridViewMale.Columns[1].HeaderText = "First name";
            dataGridViewMale.Columns[2].HeaderText = "Last name";

            dataGridViewFemale.ClearSelection();
            dataGridViewMale.ClearSelection();
        }

        private void ButtonOKCloseForm_Click(object sender, EventArgs e)
        {
            skierForm.RefreshGrid();
            this.Close();
        }

        internal void ResultsData(int competitionId)
        {
            dataGridViewMale.DataSource = dataProvider.GetResults(competitionId, "male");
            dataGridViewFemale.DataSource = dataProvider.GetResults(competitionId, "female");
        }

        internal void ListBoxRank(int competitionId)
        {
            listBoxRankFemale.DataSource = dataProvider.GetSkiersByTime(competitionId, "female");
            listBoxRankMale.DataSource = dataProvider.GetSkiersByTime(competitionId, "male");
        }

        private void DataGridViewMale_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            skierForm.ShowCompetitorInfo(dataGridViewMale);
            //dataGridViewFemale.ClearSelection();
            //dataGridViewMale.ClearSelection();
        }

        private void DataGridViewFemale_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            skierForm.ShowCompetitorInfo(dataGridViewFemale);
            //dataGridViewFemale.ClearSelection();
            //dataGridViewMale.ClearSelection();
        }

        internal void ListBoxCompetitionsSetData(ListBox listBox)
        {
            textBoxCompetitionName.Text = ((Competition)listBox.SelectedItem).CompetitionName;
            textBoxLocation.Text = ((Competition)listBox.SelectedItem).Location;
            textBoxDateStart.Text = ((Competition)listBox.SelectedItem).DateStart.ToShortDateString();
            textBoxDateEnd.Text = ((Competition)listBox.SelectedItem).DateEnd.ToShortDateString();
        }

        internal void ButtonOkNameChange()
        {
            buttonOK.Text = "Finish competition";
        }
    }
}
