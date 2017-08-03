namespace RegexDemo
{
    partial class RegexTestForm
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
            this.chkSingleLine = new System.Windows.Forms.CheckBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkIgnoreCase = new System.Windows.Forms.CheckBox();
            this.chkAsYouType = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radDummy = new System.Windows.Forms.RadioButton();
            this.radNumFmt = new System.Windows.Forms.RadioButton();
            this.radRegex = new System.Windows.Forms.RadioButton();
            this.radDates = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkSingleLine
            // 
            this.chkSingleLine.Location = new System.Drawing.Point(144, 105);
            this.chkSingleLine.Name = "chkSingleLine";
            this.chkSingleLine.Size = new System.Drawing.Size(88, 24);
            this.chkSingleLine.TabIndex = 19;
            this.chkSingleLine.Text = "single line";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(237, 155);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(64, 48);
            this.btnTest.TabIndex = 16;
            this.btnTest.Text = "Test";
            this.btnTest.Click += new System.EventHandler(this.regexCheck_Click);
            // 
            // txtResults
            // 
            this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResults.Location = new System.Drawing.Point(0, 209);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(302, 332);
            this.txtResults.TabIndex = 13;
            // 
            // txtPattern
            // 
            this.txtPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPattern.Location = new System.Drawing.Point(0, 129);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(302, 20);
            this.txtPattern.TabIndex = 12;
            this.txtPattern.Text = "^([-]?\\d+)([ymad]?)$";
            this.txtPattern.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Location = new System.Drawing.Point(0, 26);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(302, 71);
            this.txtText.TabIndex = 11;
            this.txtText.Text = "-10y";
            this.txtText.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pattern";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Text";
            // 
            // chkIgnoreCase
            // 
            this.chkIgnoreCase.Location = new System.Drawing.Point(62, 103);
            this.chkIgnoreCase.Name = "chkIgnoreCase";
            this.chkIgnoreCase.Size = new System.Drawing.Size(88, 24);
            this.chkIgnoreCase.TabIndex = 18;
            this.chkIgnoreCase.Text = "Ignore case";
            // 
            // chkAsYouType
            // 
            this.chkAsYouType.Location = new System.Drawing.Point(223, 103);
            this.chkAsYouType.Name = "chkAsYouType";
            this.chkAsYouType.Size = new System.Drawing.Size(78, 24);
            this.chkAsYouType.TabIndex = 21;
            this.chkAsYouType.Text = "real time";
            this.chkAsYouType.CheckedChanged += new System.EventHandler(this.chkAsYouType_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radDates);
            this.panel1.Controls.Add(this.radDummy);
            this.panel1.Controls.Add(this.radNumFmt);
            this.panel1.Controls.Add(this.radRegex);
            this.panel1.Location = new System.Drawing.Point(12, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 46);
            this.panel1.TabIndex = 22;
            // 
            // radDummy
            // 
            this.radDummy.AutoSize = true;
            this.radDummy.Location = new System.Drawing.Point(211, 3);
            this.radDummy.Name = "radDummy";
            this.radDummy.Size = new System.Drawing.Size(60, 17);
            this.radDummy.TabIndex = 2;
            this.radDummy.Text = "Dummy";
            this.radDummy.UseVisualStyleBackColor = true;
            this.radDummy.Visible = false;
            // 
            // radNumFmt
            // 
            this.radNumFmt.AutoSize = true;
            this.radNumFmt.Location = new System.Drawing.Point(3, 26);
            this.radNumFmt.Name = "radNumFmt";
            this.radNumFmt.Size = new System.Drawing.Size(67, 17);
            this.radNumFmt.TabIndex = 1;
            this.radNumFmt.Text = "Numbers";
            this.radNumFmt.UseVisualStyleBackColor = true;
            this.radNumFmt.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radRegex
            // 
            this.radRegex.AutoSize = true;
            this.radRegex.Location = new System.Drawing.Point(3, 3);
            this.radRegex.Name = "radRegex";
            this.radRegex.Size = new System.Drawing.Size(56, 17);
            this.radRegex.TabIndex = 0;
            this.radRegex.Text = "Regex";
            this.radRegex.UseVisualStyleBackColor = true;
            this.radRegex.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radDates
            // 
            this.radDates.AutoSize = true;
            this.radDates.Location = new System.Drawing.Point(89, 3);
            this.radDates.Name = "radDates";
            this.radDates.Size = new System.Drawing.Size(53, 17);
            this.radDates.TabIndex = 3;
            this.radDates.Text = "Dates";
            this.radDates.UseVisualStyleBackColor = true;
            this.radDates.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // RegexTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkAsYouType);
            this.Controls.Add(this.chkSingleLine);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkIgnoreCase);
            this.Name = "RegexTestForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSingleLine;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkIgnoreCase;
        private System.Windows.Forms.CheckBox chkAsYouType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radNumFmt;
        private System.Windows.Forms.RadioButton radRegex;
        private System.Windows.Forms.RadioButton radDummy;
        private System.Windows.Forms.RadioButton radDates;
    }
}