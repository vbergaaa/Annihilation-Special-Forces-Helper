﻿using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class KillEfficiencyPerk : Perk
	{
		public KillEfficiencyPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Grants a 3% chance to gain an extra kill upon killing an enemy unit";

		public override byte Page => 2;

		public override byte Position => 1;

		public override int StartingCost => 50;

		public override int IncrementCost => 25;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Kill Efficency";
	}
}
