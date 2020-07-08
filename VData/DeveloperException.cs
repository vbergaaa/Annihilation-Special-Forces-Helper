using System;
using System.Runtime.Serialization;

namespace VData
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
}