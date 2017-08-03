using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Synteractive.Utils;

namespace RegexDemo
{
    public partial class RegexTestForm : Form
    {
        const string XML_FILE_NAME = "regex2.xml";

        public RegexTestForm()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GetXmlConfig();
            this.radRegex.PerformClick();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.radDummy.PerformClick();
            base.OnClosing(e);
        }

        private void regexCheck_Click(object sender, System.EventArgs e)
        {
            RunProcess();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (chkAsYouType.Checked) RunProcess();
        }

        private void RunProcess()
        {
            try
            {
                if (radRegex.Checked)
                    RunRegex();
                else if (radNumFmt.Checked)
                    RunNumberFmt();
                else if (radDates.Checked)
                    RunDateFmt();
            }
            catch (Exception ex)
            {
                this.txtResults.Text = ex.Message + "\r\n" + ex.StackTrace;
            }
        }

        private void RunDateFmt()
        {
            DateTime dt;
            if (!DateTime.TryParse(this.txtText.Text, out dt))
            {
                txtResults.Text = "Target date is not valid.";
            }
            else
            {
                txtResults.Text = dt.ToString(txtPattern.Text);
            }
        }

        private void RunRegex()
        {
            StringBuilder sb = new StringBuilder();

            RegexOptions options = RegexOptions.None;
            if (this.chkIgnoreCase.Checked)
                options = options | RegexOptions.IgnoreCase;
            if (this.chkSingleLine.Checked)
                options = options | RegexOptions.Singleline;

            Regex r = new Regex(this.txtPattern.Text, options);
            Match m = r.Match(this.txtText.Text);
            sb.Append(RegexUtils.InterpretMatch(m));

            this.txtResults.Text = sb.ToString();
        }

        private void RunNumberFmt()
        {
            float f;
            if (!float.TryParse(this.txtText.Text, out f))
                this.txtResults.Text = "Use a number";
            else
                this.txtResults.Text = f.ToString(this.txtPattern.Text);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new RegexTestForm());
        }

        XmlConfig config = null;


        private void GetXmlConfig()
        {
            try
            {
                config = (XmlConfig)XmlUtils.DeserializeFromFile(typeof(XmlConfig), XML_FILE_NAME);
            }
            catch
            {
                config = new XmlConfig();
                config.Configs = new ConfigSet[] {
                    new ConfigSet() {Name=radRegex.Text, Pattern= @"(\w+)\s+(car)", Text="One car red car blue car"},
                    new ConfigSet() {Name=radNumFmt.Text, Pattern= @"0.00", Text="9.87654"},
                    new ConfigSet() {Name=radDates.Text, Pattern= @"MM/dd/yyyy hh:mm:ss", Text=DateTime.Now.ToString()}
                };
            }
        }

        private void XmlLoad(string csName)
        {
            try
            {
                ConfigSet set = config[csName];
                this.txtPattern.Text = set.Pattern;
                this.txtText.Text = set.Text;
            }
            catch
            {
                ConfigSet set = new ConfigSet();
                set.Name = csName;
                List<ConfigSet> cs = new List<ConfigSet>(config.Configs);
                cs.Add(set);
                config.Configs = cs.ToArray();

                this.txtPattern.Text = string.Empty;
                this.txtText.Text = string.Empty;
            }
        }

        private void XmlSave(string csName)
        {
            ConfigSet cs = config[csName];
            if (cs == null) cs = new ConfigSet();
            cs.Pattern = this.txtPattern.Text;
            cs.Text = this.txtText.Text;
            cs.Name = csName;
            XmlUtils.SerializeObject(config, XML_FILE_NAME);
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton cb = (RadioButton)sender;
            if (cb.Checked)
                //if moving TO this button, load it. 
                XmlLoad(cb.Text);
            else
                //if moving away from this button, save the info.
                XmlSave(cb.Text);
        }

        private void chkAsYouType_CheckedChanged(object sender, EventArgs e)
        {
            RunProcess();
        }
    }
}
