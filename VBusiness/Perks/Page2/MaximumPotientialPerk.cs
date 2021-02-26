﻿using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class MaximumPotientialPerk : Perk
	{
		public MaximumPotientialPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increase maximum kill count and maximum life essence stacks by 50";

		public override byte Page => 2;

		public override byte Position => 3;

		public override int StartingCost => 30;

		public override int IncrementCost => 20;

		protected override short MaxLevelCore => 8;

		protected override string PerkName => "Maximum Potiential";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.CurrentUnit.RefreshPropertyBinding("MaximumInfusion");
			PerkCollection.Loadout.CurrentUnit.RefreshPropertyBinding("MaximumEssence");
		}
	}
}
