namespace VBusiness.Perks
{
	public class MaximumPotiental3Perk : Perk
	{
		public override string Description => "Increase maximun kill count and maximun life essence stacks by 50";

		public override byte Page => 9;

		public override byte Position => 3;

		public override int StartingCost => 1000;

		public override int IncrementCost => 250;

		public override short MaxLevel => 10;

		protected override string name => "Maximum Potiental III";
	}
}
