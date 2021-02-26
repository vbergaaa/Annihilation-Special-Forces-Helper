using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class MaximumPotential4Perk : Perk
	{
		public MaximumPotential4Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increase maximum kill count and maximum life essence stacks by 50";

		public override byte Page => 12;

		public override byte Position => 2;

		public override int StartingCost => 1200;

		public override int IncrementCost => 350;

		protected override string PerkName => "Maximum Potential IV";

		protected override short MaxLevelCore => 10;

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.CurrentUnit.RefreshPropertyBinding("MaximumInfusion");
			PerkCollection.Loadout.CurrentUnit.RefreshPropertyBinding("MaximumEssence");
		}
	}
}
