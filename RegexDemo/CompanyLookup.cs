using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace RegexDemo
{
	public partial class CompanyLookup : Form
	{
		public CompanyLookup()
		{
			InitializeComponent();

			boldfont = new Font(
				   this.rtxResults.Font.FontFamily,
				   this.rtxResults.Font.Size,
				   FontStyle.Bold
				);

			stdfont = (Font)this.rtxResults.Font.Clone();

			initSuccess = InitializeCompanyList();  
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (!initSuccess) this.Close();
		}
		
		Font boldfont;
		Font stdfont;
		const int MAX_LIST = 20;
		List<Company> companies = null;
		bool initSuccess = false;

		private void txtText_TextChanged(object sender, EventArgs e)
		{
			this.rtxResults.SuspendLayout();
			Search();
			this.rtxResults.ResumeLayout();
		}

		private void Search()
		{
			this.rtxResults.Clear(); 
			
			if (null == companies) return;
			if (this.txtPattern.Text.Length == 0) return;

			RegexOptions options = RegexOptions.IgnoreCase;
			
			Regex r = new Regex(Regex.Escape(this.txtPattern.Text), options);
			
			int count = 0;
			foreach (Company company in this.companies)
			{
				Match[] matches = GetMatches(company, r);
				if (null != matches)
				{
					//break out of the loop if our maximum has been reached.
					if (++count == MAX_LIST)
					{
						this.rtxResults.AppendText("more.......");
						break;
					}

					//this.rtxResults.AppendText(company.Id + "\t" + company.Description + "\r\n");
					ShowOne(company, matches);
				}

			}
		}

		private Match[] GetMatches(Company company, Regex regex)
		{
			Match[] coMatches = new Match[2];
			bool matchFound = false;
			coMatches[0] = regex.Match(company.Id);
			matchFound = matchFound || coMatches[0].Success;
			coMatches[1] = regex.Match(company.Description);
			matchFound = matchFound || coMatches[1].Success;

			if (matchFound)
				return coMatches;
			else
				return null;
		}

		private void ShowOne(Company c, Match[] matches)
		{
			//match 0 applies to id
			ShowHighlightedString(c.Id, matches[0]);

			this.rtxResults.AppendText("\t");

			//match 1 applies to description
			ShowHighlightedString(c.Description, matches[1]);

			this.rtxResults.AppendText("\r\n");
		}

		/// <summary>
		/// add a string to the text box and highlight it using matches.
		/// </summary>
		private void ShowHighlightedString(string s, Match m)
		{
			int startPosition = rtxResults.Text.Length;

			this.rtxResults.AppendText(s);
			if (!m.Success) return;  //no match

			foreach (Capture capture in m.Captures)
			{
				this.rtxResults.Select(startPosition + capture.Index, capture.Length);
				SetSelectionBold(this.rtxResults);
			}
		}

		private void SetSelectionBold(RichTextBox rtb)
		{
			rtb.SelectionFont = boldfont;

			//a hack to get subsequent text added using the "standard" font.
			if (rtb.SelectionStart + rtb.SelectionLength == rtb.Text.Length)
			{
				rtb.AppendText(" ");
				rtb.Select(rtb.Text.Length - 1, 1);
				rtb.SelectionFont = stdfont;
			}

		}

		/// <summary>
		/// Get a list of companies from our input file.
		/// </summary>
		private bool InitializeCompanyList()
		{
			string fname = "companies.tab";
			string companyTabFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), fname);
			string allCompanies=null;

			try
			{
				allCompanies = GetText(companyTabFile);
			}
			catch (FileNotFoundException ex)
			{
				MessageBox.Show("You need to move file " + Path.GetFileName(ex.FileName) + " to " + Path.GetDirectoryName(ex.FileName));
				return false;
			}
			string [] aCompanies = allCompanies.Split(new char[]{'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);

			companies = new List<Company>();
			List<string> uniqueIDs = new List<string>();  //to make sure we don't add companies twice.
			foreach (string companyData in aCompanies)
			{
				string [] singleCompanyData = companyData.Split(new char[] {'\t'});
				Company c = new Company(singleCompanyData[2], singleCompanyData[3]);

				//get the 3rd and 4th element
				if (!uniqueIDs.Contains(c.Id))
				{
					uniqueIDs.Add(c.Id);
					companies.Add(c);
				}
			}

			return true;
		}

		/// <summary>
		/// retrieve the entire file as a string.
		/// </summary>
		/// <param name="filePath"></param>
		/// <returns></returns>
		private static string GetText(string filePath)
		{
			using (StreamReader sr = new StreamReader(filePath))
			{
				string line;
				// Read and display lines from the file until the end of 
				// the file is reached.
				System.Text.StringBuilder buf = new System.Text.StringBuilder();
				while ((line = sr.ReadLine()) != null)
				{
					buf.AppendLine(line);
				}
				sr.Close();
				return buf.ToString();
			}
		}



		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.Run(new CompanyLookup());

		}

		private void ListAll()
		{
			if (null == companies) return;

			this.rtxResults.Clear();
			foreach (Company company in this.companies)
			{
				this.rtxResults.AppendText(company.Id + "\t" + company.Description + "\r\n");
			}

		}

		

	}


	internal class Company
	{
		internal Company(string id, string desc)
		{
			this.id = id;
			this.description = desc;
		}

		private string id = null;

		public string Id
		{
			get { return id; }
			set { id = value; }
		}
		private string description = null;

		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		//string.Format("{0}\t{1}", 
	}
}