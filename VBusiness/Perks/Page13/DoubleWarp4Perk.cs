using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class DoubleWarp4Perk : Perk
	{
		public DoubleWarp4Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Grants a 1% chance to warp in a duplicate when buying a unit";

		public override byte Page => 13;

		public override byte Position => 1;

		public override int StartingCost => 2000;

		public override int IncrementCost => 200;

		protected override string PerkName => "Double Warp IV";

		protected override short MaxLevelCore => 40;
	}
}
