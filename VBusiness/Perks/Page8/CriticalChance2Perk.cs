﻿using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class CriticalChance2Perk : Perk
	{
		public CriticalChance2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "+1% Critical Chance";

		public override byte Page => 8;

		public override byte Position => 1;

		public override int StartingCost => 600;

		public override int IncrementCost => 100;

		protected override short MaxLevelCore => 20;

		protected override string PerkName => "Critical Chance II";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.CriticalChance += 1 * difference;
		}
	}
}
