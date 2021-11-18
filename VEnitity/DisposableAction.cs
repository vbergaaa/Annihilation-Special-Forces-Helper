using System;

namespace VEntityFramework
{
	public sealed class DisposableAction : IDisposable
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
