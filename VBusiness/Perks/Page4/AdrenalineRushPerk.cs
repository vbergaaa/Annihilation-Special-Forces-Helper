using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class AdrenalineRushPerk : Perk
	{
		public AdrenalineRushPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Gives +2% chance to gain 10% Damage, 10% Attack Speed and 5% Critical Chance to a unit for 3 seconds after making a kill";

		public override byte Page => 4;

		public override byte Position => 3;

		public override int StartingCost => 150;

		public override int IncrementCost => 25;

		protected override short MaxLevelCore => 15;

		protected override string PerkName => "Adrenaline Rush";

		protected override void OnLevelChanged(int difference)
		{
			if (PerkCollection.Loadout.CurrentUnit.UnitData.Type > 0)
			{
				var superRushBonus = 1 + ((PerkCollection)PerkCollection).SuperRush.DesiredLevel / 10.0;

				PerkCollection.Loadout.Stats.Attack += 10.0 / 15 * difference * superRushBonus;
				PerkCollection.Loadout.Stats.UpdateAttackSpeed("AdrenalineRush", 10.0 / 15 * difference * superRushBonus);
				PerkCollection.Loadout.Stats.CriticalChance += 5.0 / 15 * difference * superRushBonus;

				var hasCache = ((PerkCollection)PerkCollection).UpgradeCache.DesiredLevel > 0;
				if (DesiredLevel == MaxLevel && hasCache)
				{
					PerkCollection.Loadout.Stats.CriticalChance += 5.0 * superRushBonus;
				}
				else if (DesiredLevel - difference == MaxLevel && hasCache)
				{
					PerkCollection.Loadout.Stats.CriticalChance -= 5.0 * superRushBonus;
				}
			}
		}
	}
}
