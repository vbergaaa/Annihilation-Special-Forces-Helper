using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Gems
{
	class HealthGem : Gem
	{
		public override string Name => "Health";

		protected override decimal baseCost => 1.4m;

		protected override decimal incrementCost => 0.2m;

		protected override Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference) => (stats) => { stats.Health += levelDifference; };
	}
}
