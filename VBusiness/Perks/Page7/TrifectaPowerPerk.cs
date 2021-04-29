using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class TrifectaPowerPerk : Perk
	{
		public TrifectaPowerPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "When ranking to SSS, give units:\r\n+1.5% Damage\r\n+1.5% Attack Speed\r\n+1.5% Vitals\r\n+1.5% Acceleration\r\n+1% Armor";

		public override byte Page => 7;

		public override byte Position => 1;

		public override int StartingCost => 2000;

		public override int IncrementCost => 500;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Trifecta Power";

		protected override void OnLevelChanged(int diff)
		{
			if (PerkCollection.Loadout.CurrentUnit.UnitRank >= UnitRankType.SSS)
			{
				PerkCollection.Loadout.Stats.Attack += 1.5 * diff;
				PerkCollection.Loadout.Stats.UpdateAttackSpeed("Trifecta", 1.5 * diff);
				PerkCollection.Loadout.Stats.UpdateHealth("Core", 1.5 * diff);
				PerkCollection.Loadout.Stats.HealthArmor += 1 * diff;
				PerkCollection.Loadout.Stats.UpdateShields("Core", 1.5 * diff);
				PerkCollection.Loadout.Stats.ShieldsArmor += 1 * diff;
			}

			if (PerkCollection.Loadout.CurrentUnit.UnitRank >= UnitRankType.Z && ((PerkCollection)PerkCollection).UpgradeCache.DesiredLevel > 0)
			{
				if (DesiredLevel == MaxLevel)
				{
					PerkCollection.Loadout.Stats.Attack += 15;
					PerkCollection.Loadout.Stats.UpdateAttackSpeed("Trifecta", 15);
					PerkCollection.Loadout.Stats.UpdateHealth("Core", 15);
					PerkCollection.Loadout.Stats.UpdateShields("Core", 15);
				}
				if (DesiredLevel - diff == MaxLevel)
				{
					PerkCollection.Loadout.Stats.Attack -= 15;
					PerkCollection.Loadout.Stats.UpdateAttackSpeed("Trifecta", -15);
					PerkCollection.Loadout.Stats.UpdateHealth("Core", -15);
					PerkCollection.Loadout.Stats.UpdateShields("Core", -15);
				}
			}
		}
	}
}
