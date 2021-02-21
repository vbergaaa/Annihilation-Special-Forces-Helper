using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class OverSpeedPerk : Perk
	{
		public OverSpeedPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "+0.1 Move Speed\r\n+1 Movement Speed Cap";

		public override byte Page => 4;

		public override byte Position => 4;

		public override int StartingCost => 250;

		public override int IncrementCost => 500;

		protected override short MaxLevelCore => 3;

		protected override string PerkName => "Over Speed";
	}
}
