using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Gems
{
	class ShieldsGem : Gem
	{
		public override string Name => "Shields";

		protected override decimal BaseCost => 1.4m;

		protected override decimal IncrementCost => 0.2m;

		protected override Action<VStats> GetStatsModifier(int levelDifference) => (stats) => { stats.Shields += levelDifference; };
	}
}
