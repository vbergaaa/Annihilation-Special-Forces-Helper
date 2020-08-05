using System;
using System.Linq;
using VEntityFramework.Model;

namespace VBusiness.Gems
{
	abstract class Gem : VGem
	{
		public override int GetTotalCost()
		{
			return Costs.Take(CurrentLevel).Sum();
		}

		public override int GetCostOfNextLevel()
		{
			return Costs[CurrentLevel];
		}

		protected override Action<VStats> GetStatsModifier(int levelDifference) => null;
	}
}
