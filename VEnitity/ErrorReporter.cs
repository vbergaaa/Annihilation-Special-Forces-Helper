using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework
{
	public static class ErrorReporter
	{
		public static void ReportDebug(string message)
		{
			ReportDebug(true, message);
		}

		public static void ReportDebug(bool condition, string message)
		{
#if DEBUG
			if (condition)
			{
				throw new DeveloperException(message);
			}
#endif
		}
	}
}
