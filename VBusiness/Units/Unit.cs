﻿using System;
using System.Linq;
using VBusiness.Perks;
using VBusiness.Ranks;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class Unit : VUnit
	{
		public Unit(VLoadout loadout, UnitType unitType) : base(loadout, unitType)
		{
		}

		#region CurrentInfuse

		public override int CurrentInfusion
		{
			get
			{
				if (base.CurrentInfusion > MaximumInfusion)
				{
					UpdateStatsFromInfuse(MaximumInfusion - base.CurrentInfusion);
					base.CurrentInfusion = MaximumInfusion;
				}
				return base.CurrentInfusion;
			}
			set
			{
				var oldValue = base.CurrentInfusion;

				if (value > MaximumInfusion)
				{
					base.CurrentInfusion = MaximumInfusion;
				}
				else if (value < 0)
				{
					base.CurrentInfusion = 0;
				}
				else
				{
					base.CurrentInfusion = value;
				}

				if (oldValue != base.CurrentInfusion && IsCurrentUnit)
				{
					Loadout.RefreshPropertyBinding(nameof(Loadout.Units));
					Loadout.IncomeManager.RefreshPropertyBinding(nameof(Loadout.IncomeManager.LoadoutKillCost));
					Loadout.IncomeManager.RefreshPropertyBinding(nameof(Loadout.IncomeManager.LoadoutMineralCost));
					UpdateStatsFromInfuse(base.CurrentInfusion - oldValue);
				}
			}
		}

		public void UpdateStatsFromInfuse(int levelDifference)
		{
			using (Loadout.Stats.SuspendRefreshingStatBindings())
			{
				Loadout.Stats.Attack += 10 * levelDifference;
				Loadout.Stats.UpdateHealth("Core", 10 * levelDifference);
				Loadout.Stats.UpdateHealthArmor("Infuse", 10 * levelDifference);
				Loadout.Stats.UpdateShields("Core", 10 * levelDifference);
				Loadout.Stats.UpdateShieldsArmor("Infuse", 10 * levelDifference);
				Loadout.Stats.UpdateAcceleration("Infuse", 10 * levelDifference);
				// Attack Speed gets applied here via accel
			}
		}

		#endregion

		#region MaximumInfuse

		public override int MaximumInfusion
		{
			get
			{
				return IsLimitBroken && MaximumKills >= 3000
					? 10 + (MaximumKills - 2000) / 1000
					: MaximumKills >= 2000 ? 10 : MaximumKills / 200;
			}
		}

		#endregion

		#region Unit Rank

		public override VUnitRank Rank
		{
			get => base.Rank ??= new EmptyRank();
			protected set => base.Rank = value;
		}

		public override UnitRankType UnitRank
		{
			get => base.UnitRank;
			set
			{
				base.UnitRank = value;
				SetRankFromType(value);
			}
		}

		private void SetRankFromType(UnitRankType value)
		{
			var rank = Ranks.UnitRank.New(value);
			rank.Loadout = Loadout;
			Rank = rank;
		}

		#endregion

		#region CurrentEssence

		public override int EssenceStacks
		{
			get
			{
				if (base.EssenceStacks > MaximumEssence)
				{
					UpdateStatsFromEssence(MaximumEssence - base.EssenceStacks);
					base.EssenceStacks = MaximumEssence;
				}
				return base.EssenceStacks;
			}
			set
			{
				var oldValue = base.EssenceStacks;

				if (value > MaximumEssence)
				{
					base.EssenceStacks = MaximumEssence;
				}
				else if (value < 0)
				{
					base.EssenceStacks = 0;
				}
				else
				{
					base.EssenceStacks = value;
				}

				if (oldValue != base.EssenceStacks && IsCurrentUnit)
				{
					UpdateStatsFromEssence(base.EssenceStacks - oldValue);
				}
			}
		}

		public void UpdateStatsFromEssence(int levelDifference)
		{
			using (Loadout.Stats.SuspendRefreshingStatBindings())
			{
				Loadout.Stats.Attack += 5 * levelDifference;
				Loadout.Stats.UpdateHealth("Essence", 5 * levelDifference);
				Loadout.Stats.UpdateShields("Essence", 5 * levelDifference);
				Loadout.Stats.AdditiveArmor += (1 + (0.03 * Loadout.Stats.DefensiveEssenceStacks)) * levelDifference;
				Loadout.Stats.MoveSpeed += 2.5 * levelDifference;
				Loadout.Stats.UpdateAcceleration("Essence", 1, levelDifference);
				// Attack speed gets increased here via acceleration
			}
		}

		internal void RemoveStatsFromSpec(bool shouldRemove = true)
		{
			if (shouldRemove)
			{
				var specLevel = ((PerkCollection)Loadout.Perks).UnitSpecialization.DesiredLevel;
				Loadout.Stats.UpdateDamageIncrease("Spec", -2 * specLevel);
				Loadout.Stats.UpdateDamageReduction("Spec", -specLevel);
			}
		}

		internal void AddStatsFromSpec()
		{
			if (HasUnitSpec)
			{
				var specLevel = ((PerkCollection)Loadout.Perks).UnitSpecialization.DesiredLevel;
				Loadout.Stats.UpdateDamageIncrease("Spec", 2 * specLevel);
				Loadout.Stats.UpdateDamageReduction("Spec", specLevel);
			}
		}

		#endregion

		#region MaximumEssence

		public override int MaximumEssence => MaximumKills / 100;

		#endregion

		#region CurrentKills

		public override int CurrentKills
		{
			get => EssenceStacks * 100;
			set => EssenceStacks = value / 100;
		}

		#endregion

		#region MaximumKills

		public override int MaximumKills
		{
			get => GetMaxKills();
		}

		int GetMaxKills()
		{
			var max = 600;
			if (Loadout.Perks is PerkCollection perks)
			{
				max += perks.MaximumPotiential.DesiredLevel * 50;
				max += perks.MaximumPotiential2.DesiredLevel * 50;
				max += perks.MaximumPotiental3.DesiredLevel * 50;
				max += perks.MaximumPotential4.DesiredLevel * 50;
			}
			var activeSouls = Loadout.ActiveSoulTypes;

			var allowBoth = max >= 2000;
			var hungerSelected = false;
			if (activeSouls.Contains(SoulType.Hunger))
			{
				max += 200;
				hungerSelected = true;
			}
			if (activeSouls.Contains(SoulType.GhostForce) && (!hungerSelected || allowBoth))
			{
				max += 200;
			}

			if (IsLimitBroken)
			{
				max += (int)(Loadout.Perks.LimitlessEssence.DesiredLevel / 2.0) * 100;

				if (activeSouls.Contains(SoulType.BeginnerLimitBreaking))
				{
					max += 400;
				}
			}
			return max;
		}

		#endregion

		#region HasUnitSpec

		public override bool HasUnitSpec
		{
			get
			{
				var perks = (PerkCollection)Loadout.Perks;
				var hasAllSpec = perks.UnitSpecialization.DesiredLevel == 10 && perks.UpgradeCache.DesiredLevel == 1 && UnitData.Type != UnitType.None;
				return UnitData.SpecTypes.Contains(Loadout.UnitSpec)
					|| hasAllSpec;
			}
		}

		#endregion

		#region IsLimitBroken

		public override bool IsLimitBroken
		{
			get
			{
				if (base.IsLimitBroken && Loadout.Perks.LimitlessEssence.DesiredLevel == 0)
				{
					IsLimitBroken = false;
				}
				return base.IsLimitBroken;
			}
			set
			{
				var wasLimitBroken = base.IsLimitBroken;
				base.IsLimitBroken = value;

				if (base.IsLimitBroken && !wasLimitBroken)
				{
					UpdateStatsFromEssence((int)LimitlessEssenceStacks);
				}

				if (wasLimitBroken && !base.IsLimitBroken)
				{
					UpdateStatsFromEssence(-(int)LimitlessEssenceStacks);
				}
				RefreshPropertyBinding(nameof(EssenceStacks));

				Loadout.IncomeManager.RefreshPropertyBinding(nameof(Loadout.IncomeManager.LoadoutKillCost));
				Loadout.IncomeManager.RefreshPropertyBinding(nameof(Loadout.IncomeManager.LoadoutMineralCost));
				Loadout.Stats.RefreshAllBindings();
			}
		}

		public override bool IsLimitBroken_Readonly => Loadout.Perks.LimitlessEssence.DesiredLevel > 0;

		#endregion

		#region Limitless Essense

		public override int LimitlessEssenceStacks
		{
			get => base.LimitlessEssenceStacks;
			set
			{
				if (IsLimitBroken)
				{
					UpdateStatsFromEssence(value - base.LimitlessEssenceStacks);
				}
				base.LimitlessEssenceStacks = value;
			}
		}

		#endregion

		#region Calculated Stats

		public override double Attack => UnitData.BaseAttack + Upgrades.AttackUpgrade * UnitData.AttackIncrement;
		public override double AttackSpeed => UnitData.BaseAttackSpeed * Math.Pow(0.96, Upgrades.AttackSpeedUpgrade);
		public override double Health => UnitData.BaseHealth + Upgrades.HealthUpgrade * UnitData.HealthIncrement;
		public override double HealthRegen => UnitData.BaseHealthRegen + Upgrades.HealthUpgrade * UnitData.HealthRegenIncrement;
		public override double HealthArmor => UnitData.BaseHealthArmor + Upgrades.HealthArmorUpgrade * UnitData.HealthArmorIncrement;
		public override double Shields => UnitData.BaseShields + Upgrades.ShieldsUpgrade * UnitData.ShieldIncrement;
		public override double ShieldsArmor => UnitData.BaseShieldsArmor + Upgrades.ShieldsArmorUpgrade * UnitData.ShieldArmorIncrement;
		public override double ShieldsRegen => UnitData.BaseShieldsRegen + Upgrades.ShieldsUpgrade * UnitData.ShieldRegenIncrement;

		[VXML(false)]
		VUpgradeManager Upgrades => Loadout.Upgrades;

		#endregion

		#region SetDefaultValues

		protected override void SetDefaultValuesCore()
		{
			base.SetDefaultValuesCore();
			LimitlessEssenceStacks = 5;
		}

		#endregion
	}
}
