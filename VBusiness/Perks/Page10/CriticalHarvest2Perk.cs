namespace VBusiness.Perks
{
	public class CriticalHarvest2Perk : Perk
	{
		public override string Description => "Grants 1% chance to gain double minerals when a probe returns to your nexus";

		public override byte Page => 10;

		public override byte Position => 3;

		public override int StartingCost => 800;

		public override int IncrementCost => 125;

		public override short MaxLevel => 30;

		protected override string name => "Critical Harvest II";
	}
}
