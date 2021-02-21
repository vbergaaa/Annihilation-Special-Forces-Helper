using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class CriticalCollectionPerk : Perk
	{
		public CriticalCollectionPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "+1% Chance to earn 2 Kill Resource when mining";

		public override byte Page => 6;

		public override byte Position => 5;

		public override int StartingCost => 300;

		public override int IncrementCost => 60;

		protected override short MaxLevelCore => 20;

		protected override string PerkName => "Critical Collection";
	}
}
