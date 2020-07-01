namespace VBusiness.Perks
{
	public class MaximumPotiential2Perk : Perk
	{
		public override string Description => "Increase maximun kill count and maximun life essence stacks by 50";

		public override byte Page => 5;

		public override byte Position => 3;

		public override int StartingCost => 200;

		public override int IncrementCost => 80;

		public override short MaxLevel => 10;

		protected override string name => "Maximum Potiential II";
	}
}
