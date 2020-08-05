using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Gems
{
	class DoubleWarpGem : Gem
	{
		public override string Name => "Double Warp";

		protected override decimal baseCost => 2.5m;

		protected override decimal incrementCost => .33m;

		//protected override Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference) => (stats) => { stats.DoubleWarp += levelDifference; };
	}
}
