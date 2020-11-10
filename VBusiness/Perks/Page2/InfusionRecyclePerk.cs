using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class InfusionRecyclePerk : Perk
	{
		public InfusionRecyclePerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Infusing a unit stores 5 kills";

		public override byte Page => 2;

		public override byte Position => 6;

		public override int StartingCost => 50;

		public override int IncrementCost => 20;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Infusion Recycle";
	}
}
