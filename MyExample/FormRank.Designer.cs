
namespace MyExample
{
    partial class FormRank
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
            this.dataGridViewMale = new System.Windows.Forms.DataGridView();
            this.Results = new System.Windows.Forms.Label();
            this.dataGridViewFemale = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxRankMale = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxRankFemale = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonResultSort = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutMaleResults = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutMaleRank = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFemaleRusults = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFemaleRank = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutMaleResults.SuspendLayout();
            this.tableLayoutMaleRank.SuspendLayout();
            this.tableLayoutPanelFemaleRusults.SuspendLayout();
            this.tableLayoutPanelFemaleRank.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMale
            // 
            this.dataGridViewMale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMale.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridViewMale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMale.Location = new System.Drawing.Point(3, 79);
            this.dataGridViewMale.Name = "dataGridViewMale";
            this.dataGridViewMale.Size = new System.Drawing.Size(388, 169);
            this.dataGridViewMale.TabIndex = 19;
            // 
            // Results
            // 
            this.Results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Results.AutoSize = true;
            this.Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Results.Location = new System.Drawing.Point(3, 0);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(388, 76);
            this.Results.TabIndex = 20;
            this.Results.Text = "Male results";
            this.Results.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewFemale
            // 
            this.dataGridViewFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFemale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFemale.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewFemale.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.dataGridViewFemale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFemale.Location = new System.Drawing.Point(3, 69);
            this.dataGridViewFemale.Name = "dataGridViewFemale";
            this.dataGridViewFemale.Size = new System.Drawing.Size(391, 164);
            this.dataGridViewFemale.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 66);
            this.label2.TabIndex = 22;
            this.label2.Text = "Female results";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxRankMale
            // 
            this.listBoxRankMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listBoxRankMale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRankMale.FormattingEnabled = true;
            this.listBoxRankMale.Location = new System.Drawing.Point(3, 93);
            this.listBoxRankMale.Name = "listBoxRankMale";
            this.listBoxRankMale.Size = new System.Drawing.Size(373, 164);
            this.listBoxRankMale.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 90);
            this.label3.TabIndex = 26;
            this.label3.Text = "Male rank";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxRankFemale
            // 
            this.listBoxRankFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.listBoxRankFemale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRankFemale.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxRankFemale.FormattingEnabled = true;
            this.listBoxRankFemale.Location = new System.Drawing.Point(3, 73);
            this.listBoxRankFemale.Name = "listBoxRankFemale";
            this.listBoxRankFemale.Size = new System.Drawing.Size(380, 169);
            this.listBoxRankFemale.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(380, 70);
            this.label5.TabIndex = 28;
            this.label5.Text = "Female rank";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonResultSort
            // 
            this.buttonResultSort.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonResultSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResultSort.Location = new System.Drawing.Point(390, 523);
            this.buttonResultSort.Name = "buttonResultSort";
            this.buttonResultSort.Size = new System.Drawing.Size(107, 35);
            this.buttonResultSort.TabIndex = 29;
            this.buttonResultSort.Text = "Rank";
            this.buttonResultSort.UseVisualStyleBackColor = true;
            this.buttonResultSort.Click += new System.EventHandler(this.ButtonRankByAverageTime);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutMaleResults);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutMaleRank);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(240)))));
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanelFemaleRusults);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanelFemaleRank);
            this.splitContainer1.Size = new System.Drawing.Size(871, 515);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 3000;
            // 
            // tableLayoutMaleResults
            // 
            this.tableLayoutMaleResults.ColumnCount = 1;
            this.tableLayoutMaleResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMaleResults.Controls.Add(this.Results, 0, 0);
            this.tableLayoutMaleResults.Controls.Add(this.dataGridViewMale, 0, 1);
            this.tableLayoutMaleResults.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutMaleResults.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMaleResults.Name = "tableLayoutMaleResults";
            this.tableLayoutMaleResults.RowCount = 3;
            this.tableLayoutMaleResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.34483F));
            this.tableLayoutMaleResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.65517F));
            this.tableLayoutMaleResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutMaleResults.Size = new System.Drawing.Size(394, 260);
            this.tableLayoutMaleResults.TabIndex = 23;
            // 
            // tableLayoutMaleRank
            // 
            this.tableLayoutMaleRank.ColumnCount = 1;
            this.tableLayoutMaleRank.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMaleRank.Controls.Add(this.listBoxRankMale, 0, 1);
            this.tableLayoutMaleRank.Controls.Add(this.label3, 0, 0);
            this.tableLayoutMaleRank.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutMaleRank.Location = new System.Drawing.Point(492, 0);
            this.tableLayoutMaleRank.Name = "tableLayoutMaleRank";
            this.tableLayoutMaleRank.RowCount = 2;
            this.tableLayoutMaleRank.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.81482F));
            this.tableLayoutMaleRank.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.18519F));
            this.tableLayoutMaleRank.Size = new System.Drawing.Size(379, 260);
            this.tableLayoutMaleRank.TabIndex = 21;
            // 
            // tableLayoutPanelFemaleRusults
            // 
            this.tableLayoutPanelFemaleRusults.ColumnCount = 1;
            this.tableLayoutPanelFemaleRusults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFemaleRusults.Controls.Add(this.dataGridViewFemale, 0, 1);
            this.tableLayoutPanelFemaleRusults.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanelFemaleRusults.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanelFemaleRusults.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelFemaleRusults.Name = "tableLayoutPanelFemaleRusults";
            this.tableLayoutPanelFemaleRusults.RowCount = 3;
            this.tableLayoutPanelFemaleRusults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanelFemaleRusults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanelFemaleRusults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanelFemaleRusults.Size = new System.Drawing.Size(397, 245);
            this.tableLayoutPanelFemaleRusults.TabIndex = 30;
            // 
            // tableLayoutPanelFemaleRank
            // 
            this.tableLayoutPanelFemaleRank.ColumnCount = 1;
            this.tableLayoutPanelFemaleRank.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFemaleRank.Controls.Add(this.listBoxRankFemale, 0, 1);
            this.tableLayoutPanelFemaleRank.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanelFemaleRank.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanelFemaleRank.Location = new System.Drawing.Point(485, 0);
            this.tableLayoutPanelFemaleRank.Name = "tableLayoutPanelFemaleRank";
            this.tableLayoutPanelFemaleRank.RowCount = 2;
            this.tableLayoutPanelFemaleRank.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.7037F));
            this.tableLayoutPanelFemaleRank.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.2963F));
            this.tableLayoutPanelFemaleRank.Size = new System.Drawing.Size(386, 245);
            this.tableLayoutPanelFemaleRank.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.buttonResultSort);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 566);
            this.panel1.TabIndex = 21;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonOK.Location = new System.Drawing.Point(780, 521);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonOK.Size = new System.Drawing.Size(85, 35);
            this.buttonOK.TabIndex = 31;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 574);
            this.Controls.Add(this.panel1);
            this.Name = "FormRank";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.FormRank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemale)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutMaleResults.ResumeLayout(false);
            this.tableLayoutMaleResults.PerformLayout();
            this.tableLayoutMaleRank.ResumeLayout(false);
            this.tableLayoutMaleRank.PerformLayout();
            this.tableLayoutPanelFemaleRusults.ResumeLayout(false);
            this.tableLayoutPanelFemaleRusults.PerformLayout();
            this.tableLayoutPanelFemaleRank.ResumeLayout(false);
            this.tableLayoutPanelFemaleRank.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMale;
        private System.Windows.Forms.Label Results;
        private System.Windows.Forms.DataGridView dataGridViewFemale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxRankMale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxRankFemale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonResultSort;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFemaleRusults;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFemaleRank;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMaleResults;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMaleRank;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOK;
    }
}