using System;
using VEntityFramework.Model;

namespace VEntityFramework
{
	public class StatsEventArgs : EventArgs
	{
		public Action<VStats> Modification { get; set; }
	}
}