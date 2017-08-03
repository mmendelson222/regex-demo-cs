namespace RegexDemo
{
    partial class Form1
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
            this.txtText = new System.Windows.Forms.TextBox();
            this.chkAsYouType = new System.Windows.Forms.CheckBox();
            this.chkSingleLine = new System.Windows.Forms.CheckBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.chkIgnoreCase = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDates = new System.Windows.Forms.RadioButton();
            this.radDummy = new System.Windows.Forms.RadioButton();
            this.radNumFmt = new System.Windows.Forms.RadioButton();
            this.radRegex = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(12, 12);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(693, 71);
            this.txtText.TabIndex = 12;
            this.txtText.Text = "-10y";
            // 
            // chkAsYouType
            // 
            this.chkAsYouType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAsYouType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAsYouType.Location = new System.Drawing.Point(524, 141);
            this.chkAsYouType.Name = "chkAsYouType";
            this.chkAsYouType.Size = new System.Drawing.Size(95, 24);
            this.chkAsYouType.TabIndex = 29;
            this.chkAsYouType.Text = "real time";
            this.chkAsYouType.CheckedChanged += new System.EventHandler(this.chkRealTime_CheckedChanged);
            // 
            // chkSingleLine
            // 
            this.chkSingleLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSingleLine.Location = new System.Drawing.Point(137, 19);
            this.chkSingleLine.Name = "chkSingleLine";
            this.chkSingleLine.Size = new System.Drawing.Size(106, 24);
            this.chkSingleLine.TabIndex = 28;
            this.chkSingleLine.Text = "single line";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(637, 127);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(64, 93);
            this.btnTest.TabIndex = 26;
            this.btnTest.Text = "Test";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtResults
            // 
            this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResults.Location = new System.Drawing.Point(12, 226);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(693, 347);
            this.txtResults.TabIndex = 24;
            // 
            // txtPattern
            // 
            this.txtPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPattern.Location = new System.Drawing.Point(12, 90);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(693, 26);
            this.txtPattern.TabIndex = 23;
            this.txtPattern.Text = "^([-]?\\d+)([ymad]?)$";
            this.txtPattern.TextChanged += new System.EventHandler(this.txtPattern_TextChanged);
            // 
            // chkIgnoreCase
            // 
            this.chkIgnoreCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIgnoreCase.Location = new System.Drawing.Point(19, 19);
            this.chkIgnoreCase.Name = "chkIgnoreCase";
            this.chkIgnoreCase.Size = new System.Drawing.Size(112, 24);
            this.chkIgnoreCase.TabIndex = 27;
            this.chkIgnoreCase.Text = "Ignore case";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDates);
            this.groupBox1.Controls.Add(this.radDummy);
            this.groupBox1.Controls.Add(this.radNumFmt);
            this.groupBox1.Controls.Add(this.radRegex);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 45);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // radDates
            // 
            this.radDates.AutoSize = true;
            this.radDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDates.Location = new System.Drawing.Point(94, 17);
            this.radDates.Name = "radDates";
            this.radDates.Size = new System.Drawing.Size(70, 24);
            this.radDates.TabIndex = 7;
            this.radDates.Text = "Dates";
            this.radDates.UseVisualStyleBackColor = true;
            this.radDates.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radDummy
            // 
            this.radDummy.AutoSize = true;
            this.radDummy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDummy.Location = new System.Drawing.Point(274, 17);
            this.radDummy.Name = "radDummy";
            this.radDummy.Size = new System.Drawing.Size(83, 24);
            this.radDummy.TabIndex = 6;
            this.radDummy.Text = "Invisible";
            this.radDummy.UseVisualStyleBackColor = true;
            this.radDummy.Visible = false;
            this.radDummy.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radNumFmt
            // 
            this.radNumFmt.AutoSize = true;
            this.radNumFmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNumFmt.Location = new System.Drawing.Point(170, 17);
            this.radNumFmt.Name = "radNumFmt";
            this.radNumFmt.Size = new System.Drawing.Size(91, 24);
            this.radNumFmt.TabIndex = 5;
            this.radNumFmt.Text = "Numbers";
            this.radNumFmt.UseVisualStyleBackColor = true;
            this.radNumFmt.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radRegex
            // 
            this.radRegex.AutoSize = true;
            this.radRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRegex.Location = new System.Drawing.Point(16, 17);
            this.radRegex.Name = "radRegex";
            this.radRegex.Size = new System.Drawing.Size(73, 24);
            this.radRegex.TabIndex = 4;
            this.radRegex.Text = "Regex";
            this.radRegex.UseVisualStyleBackColor = true;
            this.radRegex.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkIgnoreCase);
            this.groupBox2.Controls.Add(this.chkSingleLine);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 50);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pattern Properties";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 596);
            this.Controls.Add(this.chkAsYouType);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.txtText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.CheckBox chkAsYouType;
        private System.Windows.Forms.CheckBox chkSingleLine;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.CheckBox chkIgnoreCase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDates;
        private System.Windows.Forms.RadioButton radDummy;
        private System.Windows.Forms.RadioButton radNumFmt;
        private System.Windows.Forms.RadioButton radRegex;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}