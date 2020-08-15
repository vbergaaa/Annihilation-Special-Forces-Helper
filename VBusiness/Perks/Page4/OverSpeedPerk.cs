using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class OverSpeedPerk : Perk
	{
		public OverSpeedPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increase speed cap by 1 and movement speed by 0.1";

		public override byte Page => 4;

		public override byte Position => 4;

		public override int StartingCost => 250;

		public override int IncrementCost => 500;

		public override short MaxLevel => 3;

		protected override string PerkName => "Over Speed";
	}
}
