using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class KillHarvestPerk : Perk
	{
		public KillHarvestPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Grants a 3% chance to gain an extra kill when Kill Efficiency triggers";

		public override byte Page => 9;

		public override byte Position => 1;

		public override int StartingCost => 500;

		public override int IncrementCost => 100;

		public override short MaxLevel => 20;

		protected override string PerkName => "Kill Harvest";
	}
}
