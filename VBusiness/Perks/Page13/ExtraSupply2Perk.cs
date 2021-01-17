using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class ExtraSupply2Perk : Perk
	{
		public ExtraSupply2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increase Supply Limit by 1";

		public override byte Page => 13;

		public override byte Position => 6;

		public override int StartingCost => 10000;

		public override int IncrementCost => 1000;

		protected override string PerkName => "Extra Supply II";

		protected override short MaxLevelCore => 10;
	}
}
