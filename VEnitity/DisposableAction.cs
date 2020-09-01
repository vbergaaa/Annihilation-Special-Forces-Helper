using System;
using System.Collections.Generic;
using System.Text;

namespace VEntityFramework
{
	public class DisposableAction : IDisposable
	{
		public DisposableAction(Action action)
		{
			Action = action;
		}

		public Action Action { get; }

		public void Dispose()
		{
			Action();
		}
	}
}
