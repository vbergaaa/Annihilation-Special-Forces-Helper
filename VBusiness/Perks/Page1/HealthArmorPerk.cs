using VModel;

namespace VBusiness.Perks
{
	public class HealthArmorPerk : Perk
	{
		protected override string name => "Health Armor";

		public override string Description => "Increase Health Armor by 2%";

		public override byte Page => 1;

		public override byte Position => 6;

		public override int StartingCost => 20;

		public override int IncrementCost => 20;

		public override short MaxLevel => 10;
	}
}
