
namespace MyExample
{
    partial class FrmCompetitionSelect
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
            this.ButtonCompetitions = new System.Windows.Forms.Button();
            this.dataGridViewFemale = new System.Windows.Forms.DataGridView();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.labelQualifiersHeader = new System.Windows.Forms.Label();
            this.labelFemale = new System.Windows.Forms.Label();
            this.tableLayoutPanelQualifiers = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewMale = new System.Windows.Forms.DataGridView();
            this.labelMale = new System.Windows.Forms.Label();
            this.buttonOKCloseForm = new System.Windows.Forms.Button();
            this.panelCompetitionSelectForm = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelListBoxCompetitions = new System.Windows.Forms.TableLayoutPanel();
            this.labelSelectCompetitions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemale)).BeginInit();
            this.tableLayoutPanelQualifiers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMale)).BeginInit();
            this.panelCompetitionSelectForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutPanelListBoxCompetitions.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCompetitions
            // 
            this.listBoxCompetitions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBoxCompetitions.BackColor = System.Drawing.Color.Azure;
            this.listBoxCompetitions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxCompetitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxCompetitions.FormattingEnabled = true;
            this.listBoxCompetitions.ItemHeight = 20;
            this.listBoxCompetitions.Location = new System.Drawing.Point(3, 69);
            this.listBoxCompetitions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxCompetitions.Name = "listBoxCompetitions";
            this.listBoxCompetitions.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxCompetitions.Size = new System.Drawing.Size(386, 402);
            this.listBoxCompetitions.TabIndex = 0;
            // 
            // ButtonCompetitions
            // 
            this.ButtonCompetitions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCompetitions.Location = new System.Drawing.Point(291, 485);
            this.ButtonCompetitions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonCompetitions.Name = "ButtonCompetitions";
            this.ButtonCompetitions.Size = new System.Drawing.Size(98, 34);
            this.ButtonCompetitions.TabIndex = 1;
            this.ButtonCompetitions.Text = "OK";
            this.ButtonCompetitions.UseVisualStyleBackColor = true;
            this.ButtonCompetitions.Click += new System.EventHandler(this.ButtonGetBigFinalCompetitors);
            // 
            // dataGridViewFemale
            // 
            this.dataGridViewFemale.AllowUserToAddRows = false;
            this.dataGridViewFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFemale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFemale.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewFemale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFemale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFemale.Location = new System.Drawing.Point(466, 72);
            this.dataGridViewFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewFemale.Name = "dataGridViewFemale";
            this.dataGridViewFemale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFemale.Size = new System.Drawing.Size(451, 323);
            this.dataGridViewFemale.TabIndex = 3;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStart.Location = new System.Drawing.Point(756, 485);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(170, 34);
            this.ButtonStart.TabIndex = 4;
            this.ButtonStart.Text = "Start competition";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // labelQualifiersHeader
            // 
            this.labelQualifiersHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelQualifiersHeader.AutoSize = true;
            this.labelQualifiersHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQualifiersHeader.Location = new System.Drawing.Point(358, 24);
            this.labelQualifiersHeader.Name = "labelQualifiersHeader";
            this.labelQualifiersHeader.Size = new System.Drawing.Size(218, 20);
            this.labelQualifiersHeader.TabIndex = 5;
            this.labelQualifiersHeader.Text = "Qualifiers for the Big Final";
            // 
            // labelFemale
            // 
            this.labelFemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFemale.AutoSize = true;
            this.labelFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFemale.Location = new System.Drawing.Point(659, 24);
            this.labelFemale.Name = "labelFemale";
            this.labelFemale.Size = new System.Drawing.Size(64, 20);
            this.labelFemale.TabIndex = 7;
            this.labelFemale.Text = "Women";
            // 
            // tableLayoutPanelQualifiers
            // 
            this.tableLayoutPanelQualifiers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelQualifiers.BackColor = System.Drawing.Color.Azure;
            this.tableLayoutPanelQualifiers.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanelQualifiers.ColumnCount = 2;
            this.tableLayoutPanelQualifiers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelQualifiers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelQualifiers.Controls.Add(this.labelFemale, 1, 0);
            this.tableLayoutPanelQualifiers.Controls.Add(this.dataGridViewFemale, 1, 1);
            this.tableLayoutPanelQualifiers.Controls.Add(this.dataGridViewMale, 0, 1);
            this.tableLayoutPanelQualifiers.Controls.Add(this.labelMale, 0, 0);
            this.tableLayoutPanelQualifiers.Location = new System.Drawing.Point(3, 69);
            this.tableLayoutPanelQualifiers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelQualifiers.Name = "tableLayoutPanelQualifiers";
            this.tableLayoutPanelQualifiers.RowCount = 2;
            this.tableLayoutPanelQualifiers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanelQualifiers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanelQualifiers.Size = new System.Drawing.Size(923, 402);
            this.tableLayoutPanelQualifiers.TabIndex = 8;
            // 
            // dataGridViewMale
            // 
            this.dataGridViewMale.AllowUserToAddRows = false;
            this.dataGridViewMale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMale.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewMale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMale.Location = new System.Drawing.Point(6, 72);
            this.dataGridViewMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewMale.Name = "dataGridViewMale";
            this.dataGridViewMale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMale.Size = new System.Drawing.Size(451, 323);
            this.dataGridViewMale.TabIndex = 2;
            // 
            // labelMale
            // 
            this.labelMale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMale.AutoSize = true;
            this.labelMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMale.Location = new System.Drawing.Point(211, 24);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(40, 20);
            this.labelMale.TabIndex = 6;
            this.labelMale.Text = "Men";
            // 
            // buttonOKCloseForm
            // 
            this.buttonOKCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOKCloseForm.Location = new System.Drawing.Point(1255, 549);
            this.buttonOKCloseForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOKCloseForm.Name = "buttonOKCloseForm";
            this.buttonOKCloseForm.Size = new System.Drawing.Size(98, 28);
            this.buttonOKCloseForm.TabIndex = 2;
            this.buttonOKCloseForm.Text = "OK";
            this.buttonOKCloseForm.UseVisualStyleBackColor = true;
            this.buttonOKCloseForm.Click += new System.EventHandler(this.ButtonOKCloseForm_Click);
            // 
            // panelCompetitionSelectForm
            // 
            this.panelCompetitionSelectForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCompetitionSelectForm.BackColor = System.Drawing.Color.White;
            this.panelCompetitionSelectForm.Controls.Add(this.splitContainer);
            this.panelCompetitionSelectForm.Controls.Add(this.buttonOKCloseForm);
            this.panelCompetitionSelectForm.Location = new System.Drawing.Point(2, 6);
            this.panelCompetitionSelectForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCompetitionSelectForm.Name = "panelCompetitionSelectForm";
            this.panelCompetitionSelectForm.Size = new System.Drawing.Size(1359, 588);
            this.panelCompetitionSelectForm.TabIndex = 10;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(-19, 4);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tableLayoutPanelListBoxCompetitions);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.Azure;
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanelQualifiers);
            this.splitContainer.Panel2.Controls.Add(this.ButtonStart);
            this.splitContainer.Panel2.Controls.Add(this.labelQualifiersHeader);
            this.splitContainer.Size = new System.Drawing.Size(1375, 523);
            this.splitContainer.SplitterDistance = 420;
            this.splitContainer.SplitterWidth = 7;
            this.splitContainer.TabIndex = 9;
            // 
            // tableLayoutPanelListBoxCompetitions
            // 
            this.tableLayoutPanelListBoxCompetitions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelListBoxCompetitions.BackColor = System.Drawing.Color.Azure;
            this.tableLayoutPanelListBoxCompetitions.ColumnCount = 1;
            this.tableLayoutPanelListBoxCompetitions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelListBoxCompetitions.Controls.Add(this.listBoxCompetitions, 0, 1);
            this.tableLayoutPanelListBoxCompetitions.Controls.Add(this.ButtonCompetitions, 0, 2);
            this.tableLayoutPanelListBoxCompetitions.Controls.Add(this.labelSelectCompetitions, 0, 0);
            this.tableLayoutPanelListBoxCompetitions.Location = new System.Drawing.Point(25, 0);
            this.tableLayoutPanelListBoxCompetitions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanelListBoxCompetitions.Name = "tableLayoutPanelListBoxCompetitions";
            this.tableLayoutPanelListBoxCompetitions.RowCount = 3;
            this.tableLayoutPanelListBoxCompetitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.74046F));
            this.tableLayoutPanelListBoxCompetitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.25954F));
            this.tableLayoutPanelListBoxCompetitions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanelListBoxCompetitions.Size = new System.Drawing.Size(392, 523);
            this.tableLayoutPanelListBoxCompetitions.TabIndex = 3;
            // 
            // labelSelectCompetitions
            // 
            this.labelSelectCompetitions.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSelectCompetitions.AutoSize = true;
            this.labelSelectCompetitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectCompetitions.Location = new System.Drawing.Point(3, 23);
            this.labelSelectCompetitions.Name = "labelSelectCompetitions";
            this.labelSelectCompetitions.Size = new System.Drawing.Size(347, 18);
            this.labelSelectCompetitions.TabIndex = 2;
            this.labelSelectCompetitions.Text = "Select competitions for the Final  from the list below";
            // 
            // CompetitionSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1363, 596);
            this.Controls.Add(this.panelCompetitionSelectForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CompetitionSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Competitions selector";
            this.Load += new System.EventHandler(this.CompetitionSelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFemale)).EndInit();
            this.tableLayoutPanelQualifiers.ResumeLayout(false);
            this.tableLayoutPanelQualifiers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMale)).EndInit();
            this.panelCompetitionSelectForm.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanelListBoxCompetitions.ResumeLayout(false);
            this.tableLayoutPanelListBoxCompetitions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCompetitions;
        private System.Windows.Forms.Button ButtonCompetitions;
        private System.Windows.Forms.DataGridView dataGridViewFemale;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label labelQualifiersHeader;
        private System.Windows.Forms.Label labelFemale;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelQualifiers;
        private System.Windows.Forms.DataGridView dataGridViewMale;
        private System.Windows.Forms.Label labelMale;
        private System.Windows.Forms.Button buttonOKCloseForm;
        private System.Windows.Forms.Panel panelCompetitionSelectForm;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelListBoxCompetitions;
        private System.Windows.Forms.Label labelSelectCompetitions;
    }
}