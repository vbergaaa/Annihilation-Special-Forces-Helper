using System;
using System.Dynamic;
using System.Linq;
using VEntityFramework.Model;

namespace VBusiness.Gems
{
	abstract class Gem : VEntityFramework.Model.VGem
	{
		public override int GetTotalCost()
		{
			var ret = 0;
			for (var i = 0; i < CurrentLevel; i++)
			{
				ret += GetCostOfLevel(i);
			}
			return ret;
		}

		public override int GetCostOfNextLevel()
		{
			return GetCostOfLevel(CurrentLevel);
		}

		int GetCostOfLevel(int level)
		{
			return (int)(baseCost + incrementCost * level);
		}

		protected abstract decimal baseCost { get; }
		protected abstract decimal incrementCost { get; }

		protected override Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference) => null;
	}
}
