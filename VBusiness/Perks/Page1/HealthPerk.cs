namespace VBusiness.Perks
{
	public class HealthPerk : Perk
	{
		protected override string name => "Health";

		public override string Description => "Increases Health and Health Regen of all units by 2.5%";

		public override byte Page => 1;

		public override byte Position => 5;

		public override int StartingCost => 15;

		public override int IncrementCost => 15;

		public override short MaxLevel => 10;
	}
}
