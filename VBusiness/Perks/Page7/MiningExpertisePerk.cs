using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class MiningExpertisePerk : Perk
	{
		public MiningExpertisePerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Probes gain +1 kill while mining";

		public override byte Page => 7;

		public override byte Position => 2;

		public override int StartingCost => 5000;

		public override int IncrementCost => 1500;

		protected override short MaxLevelCore => 4;

		protected override string PerkName => "Mining Expertise";
	}
}
