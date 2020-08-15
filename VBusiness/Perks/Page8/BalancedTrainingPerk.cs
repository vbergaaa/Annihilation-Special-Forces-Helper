﻿using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class BalancedTrainingPerk : Perk
	{
		public BalancedTrainingPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increase damage, attack speed, vitals, vital armor by 1%";

		public override byte Page => 8;

		public override byte Position => 3;

		public override int StartingCost => 1000;

		public override int IncrementCost => 200;

		public override short MaxLevel => 10;

		protected override string PerkName => "Balanced Training";

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.Attack += 1 * difference;
			PerkCollection.Loadout.Stats.AttackSpeed += 1 * difference;
			PerkCollection.Loadout.Stats.Health += 1 * difference;
			PerkCollection.Loadout.Stats.HealthArmor += 1 * difference;
			PerkCollection.Loadout.Stats.Shields += 1 * difference;
			PerkCollection.Loadout.Stats.ShieldsArmor += 1 * difference;
		}
	}
}
