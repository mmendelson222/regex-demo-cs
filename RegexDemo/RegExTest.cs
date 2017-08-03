using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Text;
using RegexDemo;
using Synteractive.Utils;

namespace Test1
{
	/// <summary>
	/// Summary description for RegExTest.
	/// </summary>
	public class RegExTest : System.Windows.Forms.Form
	{
        const string XML_FILE_NAME= "regex.xml";


		private System.Windows.Forms.TextBox txtText;
		private System.Windows.Forms.TextBox txtPattern;
		private System.Windows.Forms.TextBox txtResults;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.CheckBox chkIgnoreCase;
        private CheckBox chkSingleLine;
        private Button button1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RegExTest()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chkIgnoreCase = new System.Windows.Forms.CheckBox();
            this.chkSingleLine = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Location = new System.Drawing.Point(12, 28);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(278, 118);
            this.txtText.TabIndex = 0;
            this.txtText.Text = "-10y";
            // 
            // txtPattern
            // 
            this.txtPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPattern.Location = new System.Drawing.Point(12, 178);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(276, 20);
            this.txtPattern.TabIndex = 1;
            this.txtPattern.Text = "^([-]?\\d+)([ymad]?)$";
            // 
            // txtResults
            // 
            this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResults.Location = new System.Drawing.Point(0, 258);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(302, 232);
            this.txtResults.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pattern";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 204);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(64, 48);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(224, 204);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 48);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Close";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // chkIgnoreCase
            // 
            this.chkIgnoreCase.Location = new System.Drawing.Point(63, 154);
            this.chkIgnoreCase.Name = "chkIgnoreCase";
            this.chkIgnoreCase.Size = new System.Drawing.Size(88, 24);
            this.chkIgnoreCase.TabIndex = 8;
            this.chkIgnoreCase.Text = "Ignore case";
            // 
            // chkSingleLine
            // 
            this.chkSingleLine.Location = new System.Drawing.Point(157, 154);
            this.chkSingleLine.Name = "chkSingleLine";
            this.chkSingleLine.Size = new System.Drawing.Size(88, 24);
            this.chkSingleLine.TabIndex = 9;
            this.chkSingleLine.Text = "single line";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Test formatting";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegExTest
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(302, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkSingleLine);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkIgnoreCase);
            this.Name = "RegExTest";
            this.Text = "Regex Test Form";
            this.DoubleClick += new System.EventHandler(this.RegExTest_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            XmlLoad();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            XmlSave();
            base.OnClosing(e);
        }

        private void XmlLoad()
        {
            //load it if present.
            try
            {
                XmlConfig textboxContents = (XmlConfig)XmlUtils.DeserializeFromFile(typeof(XmlConfig), XML_FILE_NAME);
                this.txtPattern.Text = textboxContents.Pattern;
                this.txtText.Text = textboxContents.Text;
            }
            catch
            {
                //file not found, probably.
                this.txtText.Text = "One car red car blue car";
                this.txtPattern.Text = @"(\w+)\s+(car)";
            }
        }

        private void XmlSave()
        {
            XmlConfig textboxContents = new XmlConfig();
            textboxContents.Pattern = this.txtPattern.Text;
            textboxContents.Text = this.txtText.Text;
            XmlUtils.SerializeObject(textboxContents, XML_FILE_NAME);
        }

		private void btnTest_Click(object sender, System.EventArgs e)
		{
			this.txtResults.Text = "";

            RegexOptions options = RegexOptions.None;
            if (this.chkIgnoreCase.Checked)
                options = options | RegexOptions.IgnoreCase;
            if (this.chkSingleLine.Checked)
                options = options | RegexOptions.Singleline;

			try 
			{
				Regex r = new Regex(this.txtPattern.Text, options); 
				// Find a single match in the string.
				Match m = r.Match(this.txtText.Text);
				this.txtResults.Text = RegexUtils.InterpretMatch(m);
			} 
			catch (System.Exception ex) 
			{
				this.txtResults.Text = ex.Message + "\r\n" + ex.StackTrace.ToString();
			}
			
			
		}

		


		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();  //junk
		}

		private static void testRegExp2 () 
		{
			// Create a new Regex object.
			Regex r = new Regex("abc"); 
			// Find a single match in the string.
			Match m = r.Match("123abc456"); 
			if (m.Success) 
			{
				// Print out the character position where a match was found. 
				// (Character position 3 in this case.)
				Console.WriteLine("Found match at position " + m.Index);
			}


			 
			string text = "One car red car blue car";
			string pat = @"(\w+)\s+(car)";
			// Compile the regular expression.
			r = new Regex(pat, RegexOptions.IgnoreCase);
			// Match the regular expression pattern against a text string.
			m = r.Match(text);
		}


		private void RegExTest_DoubleClick(object sender, System.EventArgs e)
		{
		testRegExp2();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new RegExTest());

		}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float f;
                if (!float.TryParse(this.txtText.Text, out f))
                    this.txtResults.Text = "Use a number";
                else
                    this.txtResults.Text = f.ToString(this.txtPattern.Text);
            }
            catch (Exception ex)
            {
                this.txtResults.Text = ex.Message;
            }

        }
	}


  
}
