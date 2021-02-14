using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class RankRevisionPerk : Perk
	{
		public RankRevisionPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increases rank up chance by 5%";

		public override byte Page => 5;

		public override byte Position => 6;

		public override int StartingCost => 1000;

		public override int IncrementCost => 500;

		protected override short MaxLevelCore => 5;

		protected override string PerkName => "Rank Revision";
	}
}
