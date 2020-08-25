using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;
using VBusiness.Ranks;

namespace VBusiness
{
	public class UnitConfiguration : VUnitConfiguration
	{
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

		#region MaximumKills

		public override int MaximumKills
		{
			get => base.MaximumKills;
			set
			{
				var oldMaxInfuse = MaximumInfusion;
				base.MaximumKills = value;

				if (oldMaxInfuse != MaximumInfusion && oldMaxInfuse >= CurrentInfusion && !IsSettingDefaultValues)
				{
					CurrentInfusion = MaximumInfusion;
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