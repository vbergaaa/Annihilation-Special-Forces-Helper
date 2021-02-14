using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class DoubleWarp3Perk : Perk
	{
		public DoubleWarp3Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Grants a 1% chance to warp in a duplicate when buying a unit";

		public override byte Page => 10;

		public override byte Position => 1;

		public override int StartingCost => 1000;

		public override int IncrementCost => 100;

		protected override short MaxLevelCore => 30;

		protected override string PerkName => "Double Warp III";
	}
}
