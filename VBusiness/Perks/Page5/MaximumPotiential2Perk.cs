﻿using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class MaximumPotiential2Perk : Perk
	{
		public MaximumPotiential2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increase maximun kill count and maximun life essence stacks by 50";

		public override byte Page => 5;

		public override byte Position => 3;

		public override int StartingCost => 200;

		public override int IncrementCost => 80;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Maximum Potiential II";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.UnitConfiguration.MaximumKills += 50 * difference;
		}
	}
}
