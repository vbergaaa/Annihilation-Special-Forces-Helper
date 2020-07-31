using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Gems
{
	class ShieldsGem : Gem
	{
		public override string Name => "Shields";

		public override int[] Costs => fCosts ?? (fCosts = GetCosts());
		int[] fCosts;

		private int[] GetCosts()
		{
			var costs = new int[100];

			for (var i = 0; i < 100; i++)
			{
				costs[i] = (i + 7) / 5;
			}

			return costs;
		}

		protected override Action<VStats> GetStatsModifier(int levelDifference) => (stats) => { stats.Attack += levelDifference; };
	}
}
