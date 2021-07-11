﻿using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class LimitlessEssencePerk : Perk
	{
		public LimitlessEssencePerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => @"Enables limit breaking.
Increase maximum kill count and maximum life essence stacks by 50 for limit broken units";

		public override byte Page => 15;

		public override byte Position => 3;

		public override int StartingCost => 2000;

		public override int IncrementCost => 1500;

		protected override string PerkName => "Limitless Essence";

		protected override short MaxLevelCore => 60;

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);

			if (difference == DesiredLevel || DesiredLevel == 0)
			{
				PerkCollection.Loadout.IncomeManager.RefreshPropertyBinding(nameof(PerkCollection.Loadout.IncomeManager.LoadoutKillCost));
				PerkCollection.Loadout.IncomeManager.RefreshPropertyBinding(nameof(PerkCollection.Loadout.IncomeManager.LoadoutMineralCost));
				PerkCollection.Loadout.CurrentUnit.RefreshPropertyBinding(nameof(PerkCollection.Loadout.CurrentUnit.IsLimitBroken));
				PerkCollection.Loadout.CurrentUnit.RefreshPropertyBinding(nameof(PerkCollection.Loadout.CurrentUnit.IsLimitBroken_Readonly));
			}

			if (PerkCollection.Loadout.CurrentUnit.IsLimitBroken || DesiredLevel == 0)
			{
				PerkCollection.Loadout.Stats.RefreshAllBindings();
			}
			PerkCollection.Loadout.CurrentUnit.RefreshPropertyBinding("MaximumEssence");
		}
	}
}
