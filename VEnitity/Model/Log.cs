using System;
using VEntityFramework.Attributes;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	[TopLevelBusinessObject("Logs")]
	public class Log : BusinessObject
	{
		public static void Error(string message, Exception ex)
		{
			Report(message, LogState.Error, ex);
#if DEBUG
			throw new DeveloperException(message, ex);
#endif
		}

		public static void Info(string message)
		{
			Report(message, LogState.Info);
		}

		public static void Report(string message, LogState state, Exception ex = null)
		{
			var requiredState = VRegistry.Instance.LogVerbosity;
			if (state >= requiredState)
			{
				var log = new Log(message, state, ex);
				log.Save();
			}
		}

		static int LogNumber = 1;

		private Log(string message, LogState state, Exception ex)
		{
			Contents = message;
			State = state;
			Exception = ex;
		}

		public override string BizoName => "ErrorLog";

		protected internal override string GetSaveNameForXML()
		{
			return $"{State}_{DateTime.Now:yyyyMMdd_hhmmss}_{LogNumber++}";
		}

		[VXML(true)]
		public virtual string LogContents
		{
			get
			{
				var message = Contents;

				if (Exception != null)
				{
					message += "\r\n\r\n" + Exception.Message + "\r\n" + Exception.StackTrace;
					while (Exception.InnerException != null)
					{
						Exception = Exception.InnerException;
						message += "\r\n\r\n" + Exception.Message + "\r\n" + Exception.StackTrace;
					}
				}
				return message;
			}
		}

		public LogState State { get; }

		public string Contents { get; set; }

		public Exception Exception { get; set; }
	}

	public enum LogState
	{
		Info,
		Warning,
		Error
	}
}
