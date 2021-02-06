using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class UpgradeCachePerk : Perk
	{
		public UpgradeCachePerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Enhances various perks";

		public override byte Page => 14;

		public override byte Position => 4;

		public override int StartingCost => 300000;

		public override int IncrementCost => 0;

		protected override string PerkName => "Upgrade Cache";

		protected override short MaxLevelCore => 1;
	}
}
