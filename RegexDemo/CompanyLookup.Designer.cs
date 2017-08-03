namespace RegexDemo
{
	partial class CompanyLookup
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
			this.txtPattern = new System.Windows.Forms.TextBox();
			this.rtxResults = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// txtPattern
			// 
			this.txtPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtPattern.Location = new System.Drawing.Point(12, 12);
			this.txtPattern.Name = "txtPattern";
			this.txtPattern.Size = new System.Drawing.Size(413, 20);
			this.txtPattern.TabIndex = 2;
			this.txtPattern.TextChanged += new System.EventHandler(this.txtText_TextChanged);
			// 
			// rtxResults
			// 
			this.rtxResults.Location = new System.Drawing.Point(12, 124);
			this.rtxResults.Name = "rtxResults";
			this.rtxResults.Size = new System.Drawing.Size(413, 381);
			this.rtxResults.TabIndex = 11;
			this.rtxResults.Text = "";
			// 
			// CompanyLookup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(443, 547);
			this.Controls.Add(this.rtxResults);
			this.Controls.Add(this.txtPattern);
			this.Name = "CompanyLookup";
			this.Text = "CompanyLookup";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPattern;
		private System.Windows.Forms.RichTextBox rtxResults;
	}
}