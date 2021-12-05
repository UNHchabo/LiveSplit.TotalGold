namespace LiveSplit.UI.Components
{
    partial class TotalGoldSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topLevelLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chkTwoRows = new System.Windows.Forms.CheckBox();
            this.accuracyGroupBox = new System.Windows.Forms.GroupBox();
            this.decimalLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.rdoAccuracySeconds = new System.Windows.Forms.RadioButton();
            this.rdoAccuracyTenths = new System.Windows.Forms.RadioButton();
            this.rdoAccuracyHundredths = new System.Windows.Forms.RadioButton();
            this.topLevelLayoutPanel.SuspendLayout();
            this.accuracyGroupBox.SuspendLayout();
            this.decimalLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLevelLayoutPanel
            // 
            this.topLevelLayoutPanel.AutoSize = true;
            this.topLevelLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topLevelLayoutPanel.ColumnCount = 1;
            this.topLevelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.topLevelLayoutPanel.Controls.Add(this.chkTwoRows, 0, 0);
            this.topLevelLayoutPanel.Controls.Add(this.accuracyGroupBox, 0, 1);
            this.topLevelLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topLevelLayoutPanel.Name = "topLevelLayoutPanel";
            this.topLevelLayoutPanel.RowCount = 2;
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topLevelLayoutPanel.Size = new System.Drawing.Size(480, 96);
            this.topLevelLayoutPanel.TabIndex = 0;
            // 
            // chkTwoRows
            // 
            this.chkTwoRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTwoRows.AutoSize = true;
            this.chkTwoRows.Location = new System.Drawing.Point(3, 15);
            this.chkTwoRows.Name = "chkTwoRows";
            this.chkTwoRows.Size = new System.Drawing.Size(474, 17);
            this.chkTwoRows.TabIndex = 0;
            this.chkTwoRows.Text = "Display Two Rows";
            this.chkTwoRows.UseVisualStyleBackColor = true;
            // 
            // accuracyGroupBox
            // 
            this.accuracyGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accuracyGroupBox.AutoSize = true;
            this.accuracyGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.accuracyGroupBox.Controls.Add(this.decimalLayoutPanel);
            this.accuracyGroupBox.Location = new System.Drawing.Point(3, 51);
            this.accuracyGroupBox.Name = "accuracyGroupBox";
            this.accuracyGroupBox.Size = new System.Drawing.Size(474, 42);
            this.accuracyGroupBox.TabIndex = 1;
            this.accuracyGroupBox.TabStop = false;
            this.accuracyGroupBox.Text = "Accuracy";
            // 
            // decimalLayoutPanel
            // 
            this.decimalLayoutPanel.AutoSize = true;
            this.decimalLayoutPanel.ColumnCount = 3;
            this.decimalLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33371F));
            this.decimalLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33371F));
            this.decimalLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33258F));
            this.decimalLayoutPanel.Controls.Add(this.rdoAccuracySeconds, 0, 0);
            this.decimalLayoutPanel.Controls.Add(this.rdoAccuracyTenths, 1, 0);
            this.decimalLayoutPanel.Controls.Add(this.rdoAccuracyHundredths, 2, 0);
            this.decimalLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decimalLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.decimalLayoutPanel.Name = "decimalLayoutPanel";
            this.decimalLayoutPanel.RowCount = 1;
            this.decimalLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.decimalLayoutPanel.Size = new System.Drawing.Size(468, 23);
            this.decimalLayoutPanel.TabIndex = 0;
            // 
            // rdoAccuracySeconds
            // 
            this.rdoAccuracySeconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoAccuracySeconds.AutoSize = true;
            this.rdoAccuracySeconds.Location = new System.Drawing.Point(3, 3);
            this.rdoAccuracySeconds.MinimumSize = new System.Drawing.Size(150, 0);
            this.rdoAccuracySeconds.Name = "rdoAccuracySeconds";
            this.rdoAccuracySeconds.Size = new System.Drawing.Size(150, 17);
            this.rdoAccuracySeconds.TabIndex = 0;
            this.rdoAccuracySeconds.TabStop = true;
            this.rdoAccuracySeconds.Text = "Seconds";
            this.rdoAccuracySeconds.UseVisualStyleBackColor = true;
            this.rdoAccuracySeconds.CheckedChanged += new System.EventHandler(this.rdoAccuracySeconds_CheckedChanged);
            // 
            // rdoAccuracyTenths
            // 
            this.rdoAccuracyTenths.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoAccuracyTenths.AutoSize = true;
            this.rdoAccuracyTenths.Location = new System.Drawing.Point(159, 3);
            this.rdoAccuracyTenths.MinimumSize = new System.Drawing.Size(150, 0);
            this.rdoAccuracyTenths.Name = "rdoAccuracyTenths";
            this.rdoAccuracyTenths.Size = new System.Drawing.Size(150, 17);
            this.rdoAccuracyTenths.TabIndex = 1;
            this.rdoAccuracyTenths.TabStop = true;
            this.rdoAccuracyTenths.Text = "Tenths";
            this.rdoAccuracyTenths.UseVisualStyleBackColor = true;
            this.rdoAccuracyTenths.CheckedChanged += new System.EventHandler(this.rdoAccuracyTenths_CheckedChanged);
            // 
            // rdoAccuracyHundredths
            // 
            this.rdoAccuracyHundredths.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoAccuracyHundredths.AutoSize = true;
            this.rdoAccuracyHundredths.Location = new System.Drawing.Point(315, 3);
            this.rdoAccuracyHundredths.MinimumSize = new System.Drawing.Size(150, 0);
            this.rdoAccuracyHundredths.Name = "rdoAccuracyHundredths";
            this.rdoAccuracyHundredths.Size = new System.Drawing.Size(150, 17);
            this.rdoAccuracyHundredths.TabIndex = 2;
            this.rdoAccuracyHundredths.TabStop = true;
            this.rdoAccuracyHundredths.Text = "Hundredths";
            this.rdoAccuracyHundredths.UseVisualStyleBackColor = true;
            this.rdoAccuracyHundredths.CheckedChanged += new System.EventHandler(this.rdoAccuracyHundredths_CheckedChanged);
            // 
            // TotalGoldSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.topLevelLayoutPanel);
            this.Name = "TotalGoldSettings";
            this.Size = new System.Drawing.Size(483, 99);
            this.Load += new System.EventHandler(this.TotalGoldSettings_Load);
            this.topLevelLayoutPanel.ResumeLayout(false);
            this.topLevelLayoutPanel.PerformLayout();
            this.accuracyGroupBox.ResumeLayout(false);
            this.accuracyGroupBox.PerformLayout();
            this.decimalLayoutPanel.ResumeLayout(false);
            this.decimalLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel topLevelLayoutPanel;
        private System.Windows.Forms.CheckBox chkTwoRows;
        private System.Windows.Forms.GroupBox accuracyGroupBox;
        private System.Windows.Forms.TableLayoutPanel decimalLayoutPanel;
        private System.Windows.Forms.RadioButton rdoAccuracySeconds;
        private System.Windows.Forms.RadioButton rdoAccuracyTenths;
        private System.Windows.Forms.RadioButton rdoAccuracyHundredths;
    }
}
