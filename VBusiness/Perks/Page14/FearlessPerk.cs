using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class FearlessPerk : Perk
	{
		public FearlessPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Reduce fear by 1%, doubled while solo";

		public override byte Page => 14;

		public override byte Position => 5;

		public override int StartingCost => 50000;

		public override int IncrementCost => 100000;

		protected override string PerkName => "Fearless";

		protected override short MaxLevelCore => 2;
	}
}
