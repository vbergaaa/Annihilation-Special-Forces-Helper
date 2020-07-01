namespace VBusiness.Perks
{
	public class BaseInfusionRecyclePerk : Perk
	{
		public override string Description => "Infusing a unit stores 5 kills";

		public override byte Page => 2;

		public override byte Position => 6;

		public override int StartingCost => 50;

		public override int IncrementCost => 20;

		public override short MaxLevel => 10;

		protected override string name => "Infusion Recycle";
	}
}
