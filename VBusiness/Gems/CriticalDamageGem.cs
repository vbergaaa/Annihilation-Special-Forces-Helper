using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Gems
{
	class CriticalDamageGem : Gem
	{
		public override string Name => "Critical Damage";

		protected override decimal baseCost => 2.5m;

		protected override decimal incrementCost => .35m;

		protected override Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference) => (stats) => { stats.CriticalDamage += levelDifference; };
	}
}
