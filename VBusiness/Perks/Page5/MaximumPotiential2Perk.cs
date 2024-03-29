﻿using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class MaximumPotiential2Perk : BaseMaximumPotentialPerk
	{
		public MaximumPotiential2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increase maximum kill count and maximum life essence stacks by 50";

		public override byte Page => 5;

		public override byte Position => 3;

		public override int StartingCost => 200;

		public override int IncrementCost => 80;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Maximum Potiential II";
	}
}
