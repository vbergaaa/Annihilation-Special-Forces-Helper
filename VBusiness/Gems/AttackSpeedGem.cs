using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Gems
{
	class AttackSpeedGem : Gem
	{
		public override string Name => "Attack Speed";

		public override int[] Costs => fCosts = (fCosts = GetCosts());

		private int[] fCosts;

		private int[] GetCosts()
		{
			var costs = new int[100];

			for (var i = 0; i < 100; i++)
			{
				costs[i] = (i + 6) / 4;
			}

			return costs;
		}
	}
}
