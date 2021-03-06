﻿using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class DoubleWarpPerk : Perk
	{
		public DoubleWarpPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Grants a 1% chance to warp in a duplicate when buying a unit";

		public override byte Page => 3;

		public override byte Position => 1;

		public override int StartingCost => 70;

		public override int IncrementCost => 30;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Double Warp";

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);
			PerkCollection.Loadout.Gems.RefreshPropertyBinding("EconomyGem");
			PerkCollection.Loadout.Gems.RefreshPropertyBinding("RemainingGems");
			PerkCollection.Loadout.IncomeManager.DoubleWarp += difference;

			var currentPerkDW = PerkCollection.DoubleWarp.DesiredLevel
				+ PerkCollection.DoubleWarp2.DesiredLevel
				+ PerkCollection.DoubleWarp3.DesiredLevel
				+ PerkCollection.DoubleWarp4.DesiredLevel;

			if (currentPerkDW == 100)
			{
				PerkCollection.Loadout.IncomeManager.DoubleWarp -= PerkCollection.Loadout.Gems.DoubleWarpGem.CurrentLevel;
				PerkCollection.Loadout.IncomeManager.TripleWarp += PerkCollection.Loadout.Gems.TripleWarpGem.CurrentLevel;
			}
			else if (currentPerkDW - difference == 100)
			{
				PerkCollection.Loadout.IncomeManager.DoubleWarp += PerkCollection.Loadout.Gems.DoubleWarpGem.CurrentLevel;
				PerkCollection.Loadout.IncomeManager.TripleWarp -= PerkCollection.Loadout.Gems.TripleWarpGem.CurrentLevel;
			}
		}
	}
}
