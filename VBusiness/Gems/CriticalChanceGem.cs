using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Gems
{
	class CriticalChanceGem : Gem
	{
		public override string Name => "Critical Chance";

		public override int[] Costs => fCosts ?? (fCosts = GetCosts());
		int[] fCosts;

		private int[] GetCosts()
		{
			var costs = new int[100];

			for (var i = 0; i < 100; i++)
			{
				costs[i] = (int)(.45 * i + 4.49);
			}

			return costs;
		}
	}
}
