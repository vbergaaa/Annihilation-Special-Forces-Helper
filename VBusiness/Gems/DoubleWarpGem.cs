using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Gems
{
	class DoubleWarpGem : Gem
	{
		public override string Name => "Double Warp";

		protected override decimal BaseCost => 2.5m;

		protected override decimal IncrementCost => .33m;

		//protected override Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference) => (stats) => { stats.DoubleWarp += levelDifference; };
	}
}
