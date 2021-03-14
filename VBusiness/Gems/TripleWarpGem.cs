using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Gems
{
	class TripleWarpGem : Gem
	{
		public TripleWarpGem(VGemCollection collection) : base(collection)
		{
		}

		public override string Name => "Triple Warp";

		protected override decimal BaseCost => 10;

		protected override decimal IncrementCost => 3;
	}
}
