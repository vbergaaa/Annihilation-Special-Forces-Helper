using VEntityFramework.Model;

namespace VBusiness.Gems
{
	class ShieldsArmorGem : Gem
	{
		public ShieldsArmorGem(VGemCollection collection) : base(collection)
		{
		}

		public override string Name => "Shields Armor";

		protected override decimal BaseCost => 1.5m;

		protected override decimal IncrementCost => 0.5m;

		protected override void OnPerkLevelChanged(int difference) => GemCollection.Loadout.Stats.ShieldsArmor += difference;
	}
}
