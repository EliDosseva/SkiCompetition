
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
            this.buttonResults = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxRankFemale = new System.Windows.Forms.ListBox();
            this.buttonResultSort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxTeamRank = new System.Windows.Forms.ListBox();
            this.buttonTeamRank = new System.Windows.Forms.Button();
            this.dataGridViewCompetitors = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewMale = new System.Windows.Forms.DataGridView();
            this.Results = new System.Windows.Forms.Label();
            this.dataGridViewFemale = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxRankMale = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemale)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonResults
            // 
            this.buttonResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResults.Location = new System.Drawing.Point(687, 56);
            this.buttonResults.Name = "buttonResults";
            this.buttonResults.Size = new System.Drawing.Size(133, 27);
            this.buttonResults.TabIndex = 1;
            this.buttonResults.Text = "Start";
            this.buttonResults.UseVisualStyleBackColor = true;
            this.buttonResults.Click += new System.EventHandler(this.buttonResults_Click);
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
            // listBoxRankFemale
            // 
            this.listBoxRankFemale.FormattingEnabled = true;
            this.listBoxRankFemale.Location = new System.Drawing.Point(976, 270);
            this.listBoxRankFemale.Name = "listBoxRankFemale";
            this.listBoxRankFemale.Size = new System.Drawing.Size(137, 108);
            this.listBoxRankFemale.TabIndex = 6;
            // 
            // buttonResultSort
            // 
            this.buttonResultSort.Location = new System.Drawing.Point(985, 56);
            this.buttonResultSort.Name = "buttonResultSort";
            this.buttonResultSort.Size = new System.Drawing.Size(107, 28);
            this.buttonResultSort.TabIndex = 7;
            this.buttonResultSort.Text = "Rank";
            this.buttonResultSort.UseVisualStyleBackColor = true;
            this.buttonResultSort.Click += new System.EventHandler(this.buttonResultSort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1003, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Male rank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1160, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Team rank";
            // 
            // listBoxTeamRank
            // 
            this.listBoxTeamRank.FormattingEnabled = true;
            this.listBoxTeamRank.Location = new System.Drawing.Point(1131, 193);
            this.listBoxTeamRank.Name = "listBoxTeamRank";
            this.listBoxTeamRank.Size = new System.Drawing.Size(135, 121);
            this.listBoxTeamRank.TabIndex = 10;
            // 
            // buttonTeamRank
            // 
            this.buttonTeamRank.Location = new System.Drawing.Point(1163, 148);
            this.buttonTeamRank.Name = "buttonTeamRank";
            this.buttonTeamRank.Size = new System.Drawing.Size(75, 23);
            this.buttonTeamRank.TabIndex = 14;
            this.buttonTeamRank.Text = "Rank";
            this.buttonTeamRank.UseVisualStyleBackColor = true;
            this.buttonTeamRank.Click += new System.EventHandler(this.buttonTeamRank_Click);
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
            // dataGridViewMale
            // 
            this.dataGridViewMale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMale.Location = new System.Drawing.Point(577, 121);
            this.dataGridViewMale.Name = "dataGridViewMale";
            this.dataGridViewMale.Size = new System.Drawing.Size(379, 107);
            this.dataGridViewMale.TabIndex = 18;
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Results.Location = new System.Drawing.Point(707, 97);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(94, 20);
            this.Results.TabIndex = 19;
            this.Results.Text = "Male results";
            // 
            // dataGridViewFemale
            // 
            this.dataGridViewFemale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFemale.Location = new System.Drawing.Point(577, 270);
            this.dataGridViewFemale.Name = "dataGridViewFemale";
            this.dataGridViewFemale.Size = new System.Drawing.Size(379, 105);
            this.dataGridViewFemale.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(707, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Female results";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(995, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Female rank";
            // 
            // listBoxRankMale
            // 
            this.listBoxRankMale.FormattingEnabled = true;
            this.listBoxRankMale.Location = new System.Drawing.Point(976, 121);
            this.listBoxRankMale.Name = "listBoxRankMale";
            this.listBoxRankMale.Size = new System.Drawing.Size(137, 108);
            this.listBoxRankMale.TabIndex = 24;
            // 
            // FormSkiCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1278, 460);
            this.Controls.Add(this.listBoxRankMale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewFemale);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.dataGridViewMale);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewCompetitors);
            this.Controls.Add(this.buttonTeamRank);
            this.Controls.Add(this.listBoxTeamRank);
            this.Controls.Add(this.buttonResultSort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxRankFemale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonResults);
            this.Name = "FormSkiCompetition";
            this.Text = "Competition";
            this.Load += new System.EventHandler(this.FormSkiCompetition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonResults;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRankFemale;
        private System.Windows.Forms.Button buttonResultSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxTeamRank;
        private System.Windows.Forms.Button buttonTeamRank;
        private System.Windows.Forms.DataGridView dataGridViewCompetitors;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewMale;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.DataGridView dataGridViewFemale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxRankMale;
    }
}

