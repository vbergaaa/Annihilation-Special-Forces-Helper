using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class CriticalHarvest2Perk : Perk
	{
		public CriticalHarvest2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Grants 1% chance to gain double minerals when a probe returns to your nexus";

		public override byte Page => 10;

		public override byte Position => 3;

		public override int StartingCost => 800;

		public override int IncrementCost => 125;

		protected override short MaxLevelCore => 30;

		protected override string PerkName => "Critical Harvest II";
	}
}
