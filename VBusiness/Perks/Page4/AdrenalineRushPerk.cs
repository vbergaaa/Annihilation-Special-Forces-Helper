﻿using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class AdrenalineRushPerk : Perk
	{
		public AdrenalineRushPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Gives your units a 2% chance to gain 10% attack damage, attack speed and 5% critical chance for 3 seconds after killing a unit";

		public override byte Page => 4;

		public override byte Position => 3;

		public override int StartingCost => 150;

		public override int IncrementCost => 25;

		public override short MaxLevel => 15;

		protected override string PerkName => "Adrenaline Rush";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.Attack += 0.66666 * difference;
			PerkCollection.Loadout.Stats.AttackSpeed += 0.66666 * difference;
			PerkCollection.Loadout.Stats.CriticalChance += 0.33333 * difference;
		}
	}
}
