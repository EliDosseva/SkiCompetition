
namespace MyExample
{
    partial class BigFinalForm
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
            this.dataGridViewFemaleResults = new System.Windows.Forms.DataGridView();
            this.dataGridViewMaleResults = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemaleResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaleResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFemaleResults
            // 
            this.dataGridViewFemaleResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFemaleResults.Location = new System.Drawing.Point(47, 82);
            this.dataGridViewFemaleResults.Name = "dataGridViewFemaleResults";
            this.dataGridViewFemaleResults.Size = new System.Drawing.Size(254, 139);
            this.dataGridViewFemaleResults.TabIndex = 0;
            // 
            // dataGridViewMaleResults
            // 
            this.dataGridViewMaleResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaleResults.Location = new System.Drawing.Point(360, 82);
            this.dataGridViewMaleResults.Name = "dataGridViewMaleResults";
            this.dataGridViewMaleResults.Size = new System.Drawing.Size(247, 139);
            this.dataGridViewMaleResults.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(243, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Big Final Winners";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(135, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Female";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(476, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Male";
            // 
            // BigFinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 296);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMaleResults);
            this.Controls.Add(this.dataGridViewFemaleResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BigFinalForm";
            this.Text = "BigFinalResults";
            this.Load += new System.EventHandler(this.BigFinalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemaleResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaleResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFemaleResults;
        private System.Windows.Forms.DataGridView dataGridViewMaleResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}