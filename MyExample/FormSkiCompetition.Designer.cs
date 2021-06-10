
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
            this.listBoxBoys = new System.Windows.Forms.ListBox();
            this.buttonResults = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.listBoxResultsBoys = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxRankBoys = new System.Windows.Forms.ListBox();
            this.buttonResultSort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxTeamRank = new System.Windows.Forms.ListBox();
            this.listBoxGirls = new System.Windows.Forms.ListBox();
            this.listBoxResultsGirls = new System.Windows.Forms.ListBox();
            this.listBoxRankGirls = new System.Windows.Forms.ListBox();
            this.buttonTeamRank = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBoys
            // 
            this.listBoxBoys.FormattingEnabled = true;
            this.listBoxBoys.Location = new System.Drawing.Point(12, 129);
            this.listBoxBoys.Name = "listBoxBoys";
            this.listBoxBoys.Size = new System.Drawing.Size(223, 121);
            this.listBoxBoys.TabIndex = 0;
            // 
            // buttonResults
            // 
            this.buttonResults.Location = new System.Drawing.Point(336, 94);
            this.buttonResults.Name = "buttonResults";
            this.buttonResults.Size = new System.Drawing.Size(87, 23);
            this.buttonResults.TabIndex = 1;
            this.buttonResults.Text = "Start";
            this.buttonResults.UseVisualStyleBackColor = true;
            this.buttonResults.Click += new System.EventHandler(this.buttonResults_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(15, 42);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(220, 49);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "Register competitor";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // listBoxResultsBoys
            // 
            this.listBoxResultsBoys.FormattingEnabled = true;
            this.listBoxResultsBoys.Location = new System.Drawing.Point(253, 129);
            this.listBoxResultsBoys.Name = "listBoxResultsBoys";
            this.listBoxResultsBoys.Size = new System.Drawing.Size(170, 121);
            this.listBoxResultsBoys.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Startlist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(259, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Results";
            // 
            // listBoxRankBoys
            // 
            this.listBoxRankBoys.FormattingEnabled = true;
            this.listBoxRankBoys.Location = new System.Drawing.Point(440, 129);
            this.listBoxRankBoys.Name = "listBoxRankBoys";
            this.listBoxRankBoys.Size = new System.Drawing.Size(170, 121);
            this.listBoxRankBoys.TabIndex = 6;
            // 
            // buttonResultSort
            // 
            this.buttonResultSort.Location = new System.Drawing.Point(524, 91);
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
            this.label3.Location = new System.Drawing.Point(437, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(627, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Team rank";
            // 
            // listBoxTeamRank
            // 
            this.listBoxTeamRank.FormattingEnabled = true;
            this.listBoxTeamRank.Location = new System.Drawing.Point(630, 129);
            this.listBoxTeamRank.Name = "listBoxTeamRank";
            this.listBoxTeamRank.Size = new System.Drawing.Size(170, 251);
            this.listBoxTeamRank.TabIndex = 10;
            // 
            // listBoxGirls
            // 
            this.listBoxGirls.FormattingEnabled = true;
            this.listBoxGirls.Location = new System.Drawing.Point(12, 267);
            this.listBoxGirls.Name = "listBoxGirls";
            this.listBoxGirls.Size = new System.Drawing.Size(223, 121);
            this.listBoxGirls.TabIndex = 11;
            // 
            // listBoxResultsGirls
            // 
            this.listBoxResultsGirls.FormattingEnabled = true;
            this.listBoxResultsGirls.Location = new System.Drawing.Point(253, 267);
            this.listBoxResultsGirls.Name = "listBoxResultsGirls";
            this.listBoxResultsGirls.Size = new System.Drawing.Size(170, 121);
            this.listBoxResultsGirls.TabIndex = 12;
            // 
            // listBoxRankGirls
            // 
            this.listBoxRankGirls.FormattingEnabled = true;
            this.listBoxRankGirls.Location = new System.Drawing.Point(440, 267);
            this.listBoxRankGirls.Name = "listBoxRankGirls";
            this.listBoxRankGirls.Size = new System.Drawing.Size(170, 121);
            this.listBoxRankGirls.TabIndex = 13;
            // 
            // buttonTeamRank
            // 
            this.buttonTeamRank.Location = new System.Drawing.Point(725, 90);
            this.buttonTeamRank.Name = "buttonTeamRank";
            this.buttonTeamRank.Size = new System.Drawing.Size(75, 23);
            this.buttonTeamRank.TabIndex = 14;
            this.buttonTeamRank.Text = "Rank";
            this.buttonTeamRank.UseVisualStyleBackColor = true;
            this.buttonTeamRank.Click += new System.EventHandler(this.buttonTeamRank_Click);
            // 
            // FormSkiCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 474);
            this.Controls.Add(this.buttonTeamRank);
            this.Controls.Add(this.listBoxRankGirls);
            this.Controls.Add(this.listBoxResultsGirls);
            this.Controls.Add(this.listBoxGirls);
            this.Controls.Add(this.listBoxTeamRank);
            this.Controls.Add(this.buttonResultSort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxRankBoys);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonResults);
            this.Controls.Add(this.listBoxResultsBoys);
            this.Controls.Add(this.listBoxBoys);
            this.Name = "FormSkiCompetition";
            this.Text = "Competition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBoys;
        private System.Windows.Forms.Button buttonResults;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.ListBox listBoxResultsBoys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxRankBoys;
        private System.Windows.Forms.Button buttonResultSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxTeamRank;
        private System.Windows.Forms.ListBox listBoxGirls;
        private System.Windows.Forms.ListBox listBoxResultsGirls;
        private System.Windows.Forms.ListBox listBoxRankGirls;
        private System.Windows.Forms.Button buttonTeamRank;
    }
}

