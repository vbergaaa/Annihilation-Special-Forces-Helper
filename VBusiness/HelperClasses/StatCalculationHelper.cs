﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using VBusiness.Difficulties;
using VBusiness.Enemies;
using VBusiness.Perks;
using VEntityFramework;
using VEntityFramework.Interfaces;
using VEntityFramework.Model;

namespace VBusiness.HelperClasses
{
	public static class StatCalculationHelper
	{
		#region GetToughness

		public static double GetToughness(VLoadout loadout)
		{
			if (loadout.UseUnitStats && loadout.CurrentUnit.UnitData.Type != UnitType.None)
			{
				var rawEnemyDamages = GetEnemyCompositionStats(loadout, CompositionOptions.AttackingUnitsOnly);

				var shieldToughness = GetShieldToughness(loadout, rawEnemyDamages, loadout.Stats);
				var healthToughness = GetHealthToughness(loadout, rawEnemyDamages, loadout.Stats);
				return shieldToughness + healthToughness;
			}
			return 0;
		}

		static double GetShieldToughness(VLoadout loadout, IEnumerable<(double Chance, EnemyStatCard Enemy)> rawEnemyDamages, VStats stats)
		{
			var enemyDamages = ApplyPlayerDamageReduction(loadout, rawEnemyDamages);
			var maxDamage = enemyDamages.Max(x => x.Enemy);
			if (maxDamage < stats.UnitShieldsArmor)
			{
				return GetMaxedOutDefensiveValue(stats.UnitShieldsArmor, stats.UnitShields, stats.DamageReduction);
			}
			else
			{
				var hitsTillDeath = GetHitsTillDeath(enemyDamages, stats.UnitShieldsArmor, stats.UnitShields);
				var totalDamageTillDeath = hitsTillDeath * rawEnemyDamages.Sum(x => (x.Chance * x.Enemy.Damage));
				return totalDamageTillDeath;
			}
		}

		static double GetHealthToughness(VLoadout loadout, IEnumerable<(double Chance, EnemyStatCard Enemy)> rawEnemyDamages, VStats stats)
		{
			var enemyDamages = ApplyPlayerDamageReduction(loadout, rawEnemyDamages);
			var maxDamage = enemyDamages.Max(x => x.Enemy);
			if (maxDamage < stats.UnitHealthArmor)
			{
				return GetMaxedOutDefensiveValue(stats.UnitHealthArmor, stats.UnitHealth, stats.DamageReduction);
			}
			else
			{
				var hitsTillDeath = GetHitsTillDeath(enemyDamages, stats.UnitHealthArmor, stats.UnitHealth);
				var totalDamageTillDeath = hitsTillDeath * rawEnemyDamages.Sum(x => (x.Chance * x.Enemy.Damage));
				return totalDamageTillDeath;
			}
		}

		static IEnumerable<(double Chance, double Enemy)> ApplyPlayerDamageReduction(VLoadout loadout, IEnumerable<(double Chance, EnemyStatCard Enemy)> rawEnemyDamages)
		{
			return rawEnemyDamages.Select(x => (x.Chance, x.Enemy.Damage * (1 - loadout.Stats.DamageReduction / 100)));
		}

		static double GetMaxedOutDefensiveValue(double armor, double unitShields, double damageReduction)
		{
			var mostDamageTaken = 2 * (armor + 0.5) * unitShields;
			return mostDamageTaken / (1 - damageReduction / 100);
		}

		static double GetHitsTillDeath(IEnumerable<(double Chance, double Damage)> enemyDamages, double armor, double amount)
		{
			var damagePerHit = enemyDamages.Select(tuple => (tuple.Chance, Math.Max(0.5, tuple.Damage - armor)));
			var averageDamagePerHit = damagePerHit.Sum(x => x.Chance * x.Item2);
			var hitsTillDeath = amount / averageDamagePerHit;

			return hitsTillDeath;
		}

		#endregion

		#region GetDamage

		public static double GetDamage(VLoadout loadout)
		{
			if (loadout.UseUnitStats && loadout.CurrentUnit.UnitData.Type != UnitType.None)
			{
				var crits = GetCritChances(loadout);
				var composition = GetEnemyCompositionStats(loadout, CompositionOptions.Normal);

				var totalDamage = 0.0;

				foreach (var weapon in loadout.CurrentUnit.UnitData.Weapons)
				{
					var damages = composition.Select(x => (x.Chance, Damage: weapon.GetDamageToEnemy(loadout, x.Enemy, crits)));
					var avgDamage = damages.Sum(x => (x.Chance * x.Damage));
					totalDamage += avgDamage;
				}
				return Math.Round(totalDamage, 2);
			}
			return 0;
		}

		static CritChances GetCritChances(VLoadout loadout)
		{
			var perks = loadout.Perks as PerkCollection;
			var stats = loadout.Stats;
			var critChances = new CritChances();

			if (stats.CriticalChance <= 0)
			{
				critChances.RegularChance = 1.0;
				return critChances;
			}

			var remainingChance = 1.0;

			var blackCritChance = perks.BlackCrits.DesiredLevel > 0 ? stats.CriticalChance / 300.0 : 0;
			blackCritChance = blackCritChance > 1 ? 1 : blackCritChance;
			critChances.BlackChance = blackCritChance;
			remainingChance -= blackCritChance;

			var redCritChance = perks.RedCrits.DesiredLevel > 0 ? remainingChance * stats.CriticalChance / 200 : 0;
			redCritChance = redCritChance > remainingChance ? remainingChance : redCritChance;
			critChances.RedChance = redCritChance;
			remainingChance -= redCritChance;

			var yellowCritChance = remainingChance * stats.CriticalChance / 100;
			yellowCritChance = yellowCritChance > remainingChance ? remainingChance : yellowCritChance;
			critChances.YellowChance = yellowCritChance;
			remainingChance -= yellowCritChance;

			critChances.RegularChance = remainingChance;

			ErrorReporter.ReportDebug("your crit calculations need to equal 100", () => Math.Round(critChances.RegularChance + critChances.YellowChance + critChances.RedChance + critChances.BlackChance, 6) != 1);
			return critChances;
		}

		#endregion

		#region GetEnemyCompositionStats

		static IEnumerable<(double Chance, EnemyStatCard Enemy)> GetEnemyCompositionStats(VLoadout loadout, CompositionOptions options)
		{
			var unitComp = GetEnemyUnitComposition(loadout, options);
			var composition = unitComp.Select(x => (x.Chance, GetEnemyStats(x.Enemy, loadout)));
			composition = ApplyTitanicDamageReduction(composition);

			if (loadout.UnitConfiguration.DifficultyLevel >= DifficultyLevel.Mythic)
			{
				composition = composition.SelectMany(x => ApplyMythicBossAttacks(x));
			}

			return composition;
		}

		static IEnumerable<(double Chance, EnemyStatCard)> ApplyTitanicDamageReduction(IEnumerable<(double Chance, EnemyStatCard Enemy)> composition)
		{
			foreach (var unit in composition)
			{
				if (!unit.Enemy.IsTitan)
				{
					yield return unit;
				}
				else
				{
					yield return (unit.Chance * (1 - GetTitanicDRChance(unit.Enemy.Type)), unit.Enemy);
					var newEnemy = unit.Enemy;
					newEnemy.UpdateDamageReduction(GetTitanicDR(unit.Enemy.Type) * 100);
					yield return (unit.Chance * GetTitanicDRChance(unit.Enemy.Type), newEnemy);
				}
			}
		}

		static IEnumerable<(double Chance, EnemyStatCard Enemy)> GetEnemyUnitComposition(VLoadout loadout, CompositionOptions options)
		{
			var difficulty = loadout.UnitConfiguration.Difficulty;
			if (UnitCompOverride != null)
			{
				return UnitCompOverride.Select(x => (x.Chance, new EnemyStatCard { Type = x.Type }));
			}
			var comp = UnitCompositionGenerator.GetComposition(difficulty, options, loadout.Mods.Tier.CurrentLevel / 10.0);

			return difficulty.Difficulty < DifficultyLevel.Titanic
				? comp.Select(x => (x.Item2, new EnemyStatCard { Type = x.Item1 }))
				: ApplyTitanicBuffedComposition(comp, difficulty.TitanChance * (1 + loadout.Mods.Difficulty.CurrentLevel / 10));
		}

		static IEnumerable<(double Chance, EnemyStatCard Enemy)> ApplyMythicBossAttacks((double Chance, EnemyStatCard Enemy) x)
		{
			if (x.Enemy.Type.IsHeroic())
			{
				yield return (x.Chance * 0.8, x.Enemy);
				x.Enemy.Damage *= 2; // we should probably make this DI on the stat card
				yield return (x.Chance * 0.2, x.Enemy);
			}
			else
			{
				yield return x;
			}
		}

		static EnemyStatCard GetEnemyStats(EnemyStatCard stats, VLoadout loadout)
		{
			var unit = EnemyUnit.New(stats.Type);
			stats.Damage = GetEnemyDamage(unit, stats.IsTitan, loadout);
			stats.Armor = GetEnemyArmor(unit, stats.IsTitan, loadout);
			stats.UpdateDamageReduction(loadout.UnitConfiguration.Difficulty.DamageReduction);
			stats.UpdateDamageReduction(loadout.Mods.DamageReduction.CurrentLevel * 6);
			stats.UpdateDamageReduction(loadout.Mods.Rank.CurrentLevel * 1);

			if (loadout.UnitConfiguration.DifficultyLevel >= DifficultyLevel.Hard)
			{
				stats.UpdateDamageReduction(10 * (1 + loadout.Mods.Potency.CurrentLevel * 0.1)); // 10DR from spire buff (can be 20% with max potency mod)
			}
			return stats;
		}

		static double GetTitanicDR(EnemyType type) => type.IsHeroic() ? 0.6 : 0.8;
		static double GetTitanicDRChance(EnemyType type) => type.IsHeroic() ? 0.3 : 0.2;
		static double GetEnemyDamage(EnemyUnit unit, bool isTitanic, VLoadout loadout)
		{
			var difficulty = loadout.UnitConfiguration.Difficulty;

			var unitDamage = unit.Attack + unit.AttackIncrement * ((int)difficulty.RoomToClear + difficulty.StartingUpgrades);

			var damageModifier = difficulty.Damage;
			if (unit.EnemyType.IsHeroic())
			{
				damageModifier += (difficulty.MythicBoss * (1 + loadout.Mods.Difficulty.CurrentLevel / 10.0)) / 100.0; // additive mythic bonus
			}

			damageModifier += Math.Pow(1.07, loadout.Mods.Damage.CurrentLevel) - 1; // additive damage mod calc (tested additive with difficulty buff, untested with rest)

			if (isTitanic)
			{
				damageModifier += unit.EnemyType.IsHeroic()
					? 0.5				// additive heroic titan buff
					: 2;				// additive regular titan buff
			}

			if (difficulty.Difficulty >= DifficultyLevel.Hard)
			{
				damageModifier += 0.2 * (1 + loadout.Mods.Potency.CurrentLevel * 0.1); // additive spire buff 'damage'
			}

			if (loadout.Mods.Rank.CurrentLevel >= (int)UnitRankType.SD)
			{
				damageModifier += 0.05; // assumed additive
			}

			unitDamage *= damageModifier;
			unitDamage *= (1 + difficulty.DamageIncrease / 100.0);
			unitDamage *= (1 + loadout.Mods.Rank.CurrentLevel / 50.0); // 2% DI per rank in mods

			return unitDamage;
		}

		static double GetEnemyArmor(EnemyUnit unit, bool hasTitanicBuff, VLoadout loadout)
		{
			var difficulty = loadout.UnitConfiguration.Difficulty;
			var baseArmor = unit.HealthArmor + ((int)difficulty.RoomToClear + difficulty.StartingUpgrades) * unit.HealthArmorIncrement;
			var totalArmor = baseArmor * difficulty.Armor;
			totalArmor *= hasTitanicBuff ? 1.5 : 1; // multiplicitive armor from titan buff
			if (unit.EnemyType.IsHeroic())
			{
				totalArmor *= (1 + difficulty.MythicBoss * (1 + loadout.Mods.Difficulty.CurrentLevel / 10.0) / 100.0); // mulitplicitive armor from mythic bonus 
			}
			if (difficulty.Difficulty >= DifficultyLevel.Hard)
			{
				totalArmor *= (1 + (0.2 * (1 + loadout.Mods.Potency.CurrentLevel * 0.1))); // spire buff, haven't tested if multiplicitive or not, assuming it is as others were
			}

			totalArmor *= Math.Pow(1.07, loadout.Mods.Armor.CurrentLevel);

			if (loadout.Mods.Rank.CurrentLevel >= (int)UnitRankType.SA)
			{
				totalArmor *= 1.05;
			}

			return totalArmor;
		}

		static IEnumerable<(double Chance, EnemyStatCard Enemy)> ApplyTitanicBuffedComposition(IEnumerable<(EnemyType, double)> comp, int titanicChance)
		{
			foreach (var unit in comp)
			{
				yield return (unit.Item2 * titanicChance / 100, new EnemyStatCard { Type = unit.Item1, IsTitan = true });
				yield return (unit.Item2 * (1 - titanicChance / 100), new EnemyStatCard { Type = unit.Item1, IsTitan = false });
			}
		}

		internal static IEnumerable<(EnemyType Type, double Chance)> UnitCompOverride;

		struct EnemyStatCard : IEnemyStatCard
		{
			public EnemyType Type { get; set; }
			public bool IsTitan { get; set; }
			public double Damage { get; set; }
			public double Armor { get; set; }
			public double DamageIncrease { get; set; }
			public double DamageReduction { get; set; }
			public void UpdateDamageReduction(double dr)
			{
				var damageTaken = 100 - DamageReduction;
				var newDamageTaken = damageTaken * (1 - dr / 100);
				DamageReduction = 100 - newDamageTaken;
			}

#if DEBUG // this is for debugging display - DebuggerDisplayAttribute doesn't appear to work for nested classes
			public override string ToString() => $"{Type} - tit:{IsTitan}, atk:{Damage}";
#endif
		}

		struct CritChances : ICritChances
		{
			public double YellowChance { get; set; }
			public double RedChance { get; set; }
			public double BlackChance { get; set; }
			public double RegularChance { get; set; }
		}

		#endregion
	}
}
