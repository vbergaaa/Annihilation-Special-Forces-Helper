using System;
using VBusiness.HelperClasses;
using VBusiness.Loadouts;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public abstract class Perk : VPerk
	{
		#region Constructor

		public Perk(VPerkCollection collection) : base(collection)
		{
		}

		#endregion

		#region Properties

		[VXML(false)]
		public Loadout Loadout => PerkCollection.Loadout as Loadout;

		public override int RemainingCost => this.GetRemainingCost();

		public override int CurrentCost => this.GetCurrentCost();

		public override int TotalCost => this.GetTotalCost();

		#region MaxLevel

		public override short MaxLevel
		{
			get
			{
				if (PerkCollection.Loadout.ShouldRestrict && DesiredLevel < MaxLevelCore)
				{
					return GetMaxLevel();
				}
				return MaxLevelCore;
			}
		}

		short GetMaxLevel()
		{
			var costToMax = VCalculator.Calculate(StartingCost, IncrementCost, DesiredLevel, MaxLevelCore);
			if (costToMax <= PerkCollection.Loadout.RemainingPerkPoints)
			{
				return MaxLevelCore;
			}

			return GetHighestLevelPPCanAfford();
		}

		short GetHighestLevelPPCanAfford()
		{
			var remainingPP = PerkCollection.Loadout.RemainingPerkPoints;
			for (var i = MaxLevelCore; i >= DesiredLevel; i--)
			{
				if (VCalculator.Calculate(StartingCost, IncrementCost, DesiredLevel, i) <= remainingPP)
				{
					return i;
				}
			}
			return DesiredLevel;
		}

		#endregion

		public override short DesiredLevel
		{
			get => base.DesiredLevel;
			set
			{
				if (value > MaxLevel)
				{
					base.DesiredLevel = MaxLevel;
				}
				else if (value < 0)
				{
					base.DesiredLevel = 0;
				}
				else
				{
					base.DesiredLevel = value;
				}
			}
		}

		#endregion

		public override string GetIncrementHint(int amount)
		{
			var damageIncrease = GetProposedDamageIncrease(amount);
			var toughnessIncrease = GetProposedToughnessIncrease(amount);

			var hint = string.Empty;
			if (damageIncrease != 0)
			{
				hint += $"Damage: +{Math.Round(damageIncrease, 3)}%";
				hint += "\r\n";
			}
			if (toughnessIncrease != 0)
			{
				hint += $"Toughness: +{Math.Round(toughnessIncrease, 3)}%";
				hint += "\r\n";
			}
			if (hint == string.Empty)
			{
				hint += "This gem will not affect Damage or Toughness for this unit";
			}
			return hint;
		}

		public override string GetDecrementHint(int amount)
		{
			var damageDecrease = GetProposedDamageDecrease(amount);
			var toughnessDecrease = GetProposedToughnessDecrease(amount);

			var hint = string.Empty;
			if (damageDecrease != 0)
			{
				hint += $"Damage: {Math.Round(damageDecrease, 3)}%";
				hint += "\r\n";
			}
			if (toughnessDecrease != 0)
			{
				hint += $"Toughness: {Math.Round(toughnessDecrease, 3)}%";
				hint += "\r\n";
			}
			if (hint == string.Empty)
			{
				hint += "This gem will not affect Damage or Toughness for this unit";
			}
			return hint;
		}

		public override double GetProposedDamageIncrease(int amount)
		{
			amount = GetValidAmount(amount);

			using (Loadout.Stats.SuspendRefreshingStatBindings())
			using (Loadout.BeginOptimisingStatistics())
			{
				var oldDamage = Loadout.Stats.Damage;
				OnLevelChanged(amount);
				var newDamage = Loadout.Stats.Damage;
				OnLevelChanged(-amount);
				return (newDamage / oldDamage) * 100 - 100;
			}
		}

		public override double GetProposedDamageDecrease(int amount)
		{
			amount = GetValidAmount(amount);

			using (Loadout.Stats.SuspendRefreshingStatBindings())
			using (Loadout.BeginOptimisingStatistics())
			{
				var oldDamage = Loadout.Stats.Damage;
				OnLevelChanged(-amount);
				var newDamage = Loadout.Stats.Damage;
				OnLevelChanged(amount);
				return (newDamage / oldDamage) * 100 - 100;
			}
		}

		public override double GetProposedToughnessIncrease(int amount)
		{
			amount = GetValidAmount(amount);

			using (Loadout.Stats.SuspendRefreshingStatBindings())
			using (Loadout.BeginOptimisingStatistics())
			{
				var oldToughness = Loadout.Stats.Toughness;
				OnLevelChanged(amount);
				var newToughness = Loadout.Stats.Toughness;
				OnLevelChanged(-amount);
				return (newToughness / oldToughness) * 100 - 100;
			}
		}

		public override double GetProposedToughnessDecrease(int amount)
		{
			amount = GetValidAmount(amount);

			using (Loadout.Stats.SuspendRefreshingStatBindings())
			using (Loadout.BeginOptimisingStatistics())
			{
				var oldToughness = Loadout.Stats.Toughness;
				OnLevelChanged(-amount);
				var newToughness = Loadout.Stats.Toughness;
				OnLevelChanged(amount);
				return (newToughness / oldToughness) * 100 - 100;
			}
		}

		private int GetValidAmount(int amount)
		{
			var maxIncrement = MaxLevel - DesiredLevel;
			if (amount > maxIncrement)
			{
				amount = maxIncrement;
			}

			if (amount < -DesiredLevel)
			{
				amount = -DesiredLevel;
			}

			return amount;
		}
	}
}
