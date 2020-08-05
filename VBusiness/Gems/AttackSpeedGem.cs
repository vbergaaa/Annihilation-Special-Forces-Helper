using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Gems
{
	class AttackSpeedGem : Gem
	{
		public override string Name => "Attack Speed";

		protected override decimal baseCost => 1.5m;

		protected override decimal incrementCost => 0.25m;

		protected override Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference) => (stats) => { stats.AttackSpeed += levelDifference; };
	}
}
