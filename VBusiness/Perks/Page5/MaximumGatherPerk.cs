﻿using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class MaximumGatherPerk : Perk
	{
		public MaximumGatherPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Grants a +5% chance to gain a Kill Resource whenever a unit with max kills obtains a kill";

		public override byte Page => 5;

		public override byte Position => 4;

		public override int StartingCost => 200;

		public override int IncrementCost => 50;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Maximum Gather";

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);

			PerkCollection.Loadout.IncomeManager.MaximumGather += 5 * difference;
		}
	}
}
