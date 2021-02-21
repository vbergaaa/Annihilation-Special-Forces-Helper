using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class UnitStoragePerk : Perk
	{
		public UnitStoragePerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Allows you to store units using @in. Stored units take up 1 less supply and are the priority material for infusing.";

		public override byte Page => 7;

		public override byte Position => 5;

		public override int StartingCost => 20000;

		public override int IncrementCost => 0;

		protected override short MaxLevelCore => 1;

		protected override string PerkName => "Unit Storage";
	}
}
