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

		protected override void OnPerkLevelChanged(int difference)
		{
			base.OnPerkLevelChanged(difference);
			
			if (GemCollection.Loadout.Perks.DoubleWarp.DesiredLevel
				+ GemCollection.Loadout.Perks.DoubleWarp2.DesiredLevel
				+ GemCollection.Loadout.Perks.DoubleWarp3.DesiredLevel
				+ GemCollection.Loadout.Perks.DoubleWarp4.DesiredLevel < 100)
			{
				GemCollection.Loadout.IncomeManager.DoubleWarp += difference;
			}
		}
	}
}
