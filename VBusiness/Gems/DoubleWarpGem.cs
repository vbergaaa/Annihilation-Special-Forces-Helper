using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Gems
{
	class DoubleWarpGem : Gem
	{
		public override int[] Costs => fCosts ?? (fCosts = GetCosts());

		public override string Name => "Double Warp";

		int[] fCosts;

		private int[] GetCosts()
		{
			var costs = new int[100];

			for (var i = 0; i < 100; i++)
			{
				costs[i] = (int)(.33 * i + 2.5);
			}

			return costs;
		}
	}
}
