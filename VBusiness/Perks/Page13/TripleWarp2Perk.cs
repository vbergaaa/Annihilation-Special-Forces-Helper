﻿using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class TripleWarp2Perk : Perk
	{
		public TripleWarp2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Grants a 1% chance to warp in 2 duplicates when buying a unit";

		public override byte Page => 13;

		public override byte Position => 2;

		public override int StartingCost => 3000;

		public override int IncrementCost => 300;

		protected override string PerkName => "Triple Warp II";

		protected override short MaxLevelCore => 20;

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);
			PerkCollection.Loadout.IncomeManager.TripleWarp += difference;
		}
	}
}
