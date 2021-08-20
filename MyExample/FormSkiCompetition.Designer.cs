
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelCompetitors = new System.Windows.Forms.TableLayoutPanel();
            this.panelButtonsCompetitors = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.dataGridViewCompetitors = new System.Windows.Forms.DataGridView();
            this.labelListOfCompetitors = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.TeamRank = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelTeamRank = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewTeamRank = new System.Windows.Forms.DataGridView();
            this.labelTeamRanking = new System.Windows.Forms.Label();
            this.tabPages = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelCompetitions = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonCreateCompetition = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCompetitions = new System.Windows.Forms.ListBox();
            this.BigFinal = new System.Windows.Forms.Button();
            this.Leaderboard = new System.Windows.Forms.TabPage();
            this.tableLayoutLeaderboard = new System.Windows.Forms.TableLayoutPanel();
            this.labelFemale = new System.Windows.Forms.Label();
            this.labelMale = new System.Windows.Forms.Label();
            this.dataGridViewFemaleAvg = new System.Windows.Forms.DataGridView();
            this.dataGridViewMaleAvg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutPanelCompetitors.SuspendLayout();
            this.panelButtonsCompetitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetitors)).BeginInit();
            this.Tabs.SuspendLayout();
            this.TeamRank.SuspendLayout();
            this.tableLayoutPanelTeamRank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamRank)).BeginInit();
            this.tabPages.SuspendLayout();
            this.tableLayoutPanelCompetitions.SuspendLayout();
            this.Leaderboard.SuspendLayout();
            this.tableLayoutLeaderboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemaleAvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaleAvg)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer.Location = new System.Drawing.Point(0, 3);
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
            this.splitContainer.Size = new System.Drawing.Size(1330, 577);
            this.splitContainer.SplitterDistance = 576;
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
            this.tableLayoutPanelCompetitors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCompetitors.Controls.Add(this.panelButtonsCompetitors, 0, 2);
            this.tableLayoutPanelCompetitors.Controls.Add(this.dataGridViewCompetitors, 0, 1);
            this.tableLayoutPanelCompetitors.Controls.Add(this.labelListOfCompetitors, 0, 0);
            this.tableLayoutPanelCompetitors.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanelCompetitors.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelCompetitors.Name = "tableLayoutPanelCompetitors";
            this.tableLayoutPanelCompetitors.RowCount = 3;
            this.tableLayoutPanelCompetitors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.3361F));
            this.tableLayoutPanelCompetitors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.6639F));
            this.tableLayoutPanelCompetitors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelCompetitors.Size = new System.Drawing.Size(566, 569);
            this.tableLayoutPanelCompetitors.TabIndex = 26;
            // 
            // panelButtonsCompetitors
            // 
            this.panelButtonsCompetitors.Controls.Add(this.buttonDelete);
            this.panelButtonsCompetitors.Controls.Add(this.buttonRegister);
            this.panelButtonsCompetitors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonsCompetitors.Location = new System.Drawing.Point(4, 508);
            this.panelButtonsCompetitors.Margin = new System.Windows.Forms.Padding(4);
            this.panelButtonsCompetitors.Name = "panelButtonsCompetitors";
            this.panelButtonsCompetitors.Size = new System.Drawing.Size(558, 57);
            this.panelButtonsCompetitors.TabIndex = 27;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(379, 0);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(179, 57);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete competitor";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteCompetitor);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonRegister.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(0, 0);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(155, 57);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "Register competitor";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.ButtonRegisterNewCompetitor);
            // 
            // dataGridViewCompetitors
            // 
            this.dataGridViewCompetitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCompetitors.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewCompetitors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCompetitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompetitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCompetitors.Location = new System.Drawing.Point(4, 51);
            this.dataGridViewCompetitors.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCompetitors.Name = "dataGridViewCompetitors";
            this.dataGridViewCompetitors.ReadOnly = true;
            this.dataGridViewCompetitors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCompetitors.Size = new System.Drawing.Size(558, 449);
            this.dataGridViewCompetitors.TabIndex = 15;
            this.dataGridViewCompetitors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCompetitors_CellDoubleClick);
            this.dataGridViewCompetitors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridViewCompetitors_KeyDown);
            // 
            // labelListOfCompetitors
            // 
            this.labelListOfCompetitors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelListOfCompetitors.AutoSize = true;
            this.labelListOfCompetitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListOfCompetitors.Location = new System.Drawing.Point(213, 13);
            this.labelListOfCompetitors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListOfCompetitors.Name = "labelListOfCompetitors";
            this.labelListOfCompetitors.Size = new System.Drawing.Size(139, 20);
            this.labelListOfCompetitors.TabIndex = 4;
            this.labelListOfCompetitors.Text = "List of competitors";
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.TeamRank);
            this.Tabs.Controls.Add(this.tabPages);
            this.Tabs.Controls.Add(this.Leaderboard);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.ItemSize = new System.Drawing.Size(85, 40);
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Margin = new System.Windows.Forms.Padding(4);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(748, 577);
            this.Tabs.TabIndex = 32;
            // 
            // TeamRank
            // 
            this.TeamRank.BackColor = System.Drawing.Color.Honeydew;
            this.TeamRank.Controls.Add(this.tableLayoutPanelTeamRank);
            this.TeamRank.Location = new System.Drawing.Point(4, 44);
            this.TeamRank.Margin = new System.Windows.Forms.Padding(4);
            this.TeamRank.Name = "TeamRank";
            this.TeamRank.Padding = new System.Windows.Forms.Padding(4);
            this.TeamRank.Size = new System.Drawing.Size(708, 529);
            this.TeamRank.TabIndex = 0;
            this.TeamRank.Text = "TeamRank";
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
            this.tableLayoutPanelTeamRank.Size = new System.Drawing.Size(700, 521);
            this.tableLayoutPanelTeamRank.TabIndex = 27;
            // 
            // dataGridViewTeamRank
            // 
            this.dataGridViewTeamRank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTeamRank.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewTeamRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeamRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTeamRank.Location = new System.Drawing.Point(4, 66);
            this.dataGridViewTeamRank.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewTeamRank.Name = "dataGridViewTeamRank";
            this.dataGridViewTeamRank.ReadOnly = true;
            this.dataGridViewTeamRank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTeamRank.Size = new System.Drawing.Size(692, 451);
            this.dataGridViewTeamRank.TabIndex = 25;
            this.dataGridViewTeamRank.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTeamRank_CellDoubleClick);
            // 
            // labelTeamRanking
            // 
            this.labelTeamRanking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTeamRanking.AutoSize = true;
            this.labelTeamRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTeamRanking.Location = new System.Drawing.Point(294, 21);
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
            this.tabPages.Location = new System.Drawing.Point(4, 44);
            this.tabPages.Margin = new System.Windows.Forms.Padding(4);
            this.tabPages.Name = "tabPages";
            this.tabPages.Padding = new System.Windows.Forms.Padding(4);
            this.tabPages.Size = new System.Drawing.Size(708, 529);
            this.tabPages.TabIndex = 0;
            this.tabPages.Text = "Competitions";
            // 
            // tableLayoutPanelCompetitions
            // 
            this.tableLayoutPanelCompetitions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanelCompetitions.ColumnCount = 1;
            this.tableLayoutPanelCompetitions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCompetitions.Controls.Add(this.ButtonCreateCompetition, 0, 2);
            this.tableLayoutPanelCompetitions.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelCompetitions.Controls.Add(this.listBoxCompetitions, 0, 1);
            this.tableLayoutPanelCompetitions.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanelCompetitions.Name = "tableLayoutPanelCompetitions";
            this.tableLayoutPanelCompetitions.RowCount = 4;
            this.tableLayoutPanelCompetitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanelCompetitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCompetitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanelCompetitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCompetitions.Size = new System.Drawing.Size(458, 488);
            this.tableLayoutPanelCompetitions.TabIndex = 3;
            // 
            // ButtonCreateCompetition
            // 
            this.ButtonCreateCompetition.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonCreateCompetition.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonCreateCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreateCompetition.Location = new System.Drawing.Point(301, 414);
            this.ButtonCreateCompetition.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCreateCompetition.Name = "ButtonCreateCompetition";
            this.ButtonCreateCompetition.Size = new System.Drawing.Size(153, 50);
            this.ButtonCreateCompetition.TabIndex = 4;
            this.ButtonCreateCompetition.Text = "Create new competition";
            this.ButtonCreateCompetition.UseVisualStyleBackColor = false;
            this.ButtonCreateCompetition.Click += new System.EventHandler(this.ButtonCreateCompetition_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Double click to choose competition";
            // 
            // listBoxCompetitions
            // 
            this.listBoxCompetitions.BackColor = System.Drawing.Color.Honeydew;
            this.listBoxCompetitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCompetitions.FormattingEnabled = true;
            this.listBoxCompetitions.ItemHeight = 18;
            this.listBoxCompetitions.Location = new System.Drawing.Point(3, 36);
            this.listBoxCompetitions.Name = "listBoxCompetitions";
            this.listBoxCompetitions.Size = new System.Drawing.Size(452, 371);
            this.listBoxCompetitions.TabIndex = 6;
            this.listBoxCompetitions.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBoxCompetitions_DrawItem);
            this.listBoxCompetitions.DoubleClick += new System.EventHandler(this.ListBoxCompetitions_DoubleClick);
            // 
            // BigFinal
            // 
            this.BigFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BigFinal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BigFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BigFinal.Location = new System.Drawing.Point(596, 486);
            this.BigFinal.Margin = new System.Windows.Forms.Padding(4);
            this.BigFinal.Name = "BigFinal";
            this.BigFinal.Size = new System.Drawing.Size(104, 32);
            this.BigFinal.TabIndex = 2;
            this.BigFinal.Text = "BigFinal";
            this.BigFinal.UseVisualStyleBackColor = false;
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
            this.Leaderboard.Size = new System.Drawing.Size(740, 529);
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
            this.tableLayoutLeaderboard.Size = new System.Drawing.Size(732, 521);
            this.tableLayoutLeaderboard.TabIndex = 32;
            // 
            // labelFemale
            // 
            this.labelFemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFemale.AutoSize = true;
            this.labelFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFemale.Location = new System.Drawing.Point(511, 20);
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
            this.labelMale.Location = new System.Drawing.Point(157, 20);
            this.labelMale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(51, 20);
            this.labelMale.TabIndex = 30;
            this.labelMale.Text = "Men\'s";
            // 
            // dataGridViewFemaleAvg
            // 
            this.dataGridViewFemaleAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFemaleAvg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFemaleAvg.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewFemaleAvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFemaleAvg.Location = new System.Drawing.Point(370, 64);
            this.dataGridViewFemaleAvg.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewFemaleAvg.Name = "dataGridViewFemaleAvg";
            this.dataGridViewFemaleAvg.ReadOnly = true;
            this.dataGridViewFemaleAvg.Size = new System.Drawing.Size(358, 453);
            this.dataGridViewFemaleAvg.TabIndex = 26;
            // 
            // dataGridViewMaleAvg
            // 
            this.dataGridViewMaleAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMaleAvg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMaleAvg.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridViewMaleAvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaleAvg.Location = new System.Drawing.Point(4, 64);
            this.dataGridViewMaleAvg.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMaleAvg.Name = "dataGridViewMaleAvg";
            this.dataGridViewMaleAvg.ReadOnly = true;
            this.dataGridViewMaleAvg.Size = new System.Drawing.Size(358, 453);
            this.dataGridViewMaleAvg.TabIndex = 28;
            // 
            // FormSkiCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1335, 583);
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSkiCompetition";
            this.Text = "Competition";
            this.Load += new System.EventHandler(this.FormSkiCompetition_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanelCompetitors.ResumeLayout(false);
            this.tableLayoutPanelCompetitors.PerformLayout();
            this.panelButtonsCompetitors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetitors)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.TeamRank.ResumeLayout(false);
            this.tableLayoutPanelTeamRank.ResumeLayout(false);
            this.tableLayoutPanelTeamRank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamRank)).EndInit();
            this.tabPages.ResumeLayout(false);
            this.tableLayoutPanelCompetitions.ResumeLayout(false);
            this.tableLayoutPanelCompetitions.PerformLayout();
            this.Leaderboard.ResumeLayout(false);
            this.tableLayoutLeaderboard.ResumeLayout(false);
            this.tableLayoutLeaderboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemaleAvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaleAvg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCompetitors;
        private System.Windows.Forms.Panel panelButtonsCompetitors;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelListOfCompetitors;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage TeamRank;
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
    }
}

