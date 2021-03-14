﻿using System;
using System.Linq;
using VBusiness.Perks;
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
					UpdateStatsFromInfuse(base.CurrentInfusion - oldValue);
				}
			}
		}

		public void UpdateStatsFromInfuse(int levelDifference)
		{
			Loadout.Stats.Attack += 10 * levelDifference;
			Loadout.Stats.UpdateAttackSpeed("Infuse", 10 * levelDifference);
			Loadout.Stats.UpdateHealth("Core", 10 * levelDifference);
			Loadout.Stats.HealthArmor += 10 * levelDifference;
			Loadout.Stats.UpdateShields("Core", 10 * levelDifference);
			Loadout.Stats.ShieldsArmor += 10 * levelDifference;
			Loadout.Stats.Acceleration += 10 * levelDifference;
		}

		#endregion

		#region MaximumInfuse

		public override int MaximumInfusion => MaximumKills > 2000 ? 10 : MaximumKills / 200;

		#endregion
		
		#region Unit Rank

		public override UnitRank UnitRank
		{
			get => base.UnitRank;
			set
			{
				base.UnitRank = value;
				Rank = Ranks.UnitRank.New(UnitRank, this);
			}
		}

		#endregion

		#region CurrentEssence

		public override int EssenceStacks
		{
			get
			{
				if (base.EssenceStacks > MaximumEssence)
				{
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
			Loadout.Stats.Attack += 5 * levelDifference;
			Loadout.Stats.UpdateAttackSpeed("Essence", 1, levelDifference);
			Loadout.Stats.UpdateHealth("Essence", 5 * levelDifference);
			Loadout.Stats.UpdateShields("Essence", 5 * levelDifference);
			Loadout.Stats.AdditiveArmor += (1 + (0.03 * Loadout.Stats.DefensiveEssenceStacks)) * levelDifference;
			Loadout.Stats.MoveSpeed += 2.5 * levelDifference;
			Loadout.Stats.Acceleration += 1 * levelDifference;
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
			if (activeSouls.Contains(SoulType.Hunger))
			{
				max += 200;
			}
			if (activeSouls.Contains(SoulType.GhostForce))
			{
				max += 200;
			}
			return max;
		}

		#endregion

		#region HasUnitSpec

		public override bool HasUnitSpec
		{
			get
			{
				//var perks = (PerkCollection)Loadout.Perks;
				//var hasAllSpec = perks.UnitSpecialization.DesiredLevel == 10 && perks.UpgradeCache.DesiredLevel == 1;
				return UnitData.SpecTypes.Contains(Loadout.UnitSpec);
				//	|| hasAllSpec;
			}
		}

		#endregion

		#region Calculated Stats

		public override double Attack => UnitData.BaseAttack + Upgrades.AttackUpgrade * UnitData.AttackIncrement;
		public override double AttackSpeed => UnitData.BaseAttackSpeed / Math.Pow(1.04, Upgrades.AttackSpeedUpgrade);
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
		}

		#endregion
	}
}
