using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class DestroyerWarpPerk : Perk
	{
		public DestroyerWarpPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "+1% Triple Warp";

		public override byte Page => 15;

		public override byte Position => 5;

		public override int StartingCost => 4000;

		public override int IncrementCost => 1000;

		protected override string PerkName => "Destroyer Warp";

		protected override short MaxLevelCore => 50;

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);

			PerkCollection.Loadout.IncomeManager.TripleWarp += difference;
		}
	}
}
