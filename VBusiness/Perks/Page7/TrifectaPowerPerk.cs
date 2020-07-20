namespace VBusiness.Perks
{
	public class TrifectaPowerPerk : Perk
	{
		public override string Description => "Increases stats by 1.5% and armor by 1% while unit is at or above SSS";

		public override byte Page => 7;

		public override byte Position => 1;

		public override int StartingCost => 2000;

		public override int IncrementCost => 500;

		public override short MaxLevel => 10;

		protected override string name => "Trifecta Power";
	}
}
