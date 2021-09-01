
using System.Drawing;
using System.Windows.Forms;

namespace MyExample
{
    partial class FormSkiCompetition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSkiCompetition));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelCompetitors = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewCompetitors = new System.Windows.Forms.DataGridView();
            this.ImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.labelListOfCompetitors = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Teams = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelTeamRank = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewTeamRank = new System.Windows.Forms.DataGridView();
            this.labelTeamRanking = new System.Windows.Forms.Label();
            this.tabPages = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelCompetitions = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCompetitions = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ButtonCreateCompetition = new System.Windows.Forms.Button();
            this.BigFinal = new System.Windows.Forms.Button();
            this.Leaderboard = new System.Windows.Forms.TabPage();
            this.tableLayoutLeaderboard = new System.Windows.Forms.TableLayoutPanel();
            this.labelFemale = new System.Windows.Forms.Label();
            this.labelMale = new System.Windows.Forms.Label();
            this.dataGridViewFemaleAvg = new System.Windows.Forms.DataGridView();
            this.dataGridViewMaleAvg = new System.Windows.Forms.DataGridView();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.competotorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerCompetitorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.competitionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuCompetitor = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuCompetitorRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuCompetitorEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuCompetition = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuCompetitionEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuCompetitionResults = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuStripEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStripResults = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutPanelCompetitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetitors)).BeginInit();
            this.Tabs.SuspendLayout();
            this.Teams.SuspendLayout();
            this.tableLayoutPanelTeamRank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamRank)).BeginInit();
            this.tabPages.SuspendLayout();
            this.tableLayoutPanelCompetitions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Leaderboard.SuspendLayout();
            this.tableLayoutLeaderboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemaleAvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaleAvg)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.ContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer.Location = new System.Drawing.Point(0, 28);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tableLayoutPanelCompetitors);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.splitContainer.Panel2.Controls.Add(this.Tabs);
            this.splitContainer.Size = new System.Drawing.Size(1426, 544);
            this.splitContainer.SplitterDistance = 689;
            this.splitContainer.SplitterWidth = 6;
            this.splitContainer.TabIndex = 9;
            // 
            // tableLayoutPanelCompetitors
            // 
            this.tableLayoutPanelCompetitors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelCompetitors.BackColor = System.Drawing.Color.Honeydew;
            this.tableLayoutPanelCompetitors.ColumnCount = 1;
            this.tableLayoutPanelCompetitors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCompetitors.Controls.Add(this.dataGridViewCompetitors, 0, 1);
            this.tableLayoutPanelCompetitors.Controls.Add(this.labelListOfCompetitors, 0, 0);
            this.tableLayoutPanelCompetitors.Location = new System.Drawing.Point(4, 0);
            this.tableLayoutPanelCompetitors.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelCompetitors.Name = "tableLayoutPanelCompetitors";
            this.tableLayoutPanelCompetitors.RowCount = 2;
            this.tableLayoutPanelCompetitors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCompetitors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 479F));
            this.tableLayoutPanelCompetitors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCompetitors.Size = new System.Drawing.Size(679, 540);
            this.tableLayoutPanelCompetitors.TabIndex = 26;
            // 
            // dataGridViewCompetitors
            // 
            this.dataGridViewCompetitors.AllowUserToAddRows = false;
            this.dataGridViewCompetitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCompetitors.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewCompetitors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCompetitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompetitors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImageColumn});
            this.dataGridViewCompetitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCompetitors.Location = new System.Drawing.Point(4, 65);
            this.dataGridViewCompetitors.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCompetitors.Name = "dataGridViewCompetitors";
            this.dataGridViewCompetitors.ReadOnly = true;
            this.dataGridViewCompetitors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCompetitors.Size = new System.Drawing.Size(671, 471);
            this.dataGridViewCompetitors.TabIndex = 15;
            this.dataGridViewCompetitors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCompetitors_CellClick);
            this.dataGridViewCompetitors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCompetitors_CellDoubleClick);
            this.dataGridViewCompetitors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridViewCompetitors_KeyDown);
            // 
            // ImageColumn
            // 
            this.ImageColumn.FillWeight = 30F;
            this.ImageColumn.HeaderText = "";
            this.ImageColumn.Image = global::MyExample.Properties.Resources.delete;
            this.ImageColumn.Name = "ImageColumn";
            this.ImageColumn.ReadOnly = true;
            this.ImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // labelListOfCompetitors
            // 
            this.labelListOfCompetitors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelListOfCompetitors.AutoSize = true;
            this.labelListOfCompetitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListOfCompetitors.Location = new System.Drawing.Point(270, 20);
            this.labelListOfCompetitors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListOfCompetitors.Name = "labelListOfCompetitors";
            this.labelListOfCompetitors.Size = new System.Drawing.Size(139, 20);
            this.labelListOfCompetitors.TabIndex = 4;
            this.labelListOfCompetitors.Text = "List of competitors";
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.Teams);
            this.Tabs.Controls.Add(this.tabPages);
            this.Tabs.Controls.Add(this.Leaderboard);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.ItemSize = new System.Drawing.Size(85, 40);
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Margin = new System.Windows.Forms.Padding(4);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(731, 544);
            this.Tabs.TabIndex = 32;
            // 
            // Teams
            // 
            this.Teams.BackColor = System.Drawing.Color.Honeydew;
            this.Teams.Controls.Add(this.tableLayoutPanelTeamRank);
            this.Teams.Location = new System.Drawing.Point(4, 44);
            this.Teams.Margin = new System.Windows.Forms.Padding(4);
            this.Teams.Name = "Teams";
            this.Teams.Padding = new System.Windows.Forms.Padding(4);
            this.Teams.Size = new System.Drawing.Size(723, 496);
            this.Teams.TabIndex = 0;
            this.Teams.Text = "Teams";
            // 
            // tableLayoutPanelTeamRank
            // 
            this.tableLayoutPanelTeamRank.BackColor = System.Drawing.Color.Honeydew;
            this.tableLayoutPanelTeamRank.ColumnCount = 1;
            this.tableLayoutPanelTeamRank.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTeamRank.Controls.Add(this.dataGridViewTeamRank, 0, 1);
            this.tableLayoutPanelTeamRank.Controls.Add(this.labelTeamRanking, 0, 0);
            this.tableLayoutPanelTeamRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTeamRank.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanelTeamRank.Name = "tableLayoutPanelTeamRank";
            this.tableLayoutPanelTeamRank.RowCount = 2;
            this.tableLayoutPanelTeamRank.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.02405F));
            this.tableLayoutPanelTeamRank.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.97595F));
            this.tableLayoutPanelTeamRank.Size = new System.Drawing.Size(715, 488);
            this.tableLayoutPanelTeamRank.TabIndex = 27;
            // 
            // dataGridViewTeamRank
            // 
            this.dataGridViewTeamRank.AllowUserToAddRows = false;
            this.dataGridViewTeamRank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTeamRank.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewTeamRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeamRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTeamRank.Location = new System.Drawing.Point(4, 62);
            this.dataGridViewTeamRank.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTeamRank.Name = "dataGridViewTeamRank";
            this.dataGridViewTeamRank.ReadOnly = true;
            this.dataGridViewTeamRank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTeamRank.Size = new System.Drawing.Size(707, 422);
            this.dataGridViewTeamRank.TabIndex = 25;
            this.dataGridViewTeamRank.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTeamRank_CellDoubleClick);
            // 
            // labelTeamRanking
            // 
            this.labelTeamRanking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTeamRanking.AutoSize = true;
            this.labelTeamRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTeamRanking.Location = new System.Drawing.Point(301, 19);
            this.labelTeamRanking.Name = "labelTeamRanking";
            this.labelTeamRanking.Size = new System.Drawing.Size(112, 20);
            this.labelTeamRanking.TabIndex = 26;
            this.labelTeamRanking.Text = "Team Ranking";
            // 
            // tabPages
            // 
            this.tabPages.BackColor = System.Drawing.Color.Honeydew;
            this.tabPages.Controls.Add(this.tableLayoutPanelCompetitions);
            this.tabPages.Controls.Add(this.BigFinal);
            this.tabPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPages.Location = new System.Drawing.Point(4, 44);
            this.tabPages.Margin = new System.Windows.Forms.Padding(4);
            this.tabPages.Name = "tabPages";
            this.tabPages.Padding = new System.Windows.Forms.Padding(4);
            this.tabPages.Size = new System.Drawing.Size(723, 496);
            this.tabPages.TabIndex = 0;
            this.tabPages.Text = "Competitions";
            // 
            // tableLayoutPanelCompetitions
            // 
            this.tableLayoutPanelCompetitions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanelCompetitions.ColumnCount = 1;
            this.tableLayoutPanelCompetitions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCompetitions.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelCompetitions.Controls.Add(this.listBoxCompetitions, 0, 1);
            this.tableLayoutPanelCompetitions.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanelCompetitions.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanelCompetitions.Name = "tableLayoutPanelCompetitions";
            this.tableLayoutPanelCompetitions.RowCount = 3;
            this.tableLayoutPanelCompetitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanelCompetitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCompetitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanelCompetitions.Size = new System.Drawing.Size(458, 455);
            this.tableLayoutPanelCompetitions.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Double click to start competition";
            // 
            // listBoxCompetitions
            // 
            this.listBoxCompetitions.BackColor = System.Drawing.Color.Honeydew;
            this.listBoxCompetitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCompetitions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxCompetitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxCompetitions.FormattingEnabled = true;
            this.listBoxCompetitions.ItemHeight = 18;
            this.listBoxCompetitions.Location = new System.Drawing.Point(3, 36);
            this.listBoxCompetitions.Name = "listBoxCompetitions";
            this.listBoxCompetitions.Size = new System.Drawing.Size(452, 362);
            this.listBoxCompetitions.TabIndex = 20;
            this.listBoxCompetitions.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBoxCompetitions_DrawItem);
            this.listBoxCompetitions.DoubleClick += new System.EventHandler(this.ListBoxCompetitions_DoubleClick);
            this.listBoxCompetitions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBoxCompetitions_MouseDown);
            this.listBoxCompetitions.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListBoxCompetitions_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.ButtonCreateCompetition);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 48);
            this.panel1.TabIndex = 22;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Honeydew;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "Finished competitions ",
            "are marked in blue"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(154, 48);
            this.listBox1.TabIndex = 5;
            // 
            // ButtonCreateCompetition
            // 
            this.ButtonCreateCompetition.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonCreateCompetition.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonCreateCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreateCompetition.Location = new System.Drawing.Point(286, 0);
            this.ButtonCreateCompetition.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCreateCompetition.Name = "ButtonCreateCompetition";
            this.ButtonCreateCompetition.Size = new System.Drawing.Size(166, 48);
            this.ButtonCreateCompetition.TabIndex = 4;
            this.ButtonCreateCompetition.Text = "Create new competition";
            this.ButtonCreateCompetition.UseVisualStyleBackColor = false;
            this.ButtonCreateCompetition.Click += new System.EventHandler(this.ButtonCreateCompetition_Click);
            // 
            // BigFinal
            // 
            this.BigFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BigFinal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BigFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BigFinal.Location = new System.Drawing.Point(579, 453);
            this.BigFinal.Margin = new System.Windows.Forms.Padding(4);
            this.BigFinal.Name = "BigFinal";
            this.BigFinal.Size = new System.Drawing.Size(104, 32);
            this.BigFinal.TabIndex = 2;
            this.BigFinal.Text = "BigFinal";
            this.BigFinal.UseVisualStyleBackColor = false;
            this.BigFinal.Visible = false;
            this.BigFinal.Click += new System.EventHandler(this.BigFinal_Click);
            // 
            // Leaderboard
            // 
            this.Leaderboard.BackColor = System.Drawing.Color.Honeydew;
            this.Leaderboard.Controls.Add(this.tableLayoutLeaderboard);
            this.Leaderboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Leaderboard.Location = new System.Drawing.Point(4, 44);
            this.Leaderboard.Margin = new System.Windows.Forms.Padding(4);
            this.Leaderboard.Name = "Leaderboard";
            this.Leaderboard.Padding = new System.Windows.Forms.Padding(4);
            this.Leaderboard.Size = new System.Drawing.Size(723, 496);
            this.Leaderboard.TabIndex = 1;
            this.Leaderboard.Text = "Leaderboard";
            // 
            // tableLayoutLeaderboard
            // 
            this.tableLayoutLeaderboard.BackColor = System.Drawing.Color.Honeydew;
            this.tableLayoutLeaderboard.ColumnCount = 2;
            this.tableLayoutLeaderboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutLeaderboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutLeaderboard.Controls.Add(this.labelFemale, 1, 0);
            this.tableLayoutLeaderboard.Controls.Add(this.labelMale, 0, 0);
            this.tableLayoutLeaderboard.Controls.Add(this.dataGridViewFemaleAvg, 1, 1);
            this.tableLayoutLeaderboard.Controls.Add(this.dataGridViewMaleAvg, 0, 1);
            this.tableLayoutLeaderboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutLeaderboard.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutLeaderboard.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutLeaderboard.Name = "tableLayoutLeaderboard";
            this.tableLayoutLeaderboard.RowCount = 2;
            this.tableLayoutLeaderboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.62325F));
            this.tableLayoutLeaderboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.37675F));
            this.tableLayoutLeaderboard.Size = new System.Drawing.Size(715, 488);
            this.tableLayoutLeaderboard.TabIndex = 32;
            // 
            // labelFemale
            // 
            this.labelFemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFemale.AutoSize = true;
            this.labelFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFemale.Location = new System.Drawing.Point(498, 18);
            this.labelFemale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFemale.Name = "labelFemale";
            this.labelFemale.Size = new System.Drawing.Size(75, 20);
            this.labelFemale.TabIndex = 31;
            this.labelFemale.Text = "Women\'s";
            // 
            // labelMale
            // 
            this.labelMale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMale.AutoSize = true;
            this.labelMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMale.Location = new System.Drawing.Point(153, 18);
            this.labelMale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(51, 20);
            this.labelMale.TabIndex = 30;
            this.labelMale.Text = "Men\'s";
            // 
            // dataGridViewFemaleAvg
            // 
            this.dataGridViewFemaleAvg.AllowUserToAddRows = false;
            this.dataGridViewFemaleAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFemaleAvg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFemaleAvg.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewFemaleAvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFemaleAvg.Location = new System.Drawing.Point(361, 60);
            this.dataGridViewFemaleAvg.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewFemaleAvg.Name = "dataGridViewFemaleAvg";
            this.dataGridViewFemaleAvg.ReadOnly = true;
            this.dataGridViewFemaleAvg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFemaleAvg.Size = new System.Drawing.Size(350, 424);
            this.dataGridViewFemaleAvg.TabIndex = 26;
            this.dataGridViewFemaleAvg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewFemaleAvg_CellDoubleClick);
            // 
            // dataGridViewMaleAvg
            // 
            this.dataGridViewMaleAvg.AllowUserToAddRows = false;
            this.dataGridViewMaleAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMaleAvg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMaleAvg.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewMaleAvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaleAvg.Location = new System.Drawing.Point(4, 60);
            this.dataGridViewMaleAvg.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMaleAvg.Name = "dataGridViewMaleAvg";
            this.dataGridViewMaleAvg.ReadOnly = true;
            this.dataGridViewMaleAvg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMaleAvg.Size = new System.Drawing.Size(349, 424);
            this.dataGridViewMaleAvg.TabIndex = 28;
            this.dataGridViewMaleAvg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMaleAvg_CellDoubleClick);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // competotorToolStripMenuItem
            // 
            this.competotorToolStripMenuItem.Name = "competotorToolStripMenuItem";
            this.competotorToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.competotorToolStripMenuItem.Text = "&Competotor";
            // 
            // registerCompetitorToolStripMenuItem1
            // 
            this.registerCompetitorToolStripMenuItem1.Name = "registerCompetitorToolStripMenuItem1";
            this.registerCompetitorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.registerCompetitorToolStripMenuItem1.Text = "Register competitor";
            // 
            // competitionToolStripMenuItem1
            // 
            this.competitionToolStripMenuItem1.Name = "competitionToolStripMenuItem1";
            this.competitionToolStripMenuItem1.Size = new System.Drawing.Size(86, 20);
            this.competitionToolStripMenuItem1.Text = "&Competition";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // fileToolStripMenuItem2
            // 
            this.fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            this.fileToolStripMenuItem2.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem2.Text = "&File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem3,
            this.ToolStripMenuCompetitor,
            this.ToolStripMenuCompetition});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1426, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem3
            // 
            this.fileToolStripMenuItem3.Name = "fileToolStripMenuItem3";
            this.fileToolStripMenuItem3.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem3.Text = "&File";
            // 
            // ToolStripMenuCompetitor
            // 
            this.ToolStripMenuCompetitor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuCompetitorRegister,
            this.ToolStripMenuCompetitorEdit});
            this.ToolStripMenuCompetitor.Name = "ToolStripMenuCompetitor";
            this.ToolStripMenuCompetitor.Size = new System.Drawing.Size(80, 20);
            this.ToolStripMenuCompetitor.Text = "&Competitor";
            this.ToolStripMenuCompetitor.DropDownOpening += new System.EventHandler(this.ToolStripMenuCompetitor_DropDownOpening);
            // 
            // ToolStripMenuCompetitorRegister
            // 
            this.ToolStripMenuCompetitorRegister.Name = "ToolStripMenuCompetitorRegister";
            this.ToolStripMenuCompetitorRegister.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuCompetitorRegister.Text = "Register competitor";
            this.ToolStripMenuCompetitorRegister.Click += new System.EventHandler(this.ToolStripMenuCompetitorRegister_Click);
            // 
            // ToolStripMenuCompetitorEdit
            // 
            this.ToolStripMenuCompetitorEdit.Name = "ToolStripMenuCompetitorEdit";
            this.ToolStripMenuCompetitorEdit.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuCompetitorEdit.Text = "Edit";
            this.ToolStripMenuCompetitorEdit.Click += new System.EventHandler(this.ToolStripMenuCompetitorEdit_Click);
            // 
            // ToolStripMenuCompetition
            // 
            this.ToolStripMenuCompetition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuCompetitionEdit,
            this.ToolStripMenuCompetitionResults});
            this.ToolStripMenuCompetition.Name = "ToolStripMenuCompetition";
            this.ToolStripMenuCompetition.Size = new System.Drawing.Size(86, 20);
            this.ToolStripMenuCompetition.Text = "&Competition";
            this.ToolStripMenuCompetition.DropDownOpening += new System.EventHandler(this.ToolStripMenuCompetition_DropDownOpening);
            // 
            // ToolStripMenuCompetitionEdit
            // 
            this.ToolStripMenuCompetitionEdit.Name = "ToolStripMenuCompetitionEdit";
            this.ToolStripMenuCompetitionEdit.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuCompetitionEdit.Text = "Edit";
            this.ToolStripMenuCompetitionEdit.Click += new System.EventHandler(this.ToolStripMenuCompetitionEdit_Click);
            // 
            // ToolStripMenuCompetitionResults
            // 
            this.ToolStripMenuCompetitionResults.Name = "ToolStripMenuCompetitionResults";
            this.ToolStripMenuCompetitionResults.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuCompetitionResults.Text = "Results";
            this.ToolStripMenuCompetitionResults.Click += new System.EventHandler(this.ToolStripMenuCompetitionResults_Click);
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuStripEdit,
            this.ContextMenuStripResults});
            this.ContextMenuStrip.Name = "contextMenuStrip1";
            this.ContextMenuStrip.Size = new System.Drawing.Size(112, 48);
            // 
            // ContextMenuStripEdit
            // 
            this.ContextMenuStripEdit.Name = "ContextMenuStripEdit";
            this.ContextMenuStripEdit.Size = new System.Drawing.Size(111, 22);
            this.ContextMenuStripEdit.Text = "Edit";
            this.ContextMenuStripEdit.Click += new System.EventHandler(this.ContextMenuStripEdit_Click);
            // 
            // ContextMenuStripResults
            // 
            this.ContextMenuStripResults.Name = "ContextMenuStripResults";
            this.ContextMenuStripResults.Size = new System.Drawing.Size(111, 22);
            this.ContextMenuStripResults.Text = "Results";
            this.ContextMenuStripResults.Click += new System.EventHandler(this.ContextMenuStripResults_Click);
            // 
            // FormSkiCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1426, 572);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSkiCompetition";
            this.Text = "Competition";
            this.Load += new System.EventHandler(this.FormSkiCompetition_Load_1);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanelCompetitors.ResumeLayout(false);
            this.tableLayoutPanelCompetitors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetitors)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.Teams.ResumeLayout(false);
            this.tableLayoutPanelTeamRank.ResumeLayout(false);
            this.tableLayoutPanelTeamRank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamRank)).EndInit();
            this.tabPages.ResumeLayout(false);
            this.tableLayoutPanelCompetitions.ResumeLayout(false);
            this.tableLayoutPanelCompetitions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Leaderboard.ResumeLayout(false);
            this.tableLayoutLeaderboard.ResumeLayout(false);
            this.tableLayoutLeaderboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemaleAvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaleAvg)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCompetitors;
        private System.Windows.Forms.Label labelListOfCompetitors;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Teams;
        private System.Windows.Forms.TabPage tabPages;
        private System.Windows.Forms.Button ButtonCreateCompetition;
        private System.Windows.Forms.Button BigFinal;
        private System.Windows.Forms.TabPage Leaderboard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLeaderboard;
        private System.Windows.Forms.Label labelFemale;
        private System.Windows.Forms.Label labelMale;
        public System.Windows.Forms.DataGridView dataGridViewFemaleAvg;
        private System.Windows.Forms.Label labelTeamRanking;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTeamRank;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCompetitions;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGridView dataGridViewCompetitors;
        internal System.Windows.Forms.DataGridView dataGridViewTeamRank;
        internal System.Windows.Forms.ListBox listBoxCompetitions;
        internal System.Windows.Forms.DataGridView dataGridViewMaleAvg;
        private Panel panel1;
        private ListBox listBox1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem competotorToolStripMenuItem;
        private ToolStripMenuItem registerCompetitorToolStripMenuItem1;
        private ToolStripMenuItem competitionToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem fileToolStripMenuItem2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem3;
        private ToolStripMenuItem ToolStripMenuCompetitor;
        private ToolStripMenuItem ToolStripMenuCompetitorRegister;
        private ToolStripMenuItem ToolStripMenuCompetitorEdit;
        private ToolStripMenuItem ToolStripMenuCompetition;
        private ToolStripMenuItem ToolStripMenuCompetitionEdit;
        private DataGridViewImageColumn ImageColumn;
        private ToolStripMenuItem ToolStripMenuCompetitionResults;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem ContextMenuStripEdit;
        private ToolStripMenuItem ContextMenuStripResults;
    }
}

