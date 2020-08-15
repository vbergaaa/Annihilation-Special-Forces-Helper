using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class RankPerk : Perk
	{
		public RankPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Allows units to be ranked to increase power even further";

		public override byte Page => 2;

		public override byte Position => 5;

		public override int StartingCost => 1000;

		public override int IncrementCost => 0;

		public override short MaxLevel => 1;

		protected override string PerkName => "Rank";
	}
}
