using System;
using System.Runtime.Serialization;

namespace VEntityFramework.Data
{
	[Serializable]
	internal class DeveloperException : Exception
	{
		public DeveloperException()
		{
		}

		public DeveloperException(string message) : base(message)
		{
		}

		public DeveloperException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected DeveloperException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}

	public static class Argument
	{
		public static object Check(object param, string paramName = null)
		{
#if DEBUG
			if (param == null)
			{
				throw new ArgumentException($"Parameter {paramName} should not be null");
			}
#endif
			return param;
		}
	}
}