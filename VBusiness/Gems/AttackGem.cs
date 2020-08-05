﻿using System;

namespace VBusiness.Gems
{
	class AttackGem : Gem
	{
		public override string Name => "Attack";

		protected override decimal incrementCost => 0.2m;

		protected override decimal baseCost => 1.4m;

		protected override Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference) => (stats) => { stats.Attack += levelDifference; };
	}
}
