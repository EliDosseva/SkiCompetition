
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
            this.labelMaleResults = new System.Windows.Forms.Label();
            this.dataGridViewFemale = new System.Windows.Forms.DataGridView();
            this.labelFemaleResults = new System.Windows.Forms.Label();
            this.listBoxRankMale = new System.Windows.Forms.ListBox();
            this.labelMaleRank = new System.Windows.Forms.Label();
            this.listBoxRankFemale = new System.Windows.Forms.ListBox();
            this.labelFemaleRank = new System.Windows.Forms.Label();
            this.buttonResultSort = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutMaleResults = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutMaleRank = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFemaleRusults = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelFemaleRank = new System.Windows.Forms.TableLayoutPanel();
            this.panelFormRank = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutMaleResults.SuspendLayout();
            this.tableLayoutMaleRank.SuspendLayout();
            this.tableLayoutPanelFemaleRusults.SuspendLayout();
            this.tableLayoutPanelFemaleRank.SuspendLayout();
            this.panelFormRank.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMale
            // 
            this.dataGridViewMale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMale.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewMale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMale.Location = new System.Drawing.Point(4, 79);
            this.dataGridViewMale.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMale.Name = "dataGridViewMale";
            this.dataGridViewMale.Size = new System.Drawing.Size(517, 163);
            this.dataGridViewMale.TabIndex = 19;
            // 
            // labelMaleResults
            // 
            this.labelMaleResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaleResults.AutoSize = true;
            this.labelMaleResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaleResults.Location = new System.Drawing.Point(4, 0);
            this.labelMaleResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaleResults.Name = "labelMaleResults";
            this.labelMaleResults.Size = new System.Drawing.Size(517, 75);
            this.labelMaleResults.TabIndex = 20;
            this.labelMaleResults.Text = "Men\'s results";
            this.labelMaleResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewFemale
            // 
            this.dataGridViewFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFemale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFemale.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewFemale.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewFemale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFemale.Location = new System.Drawing.Point(4, 71);
            this.dataGridViewFemale.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewFemale.Name = "dataGridViewFemale";
            this.dataGridViewFemale.Size = new System.Drawing.Size(513, 156);
            this.dataGridViewFemale.TabIndex = 21;
            // 
            // labelFemaleResults
            // 
            this.labelFemaleResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFemaleResults.AutoSize = true;
            this.labelFemaleResults.BackColor = System.Drawing.Color.Azure;
            this.labelFemaleResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFemaleResults.Location = new System.Drawing.Point(4, 0);
            this.labelFemaleResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFemaleResults.Name = "labelFemaleResults";
            this.labelFemaleResults.Size = new System.Drawing.Size(513, 67);
            this.labelFemaleResults.TabIndex = 22;
            this.labelFemaleResults.Text = "Women\'s results";
            this.labelFemaleResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxRankMale
            // 
            this.listBoxRankMale.BackColor = System.Drawing.Color.Azure;
            this.listBoxRankMale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRankMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxRankMale.FormattingEnabled = true;
            this.listBoxRankMale.ItemHeight = 18;
            this.listBoxRankMale.Location = new System.Drawing.Point(4, 80);
            this.listBoxRankMale.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxRankMale.Name = "listBoxRankMale";
            this.listBoxRankMale.Size = new System.Drawing.Size(467, 173);
            this.listBoxRankMale.TabIndex = 25;
            // 
            // labelMaleRank
            // 
            this.labelMaleRank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaleRank.AutoSize = true;
            this.labelMaleRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaleRank.Location = new System.Drawing.Point(4, 0);
            this.labelMaleRank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaleRank.Name = "labelMaleRank";
            this.labelMaleRank.Size = new System.Drawing.Size(467, 76);
            this.labelMaleRank.TabIndex = 26;
            this.labelMaleRank.Text = "Men\'s rank";
            this.labelMaleRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxRankFemale
            // 
            this.listBoxRankFemale.BackColor = System.Drawing.Color.Azure;
            this.listBoxRankFemale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRankFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxRankFemale.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxRankFemale.FormattingEnabled = true;
            this.listBoxRankFemale.ItemHeight = 18;
            this.listBoxRankFemale.Location = new System.Drawing.Point(4, 72);
            this.listBoxRankFemale.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxRankFemale.Name = "listBoxRankFemale";
            this.listBoxRankFemale.Size = new System.Drawing.Size(467, 166);
            this.listBoxRankFemale.TabIndex = 27;
            // 
            // labelFemaleRank
            // 
            this.labelFemaleRank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFemaleRank.AutoSize = true;
            this.labelFemaleRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFemaleRank.Location = new System.Drawing.Point(4, 0);
            this.labelFemaleRank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFemaleRank.Name = "labelFemaleRank";
            this.labelFemaleRank.Size = new System.Drawing.Size(467, 68);
            this.labelFemaleRank.TabIndex = 28;
            this.labelFemaleRank.Text = "Women\'s rank";
            this.labelFemaleRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonResultSort
            // 
            this.buttonResultSort.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonResultSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResultSort.Location = new System.Drawing.Point(505, 521);
            this.buttonResultSort.Margin = new System.Windows.Forms.Padding(4);
            this.buttonResultSort.Name = "buttonResultSort";
            this.buttonResultSort.Size = new System.Drawing.Size(113, 43);
            this.buttonResultSort.TabIndex = 29;
            this.buttonResultSort.Text = "Rank";
            this.buttonResultSort.UseVisualStyleBackColor = true;
            this.buttonResultSort.Click += new System.EventHandler(this.ButtonRankByAverageTime);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.Azure;
            this.splitContainer.Panel1.Controls.Add(this.tableLayoutMaleResults);
            this.splitContainer.Panel1.Controls.Add(this.tableLayoutMaleRank);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.Azure;
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanelFemaleRusults);
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanelFemaleRank);
            this.splitContainer.Size = new System.Drawing.Size(1071, 511);
            this.splitContainer.SplitterDistance = 257;
            this.splitContainer.SplitterWidth = 12;
            this.splitContainer.TabIndex = 3000;
            // 
            // tableLayoutMaleResults
            // 
            this.tableLayoutMaleResults.ColumnCount = 1;
            this.tableLayoutMaleResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMaleResults.Controls.Add(this.labelMaleResults, 0, 0);
            this.tableLayoutMaleResults.Controls.Add(this.dataGridViewMale, 0, 1);
            this.tableLayoutMaleResults.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutMaleResults.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMaleResults.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutMaleResults.Name = "tableLayoutMaleResults";
            this.tableLayoutMaleResults.RowCount = 3;
            this.tableLayoutMaleResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.67729F));
            this.tableLayoutMaleResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.32271F));
            this.tableLayoutMaleResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutMaleResults.Size = new System.Drawing.Size(525, 257);
            this.tableLayoutMaleResults.TabIndex = 23;
            // 
            // tableLayoutMaleRank
            // 
            this.tableLayoutMaleRank.ColumnCount = 1;
            this.tableLayoutMaleRank.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMaleRank.Controls.Add(this.listBoxRankMale, 0, 1);
            this.tableLayoutMaleRank.Controls.Add(this.labelMaleRank, 0, 0);
            this.tableLayoutMaleRank.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutMaleRank.Location = new System.Drawing.Point(596, 0);
            this.tableLayoutMaleRank.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutMaleRank.Name = "tableLayoutMaleRank";
            this.tableLayoutMaleRank.RowCount = 2;
            this.tableLayoutMaleRank.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.61539F));
            this.tableLayoutMaleRank.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.38461F));
            this.tableLayoutMaleRank.Size = new System.Drawing.Size(475, 257);
            this.tableLayoutMaleRank.TabIndex = 21;
            // 
            // tableLayoutPanelFemaleRusults
            // 
            this.tableLayoutPanelFemaleRusults.ColumnCount = 1;
            this.tableLayoutPanelFemaleRusults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFemaleRusults.Controls.Add(this.dataGridViewFemale, 0, 1);
            this.tableLayoutPanelFemaleRusults.Controls.Add(this.labelFemaleResults, 0, 0);
            this.tableLayoutPanelFemaleRusults.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanelFemaleRusults.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelFemaleRusults.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelFemaleRusults.Name = "tableLayoutPanelFemaleRusults";
            this.tableLayoutPanelFemaleRusults.RowCount = 3;
            this.tableLayoutPanelFemaleRusults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.23729F));
            this.tableLayoutPanelFemaleRusults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.76271F));
            this.tableLayoutPanelFemaleRusults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelFemaleRusults.Size = new System.Drawing.Size(521, 242);
            this.tableLayoutPanelFemaleRusults.TabIndex = 30;
            // 
            // tableLayoutPanelFemaleRank
            // 
            this.tableLayoutPanelFemaleRank.ColumnCount = 1;
            this.tableLayoutPanelFemaleRank.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFemaleRank.Controls.Add(this.listBoxRankFemale, 0, 1);
            this.tableLayoutPanelFemaleRank.Controls.Add(this.labelFemaleRank, 0, 0);
            this.tableLayoutPanelFemaleRank.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanelFemaleRank.Location = new System.Drawing.Point(596, 0);
            this.tableLayoutPanelFemaleRank.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelFemaleRank.Name = "tableLayoutPanelFemaleRank";
            this.tableLayoutPanelFemaleRank.RowCount = 2;
            this.tableLayoutPanelFemaleRank.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.16327F));
            this.tableLayoutPanelFemaleRank.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.83673F));
            this.tableLayoutPanelFemaleRank.Size = new System.Drawing.Size(475, 242);
            this.tableLayoutPanelFemaleRank.TabIndex = 29;
            // 
            // panelFormRank
            // 
            this.panelFormRank.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormRank.Controls.Add(this.buttonOK);
            this.panelFormRank.Controls.Add(this.buttonResultSort);
            this.panelFormRank.Controls.Add(this.splitContainer);
            this.panelFormRank.Location = new System.Drawing.Point(0, 5);
            this.panelFormRank.Margin = new System.Windows.Forms.Padding(4);
            this.panelFormRank.Name = "panelFormRank";
            this.panelFormRank.Size = new System.Drawing.Size(1075, 574);
            this.panelFormRank.TabIndex = 21;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonOK.Location = new System.Drawing.Point(954, 521);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonOK.Size = new System.Drawing.Size(113, 43);
            this.buttonOK.TabIndex = 31;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOKCloseForm_Click);
            // 
            // FormRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 583);
            this.Controls.Add(this.panelFormRank);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormRank";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.FormRank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemale)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutMaleResults.ResumeLayout(false);
            this.tableLayoutMaleResults.PerformLayout();
            this.tableLayoutMaleRank.ResumeLayout(false);
            this.tableLayoutMaleRank.PerformLayout();
            this.tableLayoutPanelFemaleRusults.ResumeLayout(false);
            this.tableLayoutPanelFemaleRusults.PerformLayout();
            this.tableLayoutPanelFemaleRank.ResumeLayout(false);
            this.tableLayoutPanelFemaleRank.PerformLayout();
            this.panelFormRank.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMale;
        private System.Windows.Forms.Label labelMaleResults;
        private System.Windows.Forms.DataGridView dataGridViewFemale;
        private System.Windows.Forms.Label labelFemaleResults;
        private System.Windows.Forms.ListBox listBoxRankMale;
        private System.Windows.Forms.Label labelMaleRank;
        private System.Windows.Forms.ListBox listBoxRankFemale;
        private System.Windows.Forms.Label labelFemaleRank;
        private System.Windows.Forms.Button buttonResultSort;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFemaleRusults;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFemaleRank;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMaleResults;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMaleRank;
        private System.Windows.Forms.Panel panelFormRank;
        private System.Windows.Forms.Button buttonOK;
    }
}