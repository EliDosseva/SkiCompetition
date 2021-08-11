
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
            this.labelFinalHeader = new System.Windows.Forms.Label();
            this.labelMale = new System.Windows.Forms.Label();
            this.labelFemale = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemaleResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaleResults)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFemaleResults
            // 
            this.dataGridViewFemaleResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFemaleResults.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFemaleResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFemaleResults.Location = new System.Drawing.Point(415, 59);
            this.dataGridViewFemaleResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewFemaleResults.Name = "dataGridViewFemaleResults";
            this.dataGridViewFemaleResults.Size = new System.Drawing.Size(404, 262);
            this.dataGridViewFemaleResults.TabIndex = 0;
            // 
            // dataGridViewMaleResults
            // 
            this.dataGridViewMaleResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMaleResults.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMaleResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaleResults.Location = new System.Drawing.Point(4, 59);
            this.dataGridViewMaleResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMaleResults.Name = "dataGridViewMaleResults";
            this.dataGridViewMaleResults.Size = new System.Drawing.Size(403, 262);
            this.dataGridViewMaleResults.TabIndex = 1;
            // 
            // labelFinalHeader
            // 
            this.labelFinalHeader.AutoSize = true;
            this.labelFinalHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinalHeader.Location = new System.Drawing.Point(355, 23);
            this.labelFinalHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFinalHeader.Name = "labelFinalHeader";
            this.labelFinalHeader.Size = new System.Drawing.Size(175, 24);
            this.labelFinalHeader.TabIndex = 2;
            this.labelFinalHeader.Text = "Big Final Winners";
            // 
            // labelMale
            // 
            this.labelMale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMale.AutoSize = true;
            this.labelMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMale.Location = new System.Drawing.Point(180, 17);
            this.labelMale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(51, 20);
            this.labelMale.TabIndex = 3;
            this.labelMale.Text = "Men\'s";
            // 
            // labelFemale
            // 
            this.labelFemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFemale.AutoSize = true;
            this.labelFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFemale.Location = new System.Drawing.Point(579, 17);
            this.labelFemale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFemale.Name = "labelFemale";
            this.labelFemale.Size = new System.Drawing.Size(75, 20);
            this.labelFemale.TabIndex = 4;
            this.labelFemale.Text = "Women\'s";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelFemale, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelMale, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewMaleResults, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewFemaleResults, 1, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(59, 57);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.04545F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.95454F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(823, 325);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // BigFinalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(935, 409);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelFinalHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BigFinalForm";
            this.Text = "BigFinalResults";
            this.Load += new System.EventHandler(this.BigFinalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemaleResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaleResults)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFemaleResults;
        private System.Windows.Forms.DataGridView dataGridViewMaleResults;
        private System.Windows.Forms.Label labelFinalHeader;
        private System.Windows.Forms.Label labelMale;
        private System.Windows.Forms.Label labelFemale;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}