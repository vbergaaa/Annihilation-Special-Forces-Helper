using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Gems
{
	class HealthArmorGem : Gem
	{
		public override string Name => "Health Armor";

		protected override decimal BaseCost => 1.5m;

		protected override decimal IncrementCost => 0.5m;
		protected override Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference) => (stats) => { stats.HealthArmor += levelDifference; };
	}
}
