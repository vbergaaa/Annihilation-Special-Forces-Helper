namespace VBusiness.Perks
{
	public class RankRevision2Perk : Perk
	{
		public override string Description => "Increases the chance to successfully rank up a unit by 5%";

		public override byte Page => 9;

		public override byte Position => 6;

		public override int StartingCost => 10000;

		public override int IncrementCost => 2500;

		public override short MaxLevel => 5;

		protected override string name => "Rank Revision II";
	}
}
