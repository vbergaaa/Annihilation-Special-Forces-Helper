﻿using System.Linq;
using VBusiness.Perks;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public abstract class Unit : VUnit
	{
		public Unit(VLoadout loadout) : base(loadout)
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
			Loadout.Stats.Health += 10 * levelDifference;
			Loadout.Stats.HealthArmor += 10 * levelDifference;
			Loadout.Stats.Shields += 10 * levelDifference;
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
			Loadout.Stats.Health += 5 * levelDifference;
			Loadout.Stats.Shields += 5 * levelDifference;
			Loadout.Stats.AdditiveArmor += (1 + (0.03 * Loadout.Stats.DefensiveEssenceStacks)) * levelDifference;
			Loadout.Stats.MoveSpeed += 2.5 * levelDifference;
			Loadout.Stats.Acceleration += 1 * levelDifference;
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
			get => base.HasUnitSpec;
			set
			{
				if (base.HasUnitSpec != value)
				{
					base.HasUnitSpec = value;
					ToggleSpec();
				}
			}
		}

		void ToggleSpec()
		{
			if (HasUnitSpec)
			{
				ActivateSpec();
			}
			else
			{
				DeactivateSpec();
			}
		}

		public void DeactivateSpec()
		{
			if (Loadout.Perks is PerkCollection perks && perks.UnitSpecialization.DesiredLevel > 0 && IsCurrentUnit)
			{
				Loadout.Stats.DamageIncrease -= 2 * perks.UnitSpecialization.DesiredLevel;
				Loadout.Stats.UpdateDamageReduction("Spec", -perks.UnitSpecialization.DesiredLevel);
			}
		}

		public void ActivateSpec()
		{
			if (Loadout.Perks is PerkCollection perks && perks.UnitSpecialization.DesiredLevel > 0 && IsCurrentUnit)
			{
				Loadout.Stats.DamageIncrease += 2 * perks.UnitSpecialization.DesiredLevel;
				Loadout.Stats.UpdateDamageReduction("Spec", perks.UnitSpecialization.DesiredLevel);
			}
		}

		#endregion

		#region SetDefaultValues

		protected override void SetDefaultValuesCore()
		{
			base.SetDefaultValuesCore();
		}

		#endregion
	}
}
