using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Gems
{
	class CriticalDamageGem : Gem
	{
		public override int[] Costs => fCosts ?? (fCosts = GetCosts());

		public override string Name => "Critical Damage";

		int[] fCosts;

		private int[] GetCosts()
		{
			var costs = new int[100];

			for (var i = 0; i < 100; i++)
			{
				costs[i] = (int)(.35 * i + 2.5);
			}

			return costs;
		}

		protected override Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference) => (stats) => { stats.CriticalDamage += levelDifference; };
	}
}
