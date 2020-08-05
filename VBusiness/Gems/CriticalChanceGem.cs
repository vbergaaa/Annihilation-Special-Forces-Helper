using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Gems
{
	class CriticalChanceGem : Gem
	{
		public override string Name => "Critical Chance";

		protected override decimal baseCost => 4.49m;

		protected override decimal incrementCost => .45m;

		protected override Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference) => (stats) => { stats.CriticalChance += levelDifference; };
	}
}
