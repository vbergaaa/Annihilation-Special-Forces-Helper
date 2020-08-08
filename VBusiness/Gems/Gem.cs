using System;
using System.Dynamic;
using System.Linq;
using VEntityFramework.Model;

namespace VBusiness.Gems
{
	abstract class Gem : VGem
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
			return (int)(BaseCost + IncrementCost * level);
		}

		protected abstract decimal BaseCost { get; }
		protected abstract decimal IncrementCost { get; }
		protected override Action<VStats> GetStatsModifier(int levelDifference) => null;
	}
}
