using VEntityFramework.Model;
using VBusiness.Perks;

namespace VBusiness
{
	public class UnitConfiguration : VUnitConfiguration
	{
		// Torment Reduction

		// Toggle Spec

		// toggle adrenaline rush

		#region Constructor

		public UnitConfiguration(VLoadout loadout) : base(loadout)
		{
		}

		#endregion

		#region Properties

		#region Unit Configuration

		public override UnitRank UnitRank
		{
			get => base.UnitRank;
			set
			{
				base.UnitRank = value;
				Rank = Ranks.Rank.New(UnitRank, this);
			}
		}

		#endregion

		#region CurrentInfuse

		public override int CurrentInfusion
		{
			get => base.CurrentInfusion;
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
				
				if (oldValue != base.CurrentInfusion)
				{
					UpdateStatsFromInfuse(base.CurrentInfusion - oldValue);
				}
			}
		}

		void UpdateStatsFromInfuse(int levelDifference)
		{
			Loadout.Stats.Attack += 10 * levelDifference;
			Loadout.Stats.AttackSpeed += 10 * levelDifference;
			Loadout.Stats.Health += 10 * levelDifference;
			Loadout.Stats.HealthArmor += 10 * levelDifference;
			Loadout.Stats.Shields += 10 * levelDifference;
			Loadout.Stats.ShieldsArmor += 10 * levelDifference;
		}

		#endregion

		#region MaximumInfuse

		public override int MaximumInfusion => MaximumKills > 2000 ? 10 : MaximumKills / 200;

		#endregion

		#region CurrentEssence

		public override int EssenceStacks
		{
			get => base.EssenceStacks;
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

				if (oldValue != base.EssenceStacks)
				{
					UpdateStatsFromEssence(base.EssenceStacks - oldValue);
				}
			}
		}

		void UpdateStatsFromEssence(int levelDifference)
		{
			Loadout.Stats.Attack += 5 * levelDifference;
			Loadout.Stats.AttackSpeed += 1 * levelDifference;
			Loadout.Stats.Health += 5 * levelDifference;
			Loadout.Stats.Shields += 5 * levelDifference;
			Loadout.Stats.AdditiveArmor += 1 * levelDifference;
			Loadout.Stats.MoveSpeed += 2.5 * levelDifference;
			Loadout.Stats.CooldownReduction += 1 * levelDifference;
		}

		#endregion

		#region MaximumEssence

		public override int MaximumEssence => MaximumKills / 100;

		#endregion

		#region MaximumKills

		public override int MaximumKills
		{
			get => base.MaximumKills;
			set
			{
				var oldMaxInfuse = MaximumInfusion;
				var oldMaxEssence = MaximumEssence;
				base.MaximumKills = value;

				if (oldMaxInfuse != MaximumInfusion && oldMaxInfuse >= CurrentInfusion && !IsSettingDefaultValues)
				{
					CurrentInfusion = MaximumInfusion;
				}
				if (oldMaxEssence != MaximumEssence && oldMaxEssence >= EssenceStacks && !IsSettingDefaultValues)
				{
					EssenceStacks = MaximumEssence;
				}
			}
		}

		#endregion

		#region HasSoloBonus

		public override bool HasSoloBonus
		{
			get => base.HasSoloBonus;
			set
			{
				if (base.HasSoloBonus != value)
				{
					base.HasSoloBonus = value;
					TriggerSoloBonus();
				}
			}
		} 

		void TriggerSoloBonus()
		{
			if (HasSoloBonus)
			{
				Loadout.Stats.Attack += 30;
				Loadout.Stats.AttackSpeed += 20;
				Loadout.Stats.Health += 25;
				Loadout.Stats.HealthArmor += 20;
				Loadout.Stats.Shields += 25;
				Loadout.Stats.ShieldsArmor += 20;
			}
			else
			{
				Loadout.Stats.Attack -= 30;
				Loadout.Stats.AttackSpeed -= 20;
				Loadout.Stats.Health -= 25;
				Loadout.Stats.HealthArmor -= 20;
				Loadout.Stats.Shields -= 25;
				Loadout.Stats.ShieldsArmor -= 20;
			}
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
					ToggleSpec(value);
				}
			}
		}

		void ToggleSpec(bool hasSpec)
		{
			if (Loadout.Perks is PerkCollection perks && perks.UnitSpecialization.DesiredLevel > 0)
			{
				if (hasSpec)
				{
					Loadout.Stats.DamageIncrease += 2 * perks.UnitSpecialization.DesiredLevel;
					Loadout.Stats.DamageReduction += perks.UnitSpecialization.DesiredLevel;
				}
				else
				{
					Loadout.Stats.DamageIncrease -= 2 * perks.UnitSpecialization.DesiredLevel;
					Loadout.Stats.DamageReduction -= perks.UnitSpecialization.DesiredLevel;
				}
			}
		}

		#endregion

		#endregion

		#region Methods

		#region SetDefaultValues

		protected override void SetDefaultValuesCore()
		{
			base.SetDefaultValuesCore();

			MaximumKills = 600;
		}

		#endregion

		#endregion
	}
}