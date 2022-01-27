using System;
using VEntityFramework.Model;

namespace VBusiness.ChallengePoints
{
	public abstract class ChallengePoint : VChallengePoint
	{
		#region Constructor

		public ChallengePoint(VChallengePointCollection manager) : base(manager)
		{
		}

		#endregion

		#region Properties

		public override int CurrentLevel
		{
			get => base.CurrentLevel;
			set
			{
				var oldValue = base.CurrentLevel;
				if (value <= MaxValue && value >= MinValue)
				{
					base.CurrentLevel = value;
					var effectiveCPDifference = GetCPDifference(base.CurrentLevel, oldValue);
					OnCPLevelChanged(effectiveCPDifference);
					ChallengePointCollection.RefreshPropertyBinding(nameof(ChallengePointCollection.TotalCost));
					((ChallengePointCollection)ChallengePointCollection).SetAllCPLimits();
				}
			}
		}

        static int GetCPDifference(int newValue, int oldValue)
		{
			var diff = 0;
			if (newValue > oldValue)
			{
				for (var i = newValue; i > oldValue; i--)
				{
					diff += ((i + 2) / 2);
				}
			}
			else if (oldValue > newValue)
			{
				for (var i = oldValue; i > newValue; i--)
				{
					diff -= ((i + 2) / 2); 
				}
			}
			return diff;
		}

		public override int MinValue
		{
			get
			{
				if (IsLoading || CurrentLevel == 0)
				{
					return 0;
				}

				return CanSellCP()
					? CurrentLevel - 1
					: CurrentLevel;
			}
		}

		bool CanSellCP()
		{
			return ChallengePointCollection.CanSellCP(Tier, Color);
		}

		public override int MaxValue
		{
			get
			{
				if (IsLoading)
				{
					return 10;
				}

				if (HasUnlockedTier())
				{
					if (!ChallengePointCollection.Loadout.ShouldRestrict)
					{
						return 10;
					}

					return CanAffordNextLevel()
						? CurrentLevel + 1
						: CurrentLevel;
				}
				return CurrentLevel;
			}
		}

		bool CanAffordNextLevel()
		{
			return NextLevelCost <= ChallengePointCollection.RemainingCP;
		}

		bool HasUnlockedTier()
		{
			return ChallengePointCollection.HasUnlockedTier(Tier, Color);
		}

		public override int NextLevelCost => 1 + CurrentLevel * CostIncrement;

		public override int TotalCost
		{
			get
			{
				var total = 0;
				for (var i = 0; i < CurrentLevel; i++)
				{
					total += 1 + i * CostIncrement;
				}
				return total;
			}
		}

		#endregion

		#region Proposed Values

		public override string GetIncrementHint(int amount)
		{
			if (Loadout.CurrentUnit?.UnitData?.Type == UnitType.None)
			{
				return "Please select a unit to enable this functionality";
			}

			var cpChanged = GetCPDifference(base.CurrentLevel + 1, base.CurrentLevel);
			var damageIncrease = GetProposedDamageIncrease(cpChanged);
			var toughnessIncrease = GetProposedToughnessIncrease(cpChanged);

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
			if (Loadout.CurrentUnit?.UnitData?.Type == UnitType.None)
			{
				return "Please select a unit to enable this functionality";
			}

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
			using (Loadout.Stats.SuspendRefreshingStatBindings())
			{
				var oldDamage = Loadout.Stats.Damage;
				OnCPLevelChanged(amount);
				var newDamage = Loadout.Stats.Damage;
				OnCPLevelChanged(-amount);
				return (newDamage / oldDamage) * 100 - 100;
			}
		}

		public override double GetProposedDamageDecrease(int amount)
		{
			using (Loadout.Stats.SuspendRefreshingStatBindings())
			{
				var oldDamage = Loadout.Stats.Damage;
				OnCPLevelChanged(-amount);
				var newDamage = Loadout.Stats.Damage;
				OnCPLevelChanged(amount);
				return (newDamage / oldDamage) * 100 - 100;
			}
		}

		public override double GetProposedToughnessIncrease(int amount)
		{
			using (Loadout.Stats.SuspendRefreshingStatBindings())
			{
				var oldToughness = Loadout.Stats.Toughness;
				OnCPLevelChanged(amount);
				var newToughness = Loadout.Stats.Toughness;
				OnCPLevelChanged(-amount);
				return (newToughness / oldToughness) * 100 - 100;
			}
		}

		public override double GetProposedToughnessDecrease(int amount)
		{
			using (Loadout.Stats.SuspendRefreshingStatBindings())
			{
				var oldToughness = Loadout.Stats.Toughness;
				OnCPLevelChanged(-amount);
				var newToughness = Loadout.Stats.Toughness;
				OnCPLevelChanged(amount);
				return (newToughness / oldToughness) * 100 - 100;
			}
		}

		#endregion
	}
}
