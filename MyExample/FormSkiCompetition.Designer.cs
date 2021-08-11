
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCompetitors = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewTeamRank = new System.Windows.Forms.DataGridView();
            this.dataGridViewFemaleAvg = new System.Windows.Forms.DataGridView();
            this.dataGridViewMaleAvg = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TabPages = new System.Windows.Forms.TabControl();
            this.TeamRank = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxCompetition = new System.Windows.Forms.TextBox();
            this.ButtonCreateCompetition = new System.Windows.Forms.Button();
            this.listBoxCompetitions = new System.Windows.Forms.ListBox();
            this.BigFinal = new System.Windows.Forms.Button();
            this.Leaderboard = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableCompetitionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.skiCompetitionDataSet = new MyExample.SkiCompetitionDataSet();
            this.tableCompetitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableCompetitionsTableAdapter = new MyExample.SkiCompetitionDataSetTableAdapters.TableCompetitionsTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemaleAvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaleAvg)).BeginInit();
            this.TabPages.SuspendLayout();
            this.TeamRank.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Leaderboard.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCompetitionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skiCompetitionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCompetitionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonRegister.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(0, 0);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(149, 64);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "Register competitor";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.ButtonRegisterNewCompetitor);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(225, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "List of competitors";
            // 
            // dataGridViewCompetitors
            // 
            this.dataGridViewCompetitors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCompetitors.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCompetitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompetitors.Location = new System.Drawing.Point(3, 56);
            this.dataGridViewCompetitors.Name = "dataGridViewCompetitors";
            this.dataGridViewCompetitors.Size = new System.Drawing.Size(584, 374);
            this.dataGridViewCompetitors.TabIndex = 15;
            this.dataGridViewCompetitors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridViewCompetitors_KeyDown);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(365, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(153, 64);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete competitor";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteCompetitor);
            // 
            // dataGridViewTeamRank
            // 
            this.dataGridViewTeamRank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTeamRank.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridViewTeamRank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTeamRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeamRank.Location = new System.Drawing.Point(30, 50);
            this.dataGridViewTeamRank.Name = "dataGridViewTeamRank";
            this.dataGridViewTeamRank.Size = new System.Drawing.Size(302, 169);
            this.dataGridViewTeamRank.TabIndex = 25;
            // 
            // dataGridViewFemaleAvg
            // 
            this.dataGridViewFemaleAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFemaleAvg.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridViewFemaleAvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFemaleAvg.Location = new System.Drawing.Point(341, 51);
            this.dataGridViewFemaleAvg.Name = "dataGridViewFemaleAvg";
            this.dataGridViewFemaleAvg.Size = new System.Drawing.Size(332, 186);
            this.dataGridViewFemaleAvg.TabIndex = 26;
            // 
            // dataGridViewMaleAvg
            // 
            this.dataGridViewMaleAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMaleAvg.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridViewMaleAvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaleAvg.Location = new System.Drawing.Point(3, 51);
            this.dataGridViewMaleAvg.Name = "dataGridViewMaleAvg";
            this.dataGridViewMaleAvg.Size = new System.Drawing.Size(332, 186);
            this.dataGridViewMaleAvg.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1210, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(147, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Male";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(476, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Female";
            // 
            // TabPages
            // 
            this.TabPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabPages.Controls.Add(this.TeamRank);
            this.TabPages.Controls.Add(this.tabPage1);
            this.TabPages.Controls.Add(this.Leaderboard);
            this.TabPages.Location = new System.Drawing.Point(19, 82);
            this.TabPages.Name = "TabPages";
            this.TabPages.SelectedIndex = 0;
            this.TabPages.Size = new System.Drawing.Size(726, 341);
            this.TabPages.TabIndex = 32;
            // 
            // TeamRank
            // 
            this.TeamRank.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TeamRank.Controls.Add(this.dataGridViewTeamRank);
            this.TeamRank.Location = new System.Drawing.Point(4, 22);
            this.TeamRank.Name = "TeamRank";
            this.TeamRank.Padding = new System.Windows.Forms.Padding(3);
            this.TeamRank.Size = new System.Drawing.Size(664, 281);
            this.TeamRank.TabIndex = 0;
            this.TeamRank.Text = "TeamRank";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPage1.Controls.Add(this.textBoxCompetition);
            this.tabPage1.Controls.Add(this.ButtonCreateCompetition);
            this.tabPage1.Controls.Add(this.listBoxCompetitions);
            this.tabPage1.Controls.Add(this.BigFinal);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Competitions";
            // 
            // textBoxCompetition
            // 
            this.textBoxCompetition.Location = new System.Drawing.Point(306, 37);
            this.textBoxCompetition.Name = "textBoxCompetition";
            this.textBoxCompetition.Size = new System.Drawing.Size(153, 20);
            this.textBoxCompetition.TabIndex = 5;
            // 
            // ButtonCreateCompetition
            // 
            this.ButtonCreateCompetition.Location = new System.Drawing.Point(306, 63);
            this.ButtonCreateCompetition.Name = "ButtonCreateCompetition";
            this.ButtonCreateCompetition.Size = new System.Drawing.Size(153, 40);
            this.ButtonCreateCompetition.TabIndex = 4;
            this.ButtonCreateCompetition.Text = "Create new competition";
            this.ButtonCreateCompetition.UseVisualStyleBackColor = true;
            this.ButtonCreateCompetition.Click += new System.EventHandler(this.ButtonCreateCompetition_Click);
            // 
            // listBoxCompetitions
            // 
            this.listBoxCompetitions.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listBoxCompetitions.DisplayMember = "ID";
            this.listBoxCompetitions.FormattingEnabled = true;
            this.listBoxCompetitions.Location = new System.Drawing.Point(6, 3);
            this.listBoxCompetitions.Name = "listBoxCompetitions";
            this.listBoxCompetitions.Size = new System.Drawing.Size(258, 199);
            this.listBoxCompetitions.TabIndex = 3;
            this.listBoxCompetitions.ValueMember = "ID";
            this.listBoxCompetitions.DoubleClick += new System.EventHandler(this.listBoxCompetitions_DoubleClick);
            // 
            // BigFinal
            // 
            this.BigFinal.Location = new System.Drawing.Point(323, 164);
            this.BigFinal.Name = "BigFinal";
            this.BigFinal.Size = new System.Drawing.Size(136, 23);
            this.BigFinal.TabIndex = 2;
            this.BigFinal.Text = "BigFinal";
            this.BigFinal.UseVisualStyleBackColor = true;
            this.BigFinal.Click += new System.EventHandler(this.BigFinal_Click);
            // 
            // Leaderboard
            // 
            this.Leaderboard.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Leaderboard.Controls.Add(this.tableLayoutPanel2);
            this.Leaderboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Leaderboard.Location = new System.Drawing.Point(4, 22);
            this.Leaderboard.Name = "Leaderboard";
            this.Leaderboard.Padding = new System.Windows.Forms.Padding(3);
            this.Leaderboard.Size = new System.Drawing.Size(718, 315);
            this.Leaderboard.TabIndex = 1;
            this.Leaderboard.Text = "Leaderboard";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewFemaleAvg, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewMaleAvg, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 29);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(676, 240);
            this.tableLayoutPanel2.TabIndex = 32;
            // 
            // tableCompetitionsBindingSource1
            // 
            this.tableCompetitionsBindingSource1.DataMember = "TableCompetitions";
            this.tableCompetitionsBindingSource1.DataSource = this.skiCompetitionDataSet;
            // 
            // skiCompetitionDataSet
            // 
            this.skiCompetitionDataSet.DataSetName = "SkiCompetitionDataSet";
            this.skiCompetitionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableCompetitionsBindingSource
            // 
            this.tableCompetitionsBindingSource.DataMember = "TableCompetitions";
            this.tableCompetitionsBindingSource.DataSource = this.skiCompetitionDataSet;
            // 
            // tableCompetitionsTableAdapter
            // 
            this.tableCompetitionsTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TabPages);
            this.splitContainer1.Size = new System.Drawing.Size(1370, 509);
            this.splitContainer1.SplitterDistance = 596;
            this.splitContainer1.TabIndex = 33;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewCompetitors, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2905F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.7095F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 503);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Location = new System.Drawing.Point(3, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 64);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Location = new System.Drawing.Point(1, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1384, 527);
            this.panel2.TabIndex = 34;
            // 
            // FormSkiCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1394, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSkiCompetition";
            this.Text = "Competition";
            this.Load += new System.EventHandler(this.FormSkiCompetition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemaleAvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaleAvg)).EndInit();
            this.TabPages.ResumeLayout(false);
            this.TeamRank.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Leaderboard.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCompetitionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skiCompetitionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCompetitionsBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCompetitors;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewTeamRank;
        private System.Windows.Forms.DataGridView dataGridViewMaleAvg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl TabPages;
        private System.Windows.Forms.TabPage TeamRank;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Leaderboard;
        private System.Windows.Forms.Button BigFinal;
        public System.Windows.Forms.ListBox listBoxCompetitions;
        private SkiCompetitionDataSet skiCompetitionDataSet;
        private System.Windows.Forms.BindingSource tableCompetitionsBindingSource;
        private SkiCompetitionDataSetTableAdapters.TableCompetitionsTableAdapter tableCompetitionsTableAdapter;
        private System.Windows.Forms.BindingSource tableCompetitionsBindingSource1;
        public System.Windows.Forms.DataGridView dataGridViewFemaleAvg;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ButtonCreateCompetition;
        private System.Windows.Forms.TextBox textBoxCompetition;
    }
}

