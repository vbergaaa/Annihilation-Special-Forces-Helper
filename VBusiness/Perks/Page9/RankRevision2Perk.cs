using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class RankRevision2Perk : Perk
	{
		public RankRevision2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increases rank up chance by 5%";

		public override byte Page => 9;

		public override byte Position => 6;

		public override int StartingCost => 10000;

		public override int IncrementCost => 2500;

		protected override short MaxLevelCore => 5;

		protected override string PerkName => "Rank Revision II";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.IncomeManager.RankRevision += difference * 5;
		}
	}
}
