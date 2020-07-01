namespace VBusiness.Perks
{
	public class MaximumGatherPerk : Perk
	{
		public override string Description => "Gain 5% chance to gain a Kill Resource whenever a unit with max kills obtains a kill";

		public override byte Page => 5;

		public override byte Position => 4;

		public override int StartingCost => 200;

		public override int IncrementCost => 50;

		public override short MaxLevel => 10;

		protected override string name => "Maximum Gather";
	}
}
