﻿using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class ShieldsPerk : Perk
	{
		public ShieldsPerk(VPerkCollection collection) : base(collection)
		{
		}

		protected override string PerkName => "Shields";
		
		public override string Description => "+2.5% Shield\r\n+2.5% Shield Regen";

		public override byte Page => 1;

		public override byte Position => 3;

		public override int StartingCost => 15;

		public override int IncrementCost => 15;

		protected override short MaxLevelCore => 10;

		protected override void OnLevelChanged(int difference)
		{
			PerkCollection.Loadout.Stats.UpdateShields("Core", 2.5 * difference);
		}
	}
}
