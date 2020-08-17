using System;
using System.Dynamic;
using System.Linq;
using VEntityFramework.Model;

namespace VBusiness.Gems
{
	abstract class Gem : VGem
	{
		#region Constructor

		public Gem(VGemCollection collection) : base(collection)
		{
		}

		#endregion

		#region Methods

		#region GetTotalCost

		public override int GetTotalCost()
		{
			var ret = 0;
			for (var i = 0; i < CurrentLevel; i++)
			{
				ret += GetCostOfLevel(i);
			}
			return ret;
		}

		#endregion

		#region GetCostOfNextLevel

		public override int GetCostOfNextLevel() => GetCostOfLevel(CurrentLevel);

		int GetCostOfLevel(int level) => (int)(BaseCost + IncrementCost * level);

		#endregion

		#endregion
	}
}
