using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class UpgradeCachePerk : Perk
	{
		public UpgradeCachePerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => @"Kill Recycle: -1 Second Cooldown
Rank: -50% Cooldown
Adrenaline Rush: +5% Critical Chance
Over Speed: +1 Move Speed
Unit Specialisation: Applies to all units
Quick Start: +2 uses
Expert Miner: +5 mining amount
Critical Collection: +3 Kills, +10% chance
Trifecta: applies again without armor at rank Z
Mining Expertise: +1 Kill Resource
Accelerated Fusion: -5% infuse time
Cooldown Speed: +20% Cooldown Speed
Super Rush: -2% fear chance
DNA Start: +1 base dna1 infuse";

		public override byte Page => 14;

		public override byte Position => 4;

		public override int StartingCost => 300000;

		public override int IncrementCost => 0;

		protected override string PerkName => "Upgrade Cache";

		protected override short MaxLevelCore => 1;

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);
			var perks = PerkCollection as PerkCollection;

			ApplyCooldownSpeedBonus(difference, perks);
			ApplyAdrenalineRushBonus(difference, perks);
			ApplyTrifectaBonus(difference, perks);

			PerkCollection.Loadout.IncomeManager.RefreshPropertyBinding(nameof(PerkCollection.Loadout.IncomeManager.LoadoutMineralCost));
		}

		void ApplyTrifectaBonus(int difference, PerkCollection perks)
		{
			if (perks.TrifectaPower.DesiredLevel == perks.TrifectaPower.MaxLevel && PerkCollection.Loadout.CurrentUnit.UnitRank >= UnitRankType.Z)
			{
				PerkCollection.Loadout.Stats.Attack += 15 * difference;
				PerkCollection.Loadout.Stats.UpdateAttackSpeed("Trifecta", 15 * difference);
				PerkCollection.Loadout.Stats.UpdateHealth("Core", 15 * difference);
				PerkCollection.Loadout.Stats.UpdateShields("Core", 15 * difference);
			}
		}

		void ApplyAdrenalineRushBonus(int difference, PerkCollection perks)
		{
			if (perks.AdrenalineRush.DesiredLevel == perks.AdrenalineRush.MaxLevel)
			{
				var superRushMultipler = 1 + perks.SuperRush.DesiredLevel * 1.0 / perks.SuperRush.MaxLevel;
				PerkCollection.Loadout.Stats.CriticalChance += 5 * superRushMultipler * difference;
			}
		}

		void ApplyCooldownSpeedBonus(int difference, PerkCollection perks)
		{
			if (perks.CooldownSpeed.DesiredLevel == perks.CooldownSpeed.MaxLevel)
			{
				PerkCollection.Loadout.Stats.CooldownReduction += 20 * difference;
			}
		}
	}
}
