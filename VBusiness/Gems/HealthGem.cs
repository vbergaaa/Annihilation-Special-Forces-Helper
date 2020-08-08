using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Gems
{
	class HealthGem : Gem
	{
		public override string Name => "Health";

		protected override decimal BaseCost => 1.4m;

		protected override decimal IncrementCost => 0.2m;

		protected override Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference) => (stats) => { stats.Health += levelDifference; };
	}
}
