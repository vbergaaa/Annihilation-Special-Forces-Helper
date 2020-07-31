using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Gems
{
	class HealthGem : Gem
	{
		public override string Name => "Health";

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

		protected override Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference) => (stats) => { stats.Health += levelDifference; };
	}
}
