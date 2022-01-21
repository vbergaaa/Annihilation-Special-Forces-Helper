using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class MaximumPotiental3Perk : BaseMaximumPotentialPerk
	{
		public MaximumPotiental3Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increase maximum kill count and maximum life essence stacks by 50";

		public override byte Page => 9;

		public override byte Position => 3;

		public override int StartingCost => 1000;

		public override int IncrementCost => 250;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Maximum Potiental III";
	}
}
