using System;
using VBusiness.Loadouts;
using VEntityFramework.Model;

namespace VBusiness.Gems
{
	abstract class Gem : VGem
	{
		#region Constructor

		public Gem(VGemCollection collection) : base(collection)
		{
		}

		#endregion

		#region Properties

		public override short MaxValue
		{
			get
			{
				if (GemCollection.Loadout.ShouldRestrict)
				{
					return GetMaxValue();
				}
				return short.MaxValue;
			}
		}

		short GetMaxValue()
		{
			var currentCost = GetTotalCost();
			var totalCost = currentCost;
			var remainingGems = GemCollection.RemainingGems;
			var level = CurrentLevel;
			while (totalCost - currentCost <= remainingGems)
			{
				totalCost += GetCostOfLevel(level);
				level++;
			}
			return --level;
		}

		public override string GetIncrementHint(int count)
		{
			var damageIncrease = GetProposedDamageIncrease(count);
			var toughnessIncrease = GetProposedToughnessIncrease(count);

			var hint = string.Empty;
			if (damageIncrease > 0)
			{
				hint += $"Damage: +{Math.Round(damageIncrease, 3)}%";
				hint += "\r\n";
			}
			if (toughnessIncrease > 0)
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

		public override double GetProposedToughnessIncrease(int count)
		{
			using (Loadout.Stats.SuspendRefreshingStatBindings())
			{
				var oldToughness = Loadout.Stats.Toughness;
				OnPerkLevelChanged(count);
				var newToughness = Loadout.Stats.Toughness;
				OnPerkLevelChanged(-count);
				return (newToughness / oldToughness) * 100 - 100;
			}
		}

		public override double GetProposedDamageIncrease(int count)
		{
			using (Loadout.Stats.SuspendRefreshingStatBindings())
			{
				var oldDamage = Loadout.Stats.Damage;
				OnPerkLevelChanged(count);
				var newDamage = Loadout.Stats.Damage;
				OnPerkLevelChanged(-count);
				return (newDamage / oldDamage) * 100 - 100;
			}
		}

		public override string GetDecrementHint(int count)
		{
			var stats = Loadout.Stats;
			var damageDecrease = 0.0;
			var toughnessDecrease = 0.0;

			using (stats.SuspendRefreshingStatBindings())
			{
				var oldDamage = Loadout.Stats.Damage;
				var oldToughness = Loadout.Stats.Toughness;
				OnPerkLevelChanged(-count);
				var newDamage = Loadout.Stats.Damage;
				var newToughness = Loadout.Stats.Toughness;
				OnPerkLevelChanged(count);

				damageDecrease = (newDamage / oldDamage) * 100 - 100;
				toughnessDecrease = (newToughness / oldToughness) * 100 - 100;
			}

			var hint = string.Empty;
			if (damageDecrease < 0)
			{
				hint += $"Damage: {Math.Round(damageDecrease, 3)}%";
				hint += "\r\n";
			}
			if (toughnessDecrease < 0)
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

		#endregion

		#region Methods

		#region GetTotalCost

		public override int GetTotalCost()
		{
			var ret = 0;
			for (var i = 0; i < CurrentLevel; i++)
			{
				ret += GetCostOfLevel(i);
			}
			return ret;
		}

		#endregion

		#region GetCostOfNextLevel

		public override int GetCostOfNextLevel()
		{
			return GetCostOfLevel(CurrentLevel);
		}

		int GetCostOfLevel(int level)
		{
			return (int)(BaseCost + IncrementCost * level);
		}

		#endregion

		#endregion
	}
}
