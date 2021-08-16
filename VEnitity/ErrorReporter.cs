using System;
using VEntityFramework.Data;
using VEntityFramework.Model;

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
			if (codeToRun == null || codeToRun())
			{
				Log.Report(message + "\r\n\r\n" + Environment.StackTrace, LogState.Warning);

#if DEBUG
				throw new DeveloperException(message);
#endif
			}
		}
	}
}
