using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
	internal static class RegexUtils
	{
		internal static String InterpretMatch(Match m)
		{
			int matchCount = 0;
			if (!m.Success) return "No Match";
			StringBuilder sb = new StringBuilder();
			while (m.Success)
			{
				sb.AppendLine(string.Format("Match {0}, (pos={1})", ++matchCount, m.Index));
				for (int i = 0; i <= m.Groups.Count; i++)
				{
					Group g = m.Groups[i];
					sb.AppendLine(string.Format("\tGroup {0}={1}", i, g));
					CaptureCollection cc = g.Captures;
					for (int j = 0; j < cc.Count; j++)
					{
						Capture c = cc[j];
						sb.AppendLine(string.Format("\t\tCapture {0}={1}, pos={2}", j, c, c.Index));
					}
				}
				m = m.NextMatch();
			}
			return sb.ToString();
		}
	}
}
