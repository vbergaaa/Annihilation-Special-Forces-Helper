using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class InfusionRecycle3Perk : Perk
	{
		public InfusionRecycle3Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Infusing a unit stores 5 kills.";

		public override byte Page => 12;

		public override byte Position => 1;

		public override int StartingCost => 1000;

		public override int IncrementCost => 300;

		protected override string PerkName => "Infusion Recycle III";

		protected override short MaxLevelCore => 20;
	}
}
