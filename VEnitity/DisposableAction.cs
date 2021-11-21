using System;

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
