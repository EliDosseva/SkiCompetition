using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyExample
{
    [Serializable]
    public partial class FormSkiCompetition : Form
    {
        public static string competitionName;
        public List<Competition> competitions;
        //public int competitionID;

        private DataProvider dataProvider;
        private readonly string _connection = @"Data Source=EADOSSEVADW;Initial Catalog=SkiCompetition;Integrated Security=True";

        public FormSkiCompetition()
        {
            InitializeComponent();
            this.dataProvider = new DataProvider(_connection);
            
        }

        public void FormSkiCompetition_Load(object sender, EventArgs e)
        {
            
            listBoxCompetitions.ValueMember = "ID";
            listBoxCompetitions.DisplayMember = "CompetitionName";
            
            RefreshGrid();
            DataGridViewColumn column = dataGridViewTeamRank.Columns[0];
            column.Width = 65;
            listBoxCompetitions.SelectedIndex = -1;
        }


        public void RefreshGrid()
        {
            dataGridViewCompetitors.DataSource = dataProvider.Competitors();
            dataGridViewTeamRank.DataSource = dataProvider.AverageTimeByTeam();
            dataGridViewMaleAvg.DataSource = dataProvider.AverageTime("male");
            dataGridViewFemaleAvg.DataSource = dataProvider.AverageTime("female");
            listBoxCompetitions.DataSource = dataProvider.GetCompetition();
        }

        #region NewForms
        public void NewFormRank(object sender, EventArgs e)
        {
            var fr = new FormRank(this,_connection);
            fr.Show();
        }

        public void BigFinalForm()
        {
            var bf = new BigFinalForm(_connection);
            bf.ShowDialog();
        }
        #endregion

        #region Commands
        private void DataGridViewCompetitors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int selected = Convert.ToInt32(dataGridViewCompetitors.SelectedRows[0].Cells[0].Value);
                dataProvider.DeleteCompetitor(selected);
                RefreshGrid();
            }
        }

        private void BigFinal_Click(object sender, EventArgs e)
        {
              var csf = new CompetitionSelectForm(_connection);
              csf.Show();
        }

        private void ListBoxCompetitions_DoubleClick(object sender, EventArgs e)
        {

            var fr = new FormRank(this, _connection);

            fr.textBoxCompetitionName.Text = ((Competition)listBoxCompetitions.SelectedItem).CompetitionName;
            fr.textBoxLocation.Text = ((Competition)listBoxCompetitions.SelectedItem).Location;
            fr.textBoxDateStart.Text = ((Competition)listBoxCompetitions.SelectedItem).DateStart.ToString();
            fr.textBoxDateEnd.Text = ((Competition)listBoxCompetitions.SelectedItem).DateEnd.ToString();

            fr.Results();
            fr.Show();
        }

        private void ListBoxCompetitions_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Define the default color of the brush as black.
            Brush myBrush = Brushes.Black;



            // Determine the color of the brush to draw each item based
            // on the index of the item to draw.
            //if (e.State.HasFlag((enum)listBoxCompetitions.SelectedItem))
            //{
            //}
            switch (e.Index)
            {
                case 0:
                    myBrush = Brushes.Red;
                    break;
                case 1:
                    myBrush = Brushes.Orange;
                    break;
                case 2:
                    myBrush = Brushes.Purple;
                    break;
            }

            // Draw the current item text based on the current Font
            // and the custom brush settings.
            e.Graphics.DrawString(((Competition) listBoxCompetitions.Items[e.Index]).ToString(),
            e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();

        }

        private void ButtonRegisterNewCompetitor(object sender, EventArgs e)
        {
            var reg = new Register(this, _connection);

            reg.ShowDialog();
        }

        private void ButtonDeleteCompetitor(object sender, EventArgs e)
        {
            int selected = Convert.ToInt32(dataGridViewCompetitors.SelectedRows[0].Cells[0].Value);
            dataProvider.DeleteCompetitor(selected);
            RefreshGrid();
        }


        private void ButtonCreateCompetition_Click(object sender, EventArgs e)
        {

            var cr = new CompetitionRegister(this,_connection);
            cr.ShowDialog();

        }

        private void DataGridViewCompetitors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewCompetitors.CurrentRow;
            var reg = new EditCompetitor(this,_connection);
            
            reg.textBoxName.Text = row.Cells[1].Value.ToString();
            reg.textBoxLastName.Text = row.Cells[2].Value.ToString();
            reg.comboBoxTeam.Text = row.Cells[4].Value.ToString();
            reg.comboBoxSex.Text = row.Cells[3].Value.ToString();

            reg.ShowDialog();
        }

        private void DataGridViewTeamRank_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var tm = new TeamMembers(this, _connection);

            tm.ShowDialog();
        }
        #endregion

    }

}
