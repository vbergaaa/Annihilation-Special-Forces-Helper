using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Gems
{
	class HealthGem : Gem
	{
		public HealthGem(VGemCollection collection) : base(collection)
		{
		}

		public override string Name => "Health";

		protected override decimal BaseCost => 1.4m;

		protected override decimal IncrementCost => 0.2m;

		protected override void OnPerkLevelChanged(int difference) => GemCollection.Loadout.Stats.Health += difference;
	}
}
