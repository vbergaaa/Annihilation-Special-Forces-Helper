﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Gems
{
	class ShieldsArmorGem : Gem
	{
		public override string Name => "Shields Armor";

		protected override decimal baseCost => 1.5m;

		protected override decimal incrementCost => 0.5m;

		protected override Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference) => (stats) => { stats.ShieldsArmor += levelDifference; };
	}
}