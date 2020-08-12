using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Gems
{
	class CriticalChanceGem : Gem
	{
		public override string Name => "Crit Chance";

		protected override decimal BaseCost => 4.49m;

		protected override decimal IncrementCost => .45m;

		protected override Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference) => (stats) => { stats.CriticalChance += levelDifference; };
	}
}
