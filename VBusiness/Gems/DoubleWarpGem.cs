using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Gems
{
	class DoubleWarpGem : Gem
	{
		public DoubleWarpGem(VGemCollection collection) : base(collection)
		{
		}

		public override string Name => "Double Warp";

		protected override decimal BaseCost => 2.5m;

		protected override decimal IncrementCost => .33m;

		//protected override void OnPerkLevelChanged(int difference) => GemCollection.Loadout.Stats.DoubleWarp += difference;
	}
}
