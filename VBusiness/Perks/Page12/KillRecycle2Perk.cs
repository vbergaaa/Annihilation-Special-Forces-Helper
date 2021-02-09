using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class KillRecycle2Perk : Perk
	{
		public KillRecycle2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "";

		public override byte Page => 12;

		public override byte Position => 4;

		public override int StartingCost => 1250;

		public override int IncrementCost => 375;

		protected override string PerkName => "Kill Recycle II";

		protected override short MaxLevelCore => 5;
	}
}
