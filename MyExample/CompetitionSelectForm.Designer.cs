
namespace MyExample
{
    partial class CompetitionSelectForm
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
            this.listBoxCompetitions = new System.Windows.Forms.ListBox();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.dataGridViewMale = new System.Windows.Forms.DataGridView();
            this.dataGridViewFemale = new System.Windows.Forms.DataGridView();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewResultsFemale = new System.Windows.Forms.DataGridView();
            this.dataGridViewResultsMale = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultsFemale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultsMale)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCompetitions
            // 
            this.listBoxCompetitions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCompetitions.FormattingEnabled = true;
            this.listBoxCompetitions.Location = new System.Drawing.Point(0, 93);
            this.listBoxCompetitions.Name = "listBoxCompetitions";
            this.listBoxCompetitions.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxCompetitions.Size = new System.Drawing.Size(262, 212);
            this.listBoxCompetitions.TabIndex = 0;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(187, 317);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 1;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonGetBigFinalCompetitors);
            // 
            // dataGridViewMale
            // 
            this.dataGridViewMale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMale.Location = new System.Drawing.Point(288, 97);
            this.dataGridViewMale.Name = "dataGridViewMale";
            this.dataGridViewMale.Size = new System.Drawing.Size(240, 140);
            this.dataGridViewMale.TabIndex = 2;
            // 
            // dataGridViewFemale
            // 
            this.dataGridViewFemale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFemale.Location = new System.Drawing.Point(557, 97);
            this.dataGridViewFemale.Name = "dataGridViewFemale";
            this.dataGridViewFemale.Size = new System.Drawing.Size(240, 140);
            this.dataGridViewFemale.TabIndex = 3;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStart.Location = new System.Drawing.Point(480, 264);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(129, 35);
            this.ButtonStart.TabIndex = 4;
            this.ButtonStart.Text = "Start competition";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(439, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Qualifiers for the Big Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(384, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Male";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(657, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Female";
            // 
            // dataGridViewResultsFemale
            // 
            this.dataGridViewResultsFemale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultsFemale.Location = new System.Drawing.Point(557, 317);
            this.dataGridViewResultsFemale.Name = "dataGridViewResultsFemale";
            this.dataGridViewResultsFemale.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewResultsFemale.TabIndex = 8;
            // 
            // dataGridViewResultsMale
            // 
            this.dataGridViewResultsMale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultsMale.Location = new System.Drawing.Point(288, 317);
            this.dataGridViewResultsMale.Name = "dataGridViewResultsMale";
            this.dataGridViewResultsMale.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewResultsMale.TabIndex = 9;
            // 
            // CompetitionSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 490);
            this.Controls.Add(this.dataGridViewResultsMale);
            this.Controls.Add(this.dataGridViewResultsFemale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.dataGridViewFemale);
            this.Controls.Add(this.dataGridViewMale);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.listBoxCompetitions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CompetitionSelectForm";
            this.Text = "CompetitionSelectForm";
            this.Load += new System.EventHandler(this.CompetitionSelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultsFemale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultsMale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCompetitions;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.DataGridView dataGridViewMale;
        private System.Windows.Forms.DataGridView dataGridViewFemale;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewResultsFemale;
        private System.Windows.Forms.DataGridView dataGridViewResultsMale;
    }
}