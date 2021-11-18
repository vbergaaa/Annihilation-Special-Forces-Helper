using VEntityFramework.Model;

namespace VBusiness.Gems
{
	class HealthArmorGem : Gem
	{
		public HealthArmorGem(VGemCollection collection) : base(collection)
		{
		}

		public override string Name => "Health Armor";

		protected override decimal BaseCost => 1.5m;

		protected override decimal IncrementCost => 0.5m;
		protected override void OnPerkLevelChanged(int difference)
		{
			GemCollection.Loadout.Stats.UpdateHealthArmor("Core", difference);
		}
	}
}
