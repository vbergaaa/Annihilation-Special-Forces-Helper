﻿using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class MaximumPotiental3Perk : Perk
	{
		public MaximumPotiental3Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increase maximun kill count and maximun life essence stacks by 50";

		public override byte Page => 9;

		public override byte Position => 3;

		public override int StartingCost => 1000;

		public override int IncrementCost => 250;

		public override short MaxLevel => 10;

		protected override string PerkName => "Maximum Potiental III";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.UnitConfiguration.MaximumKills += 50 * difference;
		}
	}
}
