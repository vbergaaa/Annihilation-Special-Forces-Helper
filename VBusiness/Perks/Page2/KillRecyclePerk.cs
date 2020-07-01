namespace VBusiness.Perks
{
	public class KillRecyclePerk : Perk
	{
		public override string Description => "Store 5% kills of units that died allowing to give them to other units later, has a 3 second cooldown";

		public override byte Page => 2;

		public override byte Position => 2;

		public override int StartingCost => 100;

		public override int IncrementCost => 25;

		public override short MaxLevel => 5;

		protected override string name => "Kill Recycle";
	}
}
