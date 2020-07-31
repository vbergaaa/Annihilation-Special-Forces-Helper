using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VGemCollection : VBusinessObject
	{
		public override string BizoName => "GemCollection";

		public abstract VGem AttackGem { get; }
		public abstract VGem AttackSpeedGem { get; }
		public abstract VGem HealthGem { get; }
		public abstract VGem HealthArmorGem { get; }
		public abstract VGem ShieldsGem { get; }
		public abstract VGem ShieldsArmorGem { get; }
		public abstract VGem DoubleWarpGem { get; }
		public abstract VGem CriticalDamageGem { get; }
		public abstract VGem CriticalChanceGem { get; }

		public abstract VGem[] Gems { get; }

		public int TotalCost { get => Gems.Sum(g => g.GetTotalCost()); }

		#region Events

		protected void OnGemCollectionLevelUpdated(object sender, VEntityFramework.StatsEventArgs e)
		{
			GemCollectionLevelUpdated?.Invoke(sender, e);
		}

		public event EventHandler<StatsEventArgs> GemCollectionLevelUpdated;

		#endregion
	}
}

