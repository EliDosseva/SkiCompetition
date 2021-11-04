using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Web;
using System.Runtime.Caching;
using System.IO;
using System.Web.Caching;

namespace MyExample
{
    [Serializable]
    internal partial class FrmSkiCompetition : Form
    {
        private readonly DataProvider dataProvider;
        private readonly string _connection = @"Data Source=EADOSSEVADW;Initial Catalog=SkiCompetition;Integrated Security=True";
        internal int competitionId;
        internal int competitorId;

        internal FrmSkiCompetition()
        {
            InitializeComponent();
            dataProvider = new DataProvider(_connection);
            listBoxCompetitions.DrawMode = DrawMode.OwnerDrawFixed;
        }
        
        //public void AddItemToCache(Object sender, EventArgs e)
        //{
            
        //    onRemove = new CacheItemRemovedCallback(this.RemovedCallback);

        //    if (Cache["Key1"] == null)
        //        Cache.Add("Key1", "Value 1", null, DateTime.Now.AddSeconds(60), Cache.NoSlidingExpiration, CacheItemPriority.High, onRemove);
        //}

        private void FormSkiCompetition_Load_1(object sender, EventArgs e)
        {

        //    HttpRuntime httpRT = new HttpRuntime(); // our cache object
            
        //    FileWatcherClass fd = new FileWatcherClass(@"c:\cust_changed.txt");
        //    // txt file to monitor for changes, would be created by db when data changed

        //    fd.OnFileChange += new
        //        WindowsApplication1.FileWatcherClass.FileChange(this.FileHasChanged);


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
            dataGridViewTeamRank.Columns[3].HeaderText = "Points";

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


        internal void RefreshGrid()
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

        #region DataGridViews
        private void DataGridViewCompetitors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int selected = Convert.ToInt32(dataGridViewCompetitors.SelectedRows[0].Cells[1].Value);
                DialogResult dialogResult =
                    MyMessages.DisplayConfirmation("Are you sure you want to delete this competitor?");
                if (dialogResult == DialogResult.Yes)
                {
                    dataProvider.DeleteCompetitor(selected);
                    RefreshGrid();
                }
                else if (dialogResult == DialogResult.No)
                {
                    RefreshGrid();
                }
            }
        }

        private void DataGridViewCompetitors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewCompetitors.CurrentRow;
            competitorId = Convert.ToInt32(dataGridViewCompetitors.SelectedRows[0].Cells[1].Value);
            var ec = new FrmEditCompetitor(this, _connection);
            ec.Edit(row);
            ec.ShowDialog();
        }

        private void DataGridViewCompetitors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                    int id = Convert.ToInt32(dataGridViewCompetitors.SelectedRows[0].Cells[1].Value);
                    DialogResult dialogResult = MyMessages.DisplayConfirmation("Are you sure you want to delete this competitor?");
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataProvider.DeleteCompetitor(id);
                        RefreshGrid();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                    }
            }
        }

        private void DataGridViewMaleAvg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowCompetitorInfo(dataGridViewMaleAvg);
        }

        private void DataGridViewFemaleAvg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowCompetitorInfo(dataGridViewFemaleAvg);
        }
        private void DataGridViewTeamRank_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var tm = new FrmTeamMembers(this, _connection);
            int id = Convert.ToInt32(dataGridViewTeamRank.SelectedRows[0].Cells[1].Value);
            tm.TeamMembersLoad(id);
            

            tm.ShowDialog();
        }
        #endregion
        
        #region ListBoxCompetition
        private void ListBoxCompetitions_DoubleClick(object sender, EventArgs e)
        {
            if(listBoxCompetitions.SelectedIndex >-1 && ((Competition)listBoxCompetitions.SelectedItem).Finished == false)
            {
                Results();
                listBoxCompetitions.SelectedIndex = -1;
            }
        }

        internal void Results()
        {
            var fr = new FrmResults(this, _connection);

            fr.ListBoxCompetitionsSetData(listBoxCompetitions);

            int id = ((Competition)listBoxCompetitions.SelectedItem).CompetitionId;
            int competitorsCount = ((Competition)listBoxCompetitions.SelectedItem).Competitors;

            
            if (((Competition)listBoxCompetitions.SelectedItem).Finished)
            {
                fr.ResultsData(id);
            }
            else
            {
                Random random = new Random();
                var start = TimeSpan.FromSeconds(20);
                var end = TimeSpan.FromMinutes(2);
                var difference = (int)(end.TotalMilliseconds - start.TotalMilliseconds);
                List<Competitor> all = dataProvider.GetRandomCompetitors(competitorsCount);

                foreach (var item in all)
                {
                    var randomTime = start + TimeSpan.FromMilliseconds(random.Next(difference));
                    dataProvider.InsertResults(item.CompetitorId, randomTime, DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), id, item.Position);
                }
                dataProvider.IsFinished(id);

                dataGridViewMaleAvg.DataSource = dataProvider.AverageTime("male");
                dataGridViewFemaleAvg.DataSource = dataProvider.AverageTime("female");
                dataGridViewTeamRank.DataSource = dataProvider.AverageTimeByTeam();

                fr.ResultsData(id);

                List<Competitor> males = dataProvider.GetSkiersByTime(id, "male");
                List<Competitor> females = dataProvider.GetSkiersByTime(id, "female");

                var competitors = males.Concat(females);
                foreach (var item in competitors)
                {
                    switch (item.Position)
                    {
                        case 1:
                            item.Points += 10;
                            break;
                        case 2:
                            item.Points += 9;
                            break;
                        case 3:
                            item.Points += 8;
                            break;
                        case 4:
                            item.Points += 7;
                            break;
                        case 5:
                            item.Points += 6;
                            break;
                        case 6:
                            item.Points += 5;
                            break;
                        case 7:
                            item.Points += 4;
                            break;
                        case 8:
                            item.Points += 3;
                            break;
                        case 9:
                            item.Points += 2;
                            break;
                        case 10:
                            item.Points += 1;
                            break;
                    }
                    dataProvider.UpdatePoints(item.CompetitorId, item.Points);
                }

                fr.ButtonOkNameChange();

            }
            fr.ListBoxRank(id);
            fr.Show();

        }

        internal void ListBoxCompetitions_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            var lbx = sender as ListBox;
            string itemText = lbx.GetItemText(lbx.Items[e.Index]);
            Competition comp = (Competition)lbx.Items[e.Index];
            Brush brush;

            brush = comp.Finished ? SystemBrushes.Highlight : new SolidBrush(e.ForeColor);

            e.DrawBackground();
            e.Graphics.DrawString(itemText, e.Font, brush, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void ButtonCreateCompetition_Click(object sender, EventArgs e)
        {
            var cr = new FrmCompetitionRegister(this, _connection);
            cr.ShowDialog();
        }

        
        private void ListBoxCompetitions_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        ContextMenuStrip1.Show(Cursor.Position);
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
                    ContextMenuStrip1.Items[0].Enabled = true;
                    ContextMenuStrip1.Items[1].Enabled = false;
                }
                else
                {
                    ContextMenuStrip1.Items[0].Enabled = false;
                    ContextMenuStrip1.Items[1].Enabled = true;
                } 
            }
        }
        #endregion

        #region ToolStripMenuItems
        private void ToolStripMenuCompetitor_DropDownOpening(object sender, EventArgs e)
        {
            ToolStripMenuCompetitionEdit.Enabled = dataGridViewCompetitors.SelectedRows.Count == 1;
        }

        private void ToolStripMenuCompetitorRegister_Click(object sender, EventArgs e)
        {
            var reg = new FrmRegister(this, _connection);
            reg.ShowDialog();
        }
        
        private void ToolStripMenuCompetitorEdit_Click(object sender, EventArgs e)
        {
            var row = dataGridViewCompetitors.CurrentRow;
            var reg = new FrmEditCompetitor(this, _connection);

            reg.Edit(row);

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

            if (listBoxCompetitions.SelectedIndex != -1 && ((Competition)listBoxCompetitions.SelectedItem).Finished)
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
                competitionId = ((Competition)listBoxCompetitions.SelectedItem).CompetitionId;
                var ec = new FrmEditCompetition(this, _connection);
                ec.CompetitionInfo(listBoxCompetitions);

                ec.ShowDialog();
            }
        }

        private void ToolStripMenuCompetitionResults_Click(object sender, EventArgs e)
        {
            if (listBoxCompetitions.SelectedIndex > -1 && ((Competition)listBoxCompetitions.SelectedItem).Finished)
            {
                Results();
                listBoxCompetitions.SelectedIndex = -1;
            }
        }
        #endregion

        #region ContextMenu
        private void ContextMenuStripResults_Click(object sender, EventArgs e)
        {
            if (listBoxCompetitions.SelectedIndex > -1 && ((Competition)listBoxCompetitions.SelectedItem).Finished)
            {
                Results();
                listBoxCompetitions.SelectedIndex = -1;
            }
        }

        private void ContextMenuStripEdit_Click(object sender, EventArgs e)
        {
            if (((Competition)listBoxCompetitions.SelectedItem).Finished == false)
            {
                competitionId = ((Competition)listBoxCompetitions.SelectedItem).CompetitionId;
                var ec = new FrmEditCompetition(this, _connection);

                ec.CompetitionInfo(listBoxCompetitions);
                ec.ShowDialog();
            }
        }
        #endregion


        internal void ShowCompetitorInfo(DataGridView data)
        {
            var edit = new FrmEditCompetitor(this, _connection);

            edit.CompetitorInfo(data);

            edit.ShowDialog();
        }

        internal void BigFinalForm()
        {
            var bf = new FrmBigFinal(_connection);
            bf.ShowDialog();
        }
        private void BigFinal_Click(object sender, EventArgs e)
        {
            var csf = new FrmCompetitionSelect(_connection);
            csf.Show();
        }
    }

}
