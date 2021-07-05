using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class DestroyerRankRevisionPerk : Perk
	{
		public DestroyerRankRevisionPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "+2% Rank Revision";

		public override byte Page => 15;

		public override byte Position => 6;

		public override int StartingCost => 25000;

		public override int IncrementCost => 4000;

		protected override string PerkName => "Destroyer Rank Revision";

		protected override short MaxLevelCore => 25;

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);

			PerkCollection.Loadout.IncomeManager.RankRevision += 2 * difference;
		}
	}
}
