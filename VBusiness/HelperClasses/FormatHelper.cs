using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.HelperClasses
{
	public static class FormatHelper
	{
		public static string ReplaceWhiteSpace(string message, string replacement = "_")
		{
			return message.Replace(" ", replacement);
		}
	}
}
