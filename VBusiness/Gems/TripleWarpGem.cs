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

		protected override void OnPerkLevelChanged(int difference)
		{
			base.OnPerkLevelChanged(difference);

			if (GemCollection.Loadout.Perks.DoubleWarp.DesiredLevel
				+ GemCollection.Loadout.Perks.DoubleWarp2.DesiredLevel
				+ GemCollection.Loadout.Perks.DoubleWarp3.DesiredLevel
				+ GemCollection.Loadout.Perks.DoubleWarp4.DesiredLevel == 100)
			{
				GemCollection.Loadout.IncomeManager.TripleWarp += difference;
			}
		}
	}
}
