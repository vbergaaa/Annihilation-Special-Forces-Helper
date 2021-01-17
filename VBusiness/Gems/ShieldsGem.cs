using VEntityFramework.Model;

namespace VBusiness.Gems
{
	class ShieldsGem : Gem
	{
		public ShieldsGem(VGemCollection collection) : base(collection)
		{
		}

		public override string Name => "Shields";

		protected override decimal BaseCost => 1.4m;

		protected override decimal IncrementCost => 0.2m;

		protected override void OnPerkLevelChanged(int difference) => GemCollection.Loadout.Stats.Shields += difference;
	}
}
