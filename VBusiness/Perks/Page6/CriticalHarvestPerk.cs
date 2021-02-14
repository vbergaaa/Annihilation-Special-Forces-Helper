using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class CriticalHarvestPerk : Perk
	{
		public CriticalHarvestPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "+1% chance to double minerals when mining";

		public override byte Page => 6;

		public override byte Position => 6;

		public override int StartingCost => 200;

		public override int IncrementCost => 60;

		protected override short MaxLevelCore => 20;

		protected override string PerkName => "Critical Harvest";
	}
}
