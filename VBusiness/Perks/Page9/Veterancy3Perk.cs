namespace VBusiness.Perks
{
	public class Veterancy3Perk : Perk
	{
		public override string Description => "Units start with 10 kills";

		public override byte Page => 9;

		public override byte Position => 5;

		public override int StartingCost => 1000;

		public override int IncrementCost => 100;

		public override short MaxLevel => 20;

		protected override string name => "Veterancy III";
	}
}
