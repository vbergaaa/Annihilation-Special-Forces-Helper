namespace VBusiness.Perks
{
	public class BalancedTraining2Perk : Perk
	{
		public override string Description => "Increase damage, attack speed, vitals, vital armor by 1%";

		public override byte Page => 11;

		public override byte Position => 3;

		public override int StartingCost => 2500;

		public override int IncrementCost => 500;

		public override short MaxLevel => 20;

		protected override string name => "Balanced Training II";
	}
}
