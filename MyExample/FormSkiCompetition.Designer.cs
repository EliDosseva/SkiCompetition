
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Leaderboard = new System.Windows.Forms.TabPage();
            this.TeamRank = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.VitoshaCompetition = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemaleAvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaleAvg)).BeginInit();
            this.TabPages.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Leaderboard.SuspendLayout();
            this.TeamRank.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(107, 379);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(149, 49);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "Register competitor";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(198, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "List of competitors";
            // 
            // dataGridViewCompetitors
            // 
            this.dataGridViewCompetitors.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewCompetitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompetitors.Location = new System.Drawing.Point(12, 108);
            this.dataGridViewCompetitors.Name = "dataGridViewCompetitors";
            this.dataGridViewCompetitors.Size = new System.Drawing.Size(543, 265);
            this.dataGridViewCompetitors.TabIndex = 15;
            this.dataGridViewCompetitors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewCompetitors_KeyDown);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(294, 379);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(153, 49);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete competitor";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewTeamRank
            // 
            this.dataGridViewTeamRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeamRank.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewTeamRank.Name = "dataGridViewTeamRank";
            this.dataGridViewTeamRank.Size = new System.Drawing.Size(308, 116);
            this.dataGridViewTeamRank.TabIndex = 25;
            // 
            // dataGridViewFemaleAvg
            // 
            this.dataGridViewFemaleAvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFemaleAvg.Location = new System.Drawing.Point(315, 37);
            this.dataGridViewFemaleAvg.Name = "dataGridViewFemaleAvg";
            this.dataGridViewFemaleAvg.Size = new System.Drawing.Size(262, 121);
            this.dataGridViewFemaleAvg.TabIndex = 26;
            // 
            // dataGridViewMaleAvg
            // 
            this.dataGridViewMaleAvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaleAvg.Location = new System.Drawing.Point(6, 37);
            this.dataGridViewMaleAvg.Name = "dataGridViewMaleAvg";
            this.dataGridViewMaleAvg.Size = new System.Drawing.Size(262, 117);
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
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(113, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Male";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(414, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Female";
            // 
            // TabPages
            // 
            this.TabPages.Controls.Add(this.TeamRank);
            this.TabPages.Controls.Add(this.tabPage1);
            this.TabPages.Controls.Add(this.Leaderboard);
            this.TabPages.Controls.Add(this.tabPage4);
            this.TabPages.Location = new System.Drawing.Point(619, 108);
            this.TabPages.Name = "TabPages";
            this.TabPages.SelectedIndex = 0;
            this.TabPages.Size = new System.Drawing.Size(633, 265);
            this.TabPages.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.VitoshaCompetition);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(625, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Competitions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Leaderboard
            // 
            this.Leaderboard.Controls.Add(this.dataGridViewMaleAvg);
            this.Leaderboard.Controls.Add(this.label8);
            this.Leaderboard.Controls.Add(this.label9);
            this.Leaderboard.Controls.Add(this.dataGridViewFemaleAvg);
            this.Leaderboard.Location = new System.Drawing.Point(4, 22);
            this.Leaderboard.Name = "Leaderboard";
            this.Leaderboard.Padding = new System.Windows.Forms.Padding(3);
            this.Leaderboard.Size = new System.Drawing.Size(625, 239);
            this.Leaderboard.TabIndex = 1;
            this.Leaderboard.Text = "Leaderboard";
            this.Leaderboard.UseVisualStyleBackColor = true;
            // 
            // TeamRank
            // 
            this.TeamRank.Controls.Add(this.dataGridViewTeamRank);
            this.TeamRank.Location = new System.Drawing.Point(4, 22);
            this.TeamRank.Name = "TeamRank";
            this.TeamRank.Padding = new System.Windows.Forms.Padding(3);
            this.TeamRank.Size = new System.Drawing.Size(625, 239);
            this.TeamRank.TabIndex = 0;
            this.TeamRank.Text = "TeamRank";
            this.TeamRank.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(625, 239);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // VitoshaCompetition
            // 
            this.VitoshaCompetition.BackColor = System.Drawing.Color.White;
            this.VitoshaCompetition.Location = new System.Drawing.Point(18, 18);
            this.VitoshaCompetition.Name = "VitoshaCompetition";
            this.VitoshaCompetition.Size = new System.Drawing.Size(257, 26);
            this.VitoshaCompetition.TabIndex = 0;
            this.VitoshaCompetition.Text = "VitoshaCompetition";
            this.VitoshaCompetition.UseVisualStyleBackColor = false;
            this.VitoshaCompetition.Click += new System.EventHandler(this.VitoshaCompetition_Click);
            // 
            // FormSkiCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1338, 519);
            this.Controls.Add(this.TabPages);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewCompetitors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRegister);
            this.Name = "FormSkiCompetition";
            this.Text = "Competition";
            this.Load += new System.EventHandler(this.FormSkiCompetition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeamRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemaleAvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaleAvg)).EndInit();
            this.TabPages.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Leaderboard.ResumeLayout(false);
            this.Leaderboard.PerformLayout();
            this.TeamRank.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCompetitors;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewTeamRank;
        private System.Windows.Forms.DataGridView dataGridViewFemaleAvg;
        private System.Windows.Forms.DataGridView dataGridViewMaleAvg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl TabPages;
        private System.Windows.Forms.TabPage TeamRank;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Leaderboard;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button VitoshaCompetition;
    }
}

