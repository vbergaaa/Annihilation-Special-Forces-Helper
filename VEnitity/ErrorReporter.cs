using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework
{
	public static class ErrorReporter
	{
		/// TODO: make this obsolete - 
		/// it runs the condition before checking if we are in debug, which can be expensive and run frequently
		/// we should try to avoid this to improve release performance
		public static void ReportDebug(bool condition, string message)
		{
#if DEBUG
			if (condition)
			{
				throw new DeveloperException(message);
			}
#endif
		}

		public static void ReportDebug(string message, Func<bool> codeToRun = null)
		{
#if DEBUG
			if (codeToRun == null || codeToRun())
			{
				throw new DeveloperException(message);
			}
#endif
		}
	}
}
