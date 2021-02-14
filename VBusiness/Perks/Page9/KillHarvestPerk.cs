using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class KillHarvestPerk : Perk
	{
		public KillHarvestPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "+3% chance to double Kill Efficiency's Bonus";

		public override byte Page => 9;

		public override byte Position => 1;

		public override int StartingCost => 500;

		public override int IncrementCost => 100;

		protected override short MaxLevelCore => 20;

		protected override string PerkName => "Kill Harvest";
	}
}
