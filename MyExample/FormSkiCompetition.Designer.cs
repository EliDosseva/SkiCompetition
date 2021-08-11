
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
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Leaderboard = new System.Windows.Forms.TabPage();
            this.tableLayoutLeaderboard = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewMaleAvg = new System.Windows.Forms.DataGridView();
            this.dataGridViewFemaleAvg = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPages = new System.Windows.Forms.TabPage();
            this.BigFinal = new System.Windows.Forms.Button();
            this.listBoxCompetitions = new System.Windows.Forms.ListBox();
            this.ButtonCreateCompetition = new System.Windows.Forms.Button();
            this.textBoxCompetition = new System.Windows.Forms.TextBox();
            this.TeamRank = new System.Windows.Forms.TabPage();
            this.dataGridViewTeamRank = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelCompetitors = new System.Windows.Forms.TableLayoutPanel();
            this.labelListOfCompetitors = new System.Windows.Forms.Label();
            this.dataGridViewCompetitors = new System.Windows.Forms.DataGridView();
            this.panelButtonsCompetitors = new System.Windows.Forms.Panel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelTeamRanking = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.Leaderboard.SuspendLayout();
            this.tableLayoutLeaderboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaleAvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemaleAvg)).BeginInit();
            this.tabPages.SuspendLayout();
            this.TeamRank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamRank)).BeginInit();
            this.tableLayoutPanelCompetitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetitors)).BeginInit();
            this.panelButtonsCompetitors.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1815, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 18);
            this.label7.TabIndex = 29;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(0, 3);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.splitContainer.Size = new System.Drawing.Size(1433, 534);
            this.splitContainer.SplitterDistance = 562;
            this.splitContainer.SplitterWidth = 6;
            this.splitContainer.TabIndex = 9;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.TeamRank);
            this.Tabs.Controls.Add(this.tabPages);
            this.Tabs.Controls.Add(this.Leaderboard);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.ItemSize = new System.Drawing.Size(85, 40);
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(865, 534);
            this.Tabs.TabIndex = 32;
            // 
            // Leaderboard
            // 
            this.Leaderboard.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Leaderboard.Controls.Add(this.tableLayoutLeaderboard);
            this.Leaderboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Leaderboard.Location = new System.Drawing.Point(4, 44);
            this.Leaderboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Leaderboard.Name = "Leaderboard";
            this.Leaderboard.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Leaderboard.Size = new System.Drawing.Size(857, 486);
            this.Leaderboard.TabIndex = 1;
            this.Leaderboard.Text = "Leaderboard";
            // 
            // tableLayoutLeaderboard
            // 
            this.tableLayoutLeaderboard.ColumnCount = 2;
            this.tableLayoutLeaderboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutLeaderboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutLeaderboard.Controls.Add(this.label9, 1, 0);
            this.tableLayoutLeaderboard.Controls.Add(this.label8, 0, 0);
            this.tableLayoutLeaderboard.Controls.Add(this.dataGridViewFemaleAvg, 1, 1);
            this.tableLayoutLeaderboard.Controls.Add(this.dataGridViewMaleAvg, 0, 1);
            this.tableLayoutLeaderboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutLeaderboard.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutLeaderboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutLeaderboard.Name = "tableLayoutLeaderboard";
            this.tableLayoutLeaderboard.RowCount = 2;
            this.tableLayoutLeaderboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.62325F));
            this.tableLayoutLeaderboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.37675F));
            this.tableLayoutLeaderboard.Size = new System.Drawing.Size(849, 478);
            this.tableLayoutLeaderboard.TabIndex = 32;
            // 
            // dataGridViewMaleAvg
            // 
            this.dataGridViewMaleAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMaleAvg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMaleAvg.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridViewMaleAvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaleAvg.Location = new System.Drawing.Point(4, 59);
            this.dataGridViewMaleAvg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMaleAvg.Name = "dataGridViewMaleAvg";
            this.dataGridViewMaleAvg.Size = new System.Drawing.Size(416, 415);
            this.dataGridViewMaleAvg.TabIndex = 28;
            // 
            // dataGridViewFemaleAvg
            // 
            this.dataGridViewFemaleAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFemaleAvg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFemaleAvg.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridViewFemaleAvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFemaleAvg.Location = new System.Drawing.Point(428, 59);
            this.dataGridViewFemaleAvg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewFemaleAvg.Name = "dataGridViewFemaleAvg";
            this.dataGridViewFemaleAvg.Size = new System.Drawing.Size(417, 415);
            this.dataGridViewFemaleAvg.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(186, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Men\'s";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(599, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Women\'s";
            // 
            // tabPages
            // 
            this.tabPages.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPages.Controls.Add(this.textBoxCompetition);
            this.tabPages.Controls.Add(this.ButtonCreateCompetition);
            this.tabPages.Controls.Add(this.listBoxCompetitions);
            this.tabPages.Controls.Add(this.BigFinal);
            this.tabPages.Location = new System.Drawing.Point(4, 44);
            this.tabPages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPages.Name = "tabPages";
            this.tabPages.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPages.Size = new System.Drawing.Size(857, 486);
            this.tabPages.TabIndex = 0;
            this.tabPages.Text = "Competitions";
            // 
            // BigFinal
            // 
            this.BigFinal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BigFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BigFinal.Location = new System.Drawing.Point(474, 105);
            this.BigFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BigFinal.Name = "BigFinal";
            this.BigFinal.Size = new System.Drawing.Size(104, 32);
            this.BigFinal.TabIndex = 2;
            this.BigFinal.Text = "BigFinal";
            this.BigFinal.UseVisualStyleBackColor = false;
            this.BigFinal.Click += new System.EventHandler(this.BigFinal_Click);
            // 
            // listBoxCompetitions
            // 
            this.listBoxCompetitions.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listBoxCompetitions.DisplayMember = "ID";
            this.listBoxCompetitions.FormattingEnabled = true;
            this.listBoxCompetitions.ItemHeight = 18;
            this.listBoxCompetitions.Location = new System.Drawing.Point(9, 4);
            this.listBoxCompetitions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxCompetitions.Name = "listBoxCompetitions";
            this.listBoxCompetitions.Size = new System.Drawing.Size(385, 202);
            this.listBoxCompetitions.TabIndex = 3;
            this.listBoxCompetitions.ValueMember = "ID";
            this.listBoxCompetitions.DoubleClick += new System.EventHandler(this.listBoxCompetitions_DoubleClick);
            // 
            // ButtonCreateCompetition
            // 
            this.ButtonCreateCompetition.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonCreateCompetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreateCompetition.Location = new System.Drawing.Point(192, 226);
            this.ButtonCreateCompetition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonCreateCompetition.Name = "ButtonCreateCompetition";
            this.ButtonCreateCompetition.Size = new System.Drawing.Size(202, 24);
            this.ButtonCreateCompetition.TabIndex = 4;
            this.ButtonCreateCompetition.Text = "Create new competition";
            this.ButtonCreateCompetition.UseVisualStyleBackColor = false;
            this.ButtonCreateCompetition.Click += new System.EventHandler(this.ButtonCreateCompetition_Click);
            // 
            // textBoxCompetition
            // 
            this.textBoxCompetition.Location = new System.Drawing.Point(9, 225);
            this.textBoxCompetition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCompetition.Name = "textBoxCompetition";
            this.textBoxCompetition.Size = new System.Drawing.Size(161, 24);
            this.textBoxCompetition.TabIndex = 5;
            // 
            // TeamRank
            // 
            this.TeamRank.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TeamRank.Controls.Add(this.tableLayoutPanel1);
            this.TeamRank.Location = new System.Drawing.Point(4, 44);
            this.TeamRank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TeamRank.Name = "TeamRank";
            this.TeamRank.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TeamRank.Size = new System.Drawing.Size(857, 486);
            this.TeamRank.TabIndex = 0;
            this.TeamRank.Text = "TeamRank";
            // 
            // dataGridViewTeamRank
            // 
            this.dataGridViewTeamRank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTeamRank.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridViewTeamRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeamRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTeamRank.Location = new System.Drawing.Point(4, 61);
            this.dataGridViewTeamRank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTeamRank.Name = "dataGridViewTeamRank";
            this.dataGridViewTeamRank.Size = new System.Drawing.Size(841, 413);
            this.dataGridViewTeamRank.TabIndex = 25;
            // 
            // tableLayoutPanelCompetitors
            // 
            this.tableLayoutPanelCompetitors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelCompetitors.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tableLayoutPanelCompetitors.ColumnCount = 1;
            this.tableLayoutPanelCompetitors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCompetitors.Controls.Add(this.panelButtonsCompetitors, 0, 2);
            this.tableLayoutPanelCompetitors.Controls.Add(this.dataGridViewCompetitors, 0, 1);
            this.tableLayoutPanelCompetitors.Controls.Add(this.labelListOfCompetitors, 0, 0);
            this.tableLayoutPanelCompetitors.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanelCompetitors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanelCompetitors.Name = "tableLayoutPanelCompetitors";
            this.tableLayoutPanelCompetitors.RowCount = 3;
            this.tableLayoutPanelCompetitors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.3361F));
            this.tableLayoutPanelCompetitors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.6639F));
            this.tableLayoutPanelCompetitors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanelCompetitors.Size = new System.Drawing.Size(552, 526);
            this.tableLayoutPanelCompetitors.TabIndex = 26;
            // 
            // labelListOfCompetitors
            // 
            this.labelListOfCompetitors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelListOfCompetitors.AutoSize = true;
            this.labelListOfCompetitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListOfCompetitors.Location = new System.Drawing.Point(206, 11);
            this.labelListOfCompetitors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelListOfCompetitors.Name = "labelListOfCompetitors";
            this.labelListOfCompetitors.Size = new System.Drawing.Size(139, 20);
            this.labelListOfCompetitors.TabIndex = 4;
            this.labelListOfCompetitors.Text = "List of competitors";
            // 
            // dataGridViewCompetitors
            // 
            this.dataGridViewCompetitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCompetitors.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridViewCompetitors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCompetitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompetitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCompetitors.Location = new System.Drawing.Point(4, 47);
            this.dataGridViewCompetitors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCompetitors.Name = "dataGridViewCompetitors";
            this.dataGridViewCompetitors.Size = new System.Drawing.Size(544, 410);
            this.dataGridViewCompetitors.TabIndex = 15;
            this.dataGridViewCompetitors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridViewCompetitors_KeyDown);
            // 
            // panelButtonsCompetitors
            // 
            this.panelButtonsCompetitors.Controls.Add(this.buttonDelete);
            this.panelButtonsCompetitors.Controls.Add(this.buttonRegister);
            this.panelButtonsCompetitors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtonsCompetitors.Location = new System.Drawing.Point(4, 465);
            this.panelButtonsCompetitors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelButtonsCompetitors.Name = "panelButtonsCompetitors";
            this.panelButtonsCompetitors.Size = new System.Drawing.Size(544, 57);
            this.panelButtonsCompetitors.TabIndex = 27;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonRegister.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(0, 0);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(155, 57);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "Register competitor";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.ButtonRegisterNewCompetitor);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(365, 0);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(179, 57);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete competitor";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteCompetitor);
            // 
            // labelTeamRanking
            // 
            this.labelTeamRanking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTeamRanking.AutoSize = true;
            this.labelTeamRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTeamRanking.Location = new System.Drawing.Point(368, 18);
            this.labelTeamRanking.Name = "labelTeamRanking";
            this.labelTeamRanking.Size = new System.Drawing.Size(112, 20);
            this.labelTeamRanking.TabIndex = 26;
            this.labelTeamRanking.Text = "Team Ranking";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewTeamRank, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelTeamRanking, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.02405F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.97595F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 478);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // FormSkiCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1438, 540);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSkiCompetition";
            this.Text = "Competition";
            this.Load += new System.EventHandler(this.FormSkiCompetition_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.Tabs.ResumeLayout(false);
            this.Leaderboard.ResumeLayout(false);
            this.tableLayoutLeaderboard.ResumeLayout(false);
            this.tableLayoutLeaderboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaleAvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemaleAvg)).EndInit();
            this.tabPages.ResumeLayout(false);
            this.tabPages.PerformLayout();
            this.TeamRank.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamRank)).EndInit();
            this.tableLayoutPanelCompetitors.ResumeLayout(false);
            this.tableLayoutPanelCompetitors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetitors)).EndInit();
            this.panelButtonsCompetitors.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCompetitors;
        private System.Windows.Forms.Panel panelButtonsCompetitors;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.DataGridView dataGridViewCompetitors;
        private System.Windows.Forms.Label labelListOfCompetitors;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage TeamRank;
        private System.Windows.Forms.DataGridView dataGridViewTeamRank;
        private System.Windows.Forms.TabPage tabPages;
        private System.Windows.Forms.TextBox textBoxCompetition;
        private System.Windows.Forms.Button ButtonCreateCompetition;
        public System.Windows.Forms.ListBox listBoxCompetitions;
        private System.Windows.Forms.Button BigFinal;
        private System.Windows.Forms.TabPage Leaderboard;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLeaderboard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView dataGridViewFemaleAvg;
        private System.Windows.Forms.DataGridView dataGridViewMaleAvg;
        private System.Windows.Forms.Label labelTeamRanking;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

