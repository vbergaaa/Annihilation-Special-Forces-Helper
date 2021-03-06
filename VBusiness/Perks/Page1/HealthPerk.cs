﻿using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class HealthPerk : Perk
	{
		public HealthPerk(VPerkCollection collection) : base(collection)
		{
		}

		protected override string PerkName => "Health";

		public override string Description => "+2.5% Health\r\n+2.5% Health Regen";

		public override byte Page => 1;

		public override byte Position => 5;

		public override int StartingCost => 15;

		public override int IncrementCost => 15;

		protected override short MaxLevelCore => 10;

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.UpdateHealth("Core", 2.5 * difference);
		}
	}
}
