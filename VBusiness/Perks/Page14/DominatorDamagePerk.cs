﻿using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class DominatorDamagePerk : Perk
	{
		public DominatorDamagePerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "+1% Damage";

		public override byte Page => 14;

		public override byte Position => 1;

		public override int StartingCost => 2000;

		public override int IncrementCost => 1000;

		protected override string PerkName => "Dominator Damage";

		protected override short MaxLevelCore => 200;

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.Attack += difference;
		}
	}
}
