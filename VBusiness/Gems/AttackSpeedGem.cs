using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Gems
{
	class AttackSpeedGem : Gem
	{
		public AttackSpeedGem(VGemCollection collection) : base(collection)
		{
		}

		public override string Name => "Attack Speed";

		protected override decimal BaseCost => 1.5m;

		protected override decimal IncrementCost => 0.25m;

		protected override void OnPerkLevelChanged(int difference) => GemCollection.Loadout.Stats.AttackSpeed += difference;
	}
}
