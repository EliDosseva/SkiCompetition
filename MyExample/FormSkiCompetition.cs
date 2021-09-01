using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
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
        private DataProvider dataProvider;
        private readonly string _connection = @"Data Source=EADOSSEVADW;Initial Catalog=SkiCompetition;Integrated Security=True";

        public FormSkiCompetition()
        {
            InitializeComponent();
            this.dataProvider = new DataProvider(_connection);
            listBoxCompetitions.DrawMode = DrawMode.OwnerDrawFixed;

        }
        private void FormSkiCompetition_Load_1(object sender, EventArgs e)
        {
            listBoxCompetitions.ValueMember = "CompetitionID";
            listBoxCompetitions.DisplayMember = "CompetitionName";
            listBoxCompetitions.SelectedIndex = -1;

            RefreshGrid();

            dataGridViewMaleAvg.Columns[0].Visible = false;
            dataGridViewMaleAvg.Columns[3].Visible = false;
            dataGridViewMaleAvg.Columns[4].Visible = false;
            dataGridViewMaleAvg.Columns[5].Visible = false;
            dataGridViewMaleAvg.Columns[6].Visible = false;
            dataGridViewMaleAvg.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewMaleAvg.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewMaleAvg.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewMaleAvg.Columns[1].HeaderText = "First name";
            dataGridViewMaleAvg.Columns[2].HeaderText = "Last name";

            dataGridViewFemaleAvg.Columns[0].Visible = false;
            dataGridViewFemaleAvg.Columns[3].Visible = false;
            dataGridViewFemaleAvg.Columns[4].Visible = false;
            dataGridViewFemaleAvg.Columns[5].Visible = false;
            dataGridViewFemaleAvg.Columns[6].Visible = false;
            dataGridViewFemaleAvg.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewFemaleAvg.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewFemaleAvg.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewFemaleAvg.Columns[1].HeaderText = "First name";
            dataGridViewFemaleAvg.Columns[2].HeaderText = "Last name";

            dataGridViewTeamRank.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTeamRank.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTeamRank.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTeamRank.Columns[1].Visible = false;
            dataGridViewTeamRank.Columns[2].HeaderText = "Team";
            dataGridViewTeamRank.Columns[0].Width = 40;

            dataGridViewCompetitors.Columns[1].Visible = false;
            dataGridViewCompetitors.Columns[2].HeaderText = "First name";
            dataGridViewCompetitors.Columns[3].HeaderText = "Last name";
            dataGridViewCompetitors.Columns[5].HeaderText = "Team";

            dataGridViewCompetitors.Columns["ImageColumn"].DisplayIndex = dataGridViewCompetitors.ColumnCount - 1;
            dataGridViewFemaleAvg.Columns["Position"].HeaderText = " ";
            dataGridViewFemaleAvg.Columns["Position"].DisplayIndex = 0;
            dataGridViewFemaleAvg.Columns["Position"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewFemaleAvg.Columns["Position"].Width = 40;

            dataGridViewMaleAvg.Columns["Position"].HeaderText = " ";
            dataGridViewMaleAvg.Columns["Position"].DisplayIndex = 0;
            dataGridViewMaleAvg.Columns["Position"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewMaleAvg.Columns["Position"].Width = 40;

            dataGridViewMaleAvg.Columns["Position"].DisplayIndex = 0;
        }


        public void RefreshGrid()
        {
            dataGridViewCompetitors.DataSource = dataProvider.Competitors();
            dataGridViewTeamRank.DataSource = dataProvider.AverageTimeByTeam();
            dataGridViewMaleAvg.DataSource = dataProvider.AverageTime("male");
            dataGridViewFemaleAvg.DataSource = dataProvider.AverageTime("female");
            listBoxCompetitions.DataSource = dataProvider.GetCompetition();

            dataGridViewCompetitors.ClearSelection();
            dataGridViewFemaleAvg.ClearSelection();
            dataGridViewMaleAvg.ClearSelection();
            dataGridViewTeamRank.ClearSelection();
            listBoxCompetitions.SelectedIndex = -1;
        }

        public void BigFinalForm()
        {
            var bf = new BigFinalForm(_connection);
            bf.ShowDialog();
        }

        #region DataGridViews
        private void DataGridViewCompetitors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int selected = Convert.ToInt32(dataGridViewCompetitors.SelectedRows[0].Cells[0].Value);
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this competitor", "Delete competitor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    dataProvider.DeleteCompetitor(selected);
                    
                    RefreshGrid();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void DataGridViewCompetitors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewCompetitors.CurrentRow;
            var reg = new EditCompetitor(this, _connection);

            reg.textBoxName.Text = row.Cells[2].Value.ToString();
            reg.textBoxLastName.Text = row.Cells[3].Value.ToString();
            reg.comboBoxTeam.Text = row.Cells[5].Value.ToString();
            reg.comboBoxSex.Text = row.Cells[4].Value.ToString();

            reg.comboBoxTeam.ValueMember = "TeamID";
            reg.comboBoxTeam.DisplayMember = "TeamName";
            reg.comboBoxTeam.DataSource = dataProvider.TeamSelection();
            reg.comboBoxTeam.SelectedIndex = -1;
            reg.comboBoxTeam.Text = dataGridViewCompetitors.CurrentRow.Cells[5].Value.ToString();

            reg.ShowDialog();
        }

        private void DataGridViewCompetitors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                try
                {
                    int id = Convert.ToInt32(dataGridViewCompetitors.SelectedRows[0].Cells[1].Value);
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this competitor", "Delete competitor",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataProvider.DeleteCompetitor(id);
                        RefreshGrid();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DataGridViewMaleAvg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewDoubleClick(sender, e, dataGridViewMaleAvg);
            dataGridViewMaleAvg.ClearSelection();
            dataGridViewFemaleAvg.ClearSelection();
        }

        private void DataGridViewFemaleAvg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewDoubleClick(sender, e, dataGridViewFemaleAvg);
            dataGridViewMaleAvg.ClearSelection();
            dataGridViewFemaleAvg.ClearSelection();
        }
        private void DataGridViewTeamRank_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var tm = new TeamMembers(this, _connection);

            tm.ShowDialog();
        }
        #endregion
        
        #region ListBoxCompetition
        private void ListBoxCompetitions_DoubleClick(object sender, EventArgs e)
        {
            if(listBoxCompetitions.SelectedIndex >-1 && ((Competition)listBoxCompetitions.SelectedItem).Finished == false)
            {
                var fr = new FormRank(this, _connection);

                fr.textBoxCompetitionName.Text = ((Competition)listBoxCompetitions.SelectedItem).CompetitionName;
                fr.textBoxLocation.Text = ((Competition)listBoxCompetitions.SelectedItem).Location;
                fr.textBoxDateStart.Text = ((Competition)listBoxCompetitions.SelectedItem).DateStart.ToShortDateString();
                fr.textBoxDateEnd.Text = ((Competition)listBoxCompetitions.SelectedItem).DateEnd.ToShortDateString();

                fr.Results();
                fr.Show();
                listBoxCompetitions.SelectedIndex = -1;
            }
            
        }

        public void ListBoxCompetitions_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            var lbx = sender as ListBox;
            string itemText = lbx.GetItemText(lbx.Items[e.Index]);
            Competition comp = (Competition)lbx.Items[e.Index];
            Brush brush;

            if (comp.Finished)
            {
                brush = SystemBrushes.Highlight;
            }
            else
                brush = new SolidBrush(e.ForeColor);

            e.DrawBackground();
            e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void ButtonCreateCompetition_Click(object sender, EventArgs e)
        {
            var cr = new CompetitionRegister(this, _connection);
            cr.ShowDialog();
        }

        
        private void ListBoxCompetitions_MouseDown(object sender, MouseEventArgs e)
        {
            
            switch (e.Button)
            {
                
                case MouseButtons.Right:
                    {
                        ContextMenuStrip.Show(Cursor.Position);
                    }
                    break;
            }
            
        }

        private void ListBoxCompetitions_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _ = new MouseEventArgs(MouseButtons.Left, e.Clicks, e.X, e.Y, e.Delta);
                int selectedIndx = listBoxCompetitions.IndexFromPoint(new Point(e.X, e.Y));
                if (selectedIndx != ListBox.NoMatches)
                {
                    listBoxCompetitions.SelectedIndex = selectedIndx;
                }
                if (((Competition)listBoxCompetitions.SelectedItem).Finished == false)
                {
                    ContextMenuStrip.Items[0].Enabled = true;
                    ContextMenuStrip.Items[1].Enabled = false;
                }
                else
                {
                    ContextMenuStrip.Items[0].Enabled = false;
                    ContextMenuStrip.Items[1].Enabled = true;
                } 
            }
        }
        #endregion

        #region ToolStripMenuItems
        private void ToolStripMenuCompetitor_DropDownOpening(object sender, EventArgs e)
        {
            if (dataGridViewCompetitors.SelectedRows.Count == 1)
            {
                ToolStripMenuCompetitionEdit.Enabled = true;
            }
            else
                ToolStripMenuCompetitionEdit.Enabled = false;
        }

        private void ToolStripMenuCompetitorRegister_Click(object sender, EventArgs e)
        {
            var reg = new Register(this, _connection);
            reg.ShowDialog();
        }
        
        private void ToolStripMenuCompetitorEdit_Click(object sender, EventArgs e)
        {
            var row = dataGridViewCompetitors.CurrentRow;
            var reg = new EditCompetitor(this, _connection);

            reg.textBoxName.Text = row.Cells[2].Value.ToString();
            reg.textBoxLastName.Text = row.Cells[3].Value.ToString();
            reg.comboBoxTeam.Text = row.Cells[5].Value.ToString();
            reg.comboBoxSex.Text = row.Cells[4].Value.ToString();

            reg.comboBoxTeam.ValueMember = "TeamID";
            reg.comboBoxTeam.DisplayMember = "TeamName";
            reg.comboBoxTeam.DataSource = dataProvider.TeamSelection();
            reg.comboBoxTeam.SelectedIndex = -1;
            reg.comboBoxTeam.Text = dataGridViewCompetitors.CurrentRow.Cells[5].Value.ToString();

            reg.ShowDialog();
        }

        private void ToolStripMenuCompetition_DropDownOpening(object sender, EventArgs e)
        {
            if (listBoxCompetitions.SelectedIndex != -1 && ((Competition)listBoxCompetitions.SelectedItem).Finished == false)
            {
                ToolStripMenuCompetitionEdit.Enabled = true;
            }
            else
                ToolStripMenuCompetitionEdit.Enabled = false;

            if (listBoxCompetitions.SelectedIndex != -1 && ((Competition)listBoxCompetitions.SelectedItem).Finished == true)
            {
                ToolStripMenuCompetitionResults.Enabled = true;
            }
            else
                ToolStripMenuCompetitionResults.Enabled = false;
        }

        private void ToolStripMenuCompetitionEdit_Click(object sender, EventArgs e)
        {
            if (((Competition)listBoxCompetitions.SelectedItem).Finished == false)
            {
                var reg = new EditCompetition(this, _connection);

                reg.textBoxEditCompetitionName.Text = ((Competition)listBoxCompetitions.SelectedItem).CompetitionName;
                reg.comboBoxEditLocation.Text = ((Competition)listBoxCompetitions.SelectedItem).Location;
                reg.monthCalendarEdit.SelectionStart = ((Competition)listBoxCompetitions.SelectedItem).DateStart;
                reg.monthCalendarEdit.SelectionEnd = ((Competition)listBoxCompetitions.SelectedItem).DateEnd;
                //reg.trackBarEditNumberOfCompetitors.Value = ((Competition)listBoxCompetitions.SelectedItem).Competitors;

                reg.ShowDialog();
            }

        }

        private void ToolStripMenuCompetitionResults_Click(object sender, EventArgs e)
        {
            if (listBoxCompetitions.SelectedIndex > -1 && ((Competition)listBoxCompetitions.SelectedItem).Finished == true)
            {
                var fr = new FormRank(this, _connection);

                fr.textBoxCompetitionName.Text = ((Competition)listBoxCompetitions.SelectedItem).CompetitionName;
                fr.textBoxLocation.Text = ((Competition)listBoxCompetitions.SelectedItem).Location;
                fr.textBoxDateStart.Text = ((Competition)listBoxCompetitions.SelectedItem).DateStart.ToShortDateString();
                fr.textBoxDateEnd.Text = ((Competition)listBoxCompetitions.SelectedItem).DateEnd.ToShortDateString();

                fr.Results();
                fr.Show();
                listBoxCompetitions.SelectedIndex = -1;
            }
        }
        #endregion
        #region ContextMenu
        private void ContextMenuStripResults_Click(object sender, EventArgs e)
        {
            if (listBoxCompetitions.SelectedIndex > -1 && ((Competition)listBoxCompetitions.SelectedItem).Finished == true)
            {
                var fr = new FormRank(this, _connection);

                fr.textBoxCompetitionName.Text = ((Competition)listBoxCompetitions.SelectedItem).CompetitionName;
                fr.textBoxLocation.Text = ((Competition)listBoxCompetitions.SelectedItem).Location;
                fr.textBoxDateStart.Text = ((Competition)listBoxCompetitions.SelectedItem).DateStart.ToShortDateString();
                fr.textBoxDateEnd.Text = ((Competition)listBoxCompetitions.SelectedItem).DateEnd.ToShortDateString();

                fr.Results();
                fr.Show();
                listBoxCompetitions.SelectedIndex = -1;
            }
        }

        private void ContextMenuStripEdit_Click(object sender, EventArgs e)
        {
            if (((Competition)listBoxCompetitions.SelectedItem).Finished == false)
            {
                var reg = new EditCompetition(this, _connection);

                reg.textBoxEditCompetitionName.Text = ((Competition)listBoxCompetitions.SelectedItem).CompetitionName;
                reg.comboBoxEditLocation.Text = ((Competition)listBoxCompetitions.SelectedItem).Location;
                reg.monthCalendarEdit.SelectionStart = ((Competition)listBoxCompetitions.SelectedItem).DateStart;
                reg.monthCalendarEdit.SelectionEnd = ((Competition)listBoxCompetitions.SelectedItem).DateEnd;
                //reg.trackBarEditNumberOfCompetitors.Value = ((Competition)listBoxCompetitions.SelectedItem).Competitors;

                reg.ShowDialog();
            }
        }
        #endregion


        public void DataGridViewDoubleClick(object sender, DataGridViewCellEventArgs e, DataGridView data)
        {
            var edit = new EditCompetitor(this, _connection);

            edit.textBoxName.Text = ((Competitor)data.SelectedRows[0].DataBoundItem).FirstName.ToString();
            edit.textBoxName.ReadOnly = true;
            edit.textBoxLastName.Text = ((Competitor)data.SelectedRows[0].DataBoundItem).LastName.ToString();
            edit.textBoxLastName.ReadOnly = true;
            edit.comboBoxTeam.SelectedIndex = -1;
            edit.comboBoxTeam.Text = ((Competitor)data.SelectedRows[0].DataBoundItem).Team.ToString();
            edit.comboBoxTeam.Enabled = false;
            edit.comboBoxSex.Text = ((Competitor)data.SelectedRows[0].DataBoundItem).Sex.ToString();
            edit.comboBoxSex.Enabled = false;
            edit.buttonApply.Visible = false;
            edit.Text = "Information";

            edit.ShowDialog();
        }

        private void BigFinal_Click(object sender, EventArgs e)
        {
            var csf = new CompetitionSelectForm(_connection);
            csf.Show();
        }
    }

}
