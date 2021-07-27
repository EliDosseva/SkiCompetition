
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
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxRank = new System.Windows.Forms.ListBox();
            this.buttonResultSort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxTeamRank = new System.Windows.Forms.ListBox();
            this.buttonTeamRank = new System.Windows.Forms.Button();
            this.dataGridViewCompetitors = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.Results = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetitors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonResults
            // 
            this.buttonResults.Location = new System.Drawing.Point(671, 78);
            this.buttonResults.Name = "buttonResults";
            this.buttonResults.Size = new System.Drawing.Size(87, 23);
            this.buttonResults.TabIndex = 1;
            this.buttonResults.Text = "Start";
            this.buttonResults.UseVisualStyleBackColor = true;
            this.buttonResults.Click += new System.EventHandler(this.buttonResults_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(107, 352);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(149, 49);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "Register competitor";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(588, 107);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(170, 121);
            this.listBoxResults.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(585, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Results";
            // 
            // listBoxRank
            // 
            this.listBoxRank.FormattingEnabled = true;
            this.listBoxRank.Location = new System.Drawing.Point(778, 107);
            this.listBoxRank.Name = "listBoxRank";
            this.listBoxRank.Size = new System.Drawing.Size(170, 121);
            this.listBoxRank.TabIndex = 6;
            // 
            // buttonResultSort
            // 
            this.buttonResultSort.Location = new System.Drawing.Point(862, 75);
            this.buttonResultSort.Name = "buttonResultSort";
            this.buttonResultSort.Size = new System.Drawing.Size(86, 23);
            this.buttonResultSort.TabIndex = 7;
            this.buttonResultSort.Text = "Rank";
            this.buttonResultSort.UseVisualStyleBackColor = true;
            this.buttonResultSort.Click += new System.EventHandler(this.buttonResultSort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(775, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(962, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Team rank";
            // 
            // listBoxTeamRank
            // 
            this.listBoxTeamRank.FormattingEnabled = true;
            this.listBoxTeamRank.Location = new System.Drawing.Point(965, 108);
            this.listBoxTeamRank.Name = "listBoxTeamRank";
            this.listBoxTeamRank.Size = new System.Drawing.Size(170, 121);
            this.listBoxTeamRank.TabIndex = 10;
            // 
            // buttonTeamRank
            // 
            this.buttonTeamRank.Location = new System.Drawing.Point(1060, 79);
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
            this.dataGridViewCompetitors.Size = new System.Drawing.Size(543, 238);
            this.dataGridViewCompetitors.TabIndex = 15;
            this.dataGridViewCompetitors.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewCompetitors_KeyDown);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(295, 352);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(153, 49);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete competitor";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(588, 270);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(547, 108);
            this.dataGridViewResults.TabIndex = 18;
            // 
            // Results
            // 
            this.Results.AutoSize = true;
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Results.Location = new System.Drawing.Point(824, 245);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(63, 20);
            this.Results.TabIndex = 19;
            this.Results.Text = "Results";
            // 
            // FormSkiCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1159, 442);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewCompetitors);
            this.Controls.Add(this.buttonTeamRank);
            this.Controls.Add(this.listBoxTeamRank);
            this.Controls.Add(this.buttonResultSort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxRank);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonResults);
            this.Controls.Add(this.listBoxResults);
            this.Name = "FormSkiCompetition";
            this.Text = "Competition";
            this.Load += new System.EventHandler(this.FormSkiCompetition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetitors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonResults;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxRank;
        private System.Windows.Forms.Button buttonResultSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxTeamRank;
        private System.Windows.Forms.Button buttonTeamRank;
        private System.Windows.Forms.DataGridView dataGridViewCompetitors;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Label Results;
    }
}

