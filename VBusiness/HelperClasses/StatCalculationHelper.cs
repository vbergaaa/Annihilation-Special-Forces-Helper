using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using VBusiness.Difficulties;
using VBusiness.Enemies;
using VBusiness.Perks;
using VEntityFramework;
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
				var difficulty = loadout.UnitConfiguration.Difficulty;
				var rawEnemyDamages = GetEnemyCompositionStats(difficulty, CompositionOptions.AttackingUnitsOnly);

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
				var composition = GetEnemyCompositionStats(loadout.UnitConfiguration.Difficulty, CompositionOptions.Normal);
				var baseDamages = GetBaseDamageDealt(composition, loadout);
				var totalDamages = ApplyCrits(baseDamages, crits, loadout.Stats.CriticalDamage);
				var averageDamagePerHit = totalDamages.Sum(x => (x.Chance * x.Damage));
				var dps = averageDamagePerHit / loadout.Stats.UnitAttackSpeed * loadout.CurrentUnit.UnitData.AttackCount;

				return Math.Round(dps, 2);
			}
			return 0;
		}

		static CritChances GetCritChances(VLoadout loadout)
		{
			var perks = loadout.Perks as PerkCollection;
			var stats = loadout.Stats;
			var critChances = new CritChances();

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

			ErrorReporter.ReportDebug(critChances.RegularChance + critChances.YellowChance + critChances.RedChance + critChances.BlackChance != 1, "your crit calculations need to equal 100");
			return critChances;
		}

		static IEnumerable<(double Chance, double Damage, double VoidBuffBonus)> GetBaseDamageDealt(IEnumerable<(double Chance, EnemyStatCard Enemy)> compositionStats, VLoadout loadout)
		{
			var unitDamage = loadout.Stats.UnitAttack;
			unitDamage *= loadout.Stats.DamageIncrease / 100;
			unitDamage *= (1 - loadout.UnitConfiguration.Difficulty.DamageReduction / 100.0);
			if (loadout.UnitConfiguration.DifficultyLevel >= DifficultyLevel.Hard)
			{
				unitDamage *= (1 - 0.1); // 10DR from spire buff
			}
			var hasQuasarBuff = loadout.CurrentUnit.UnitRank >= UnitRankType.SXDZ;
			var hasVoidBuff = loadout.CurrentUnit.UnitRank >= UnitRankType.XYZ;

			return compositionStats.SelectMany(x => GetTotalDamageDealt(x.Chance, x.Enemy, unitDamage, hasQuasarBuff, hasVoidBuff));
		}

		static IEnumerable<(double Chance, double Damage, double VoidBuffBonus)> GetTotalDamageDealt(double chance, EnemyStatCard stats, double damage, bool hasQuasarBuff, bool hasVoidBuff)
		{
			if (hasQuasarBuff)
			{
				stats.Armor *= 1 - 0.3;
			}

			var voidBuffBonus = hasVoidBuff ? stats.Armor / 5 : 0;

			if (stats.TitanicDRChance > 0)
			{
				yield return (chance * stats.TitanicDRChance, Math.Max(damage * (1 - stats.TitanicDR) - stats.Armor, 0.5), voidBuffBonus);
				yield return (chance * (1 - stats.TitanicDRChance), Math.Max(damage - stats.Armor, 0.5), voidBuffBonus);
			}
			else
			{
				yield return (chance, Math.Max(damage - stats.Armor, 0.5), voidBuffBonus);
			}
		}

		static IEnumerable<(double Chance, double Damage)> ApplyCrits(IEnumerable<(double Chance, double Damage, double VoidBuffBonus)> damages, CritChances crits, double critDamage)
		{
			return damages.Select(e => (e.Chance, e.Damage * GetCritDamageModifier(crits, critDamage, e.VoidBuffBonus)));
		}

		static double GetCritDamageModifier(CritChances crits, double critDamage, double voidBuff)
		{
			var totalCritDamage = critDamage / 100.0 + ((int)voidBuff) / 100.0;
			var avgCritMultiplier = (1 * crits.RegularChance)
				+ (1 + totalCritDamage) * crits.YellowChance
				+ (1 + 2 * totalCritDamage) * crits.RedChance
				+ (1 + 3.5 * totalCritDamage) * crits.BlackChance;
			return avgCritMultiplier;
		}

		#endregion

		#region GetEnemyCompositionStats

		static IEnumerable<(double Chance, EnemyStatCard Enemy)> GetEnemyCompositionStats(VDifficulty difficulty, CompositionOptions options)
		{
			var unitComp = GetEnemyUnitComposition(difficulty, options);
			var composition = unitComp.Select(x => (x.Chance, GetEnemyStats(x.Enemy, difficulty)));

			if (difficulty.Difficulty >= DifficultyLevel.Mythic)
			{
				composition = composition.SelectMany(x => ApplyMythicBossAttacks(x));
			}

			return composition;
		}

		static IEnumerable<(double Chance, EnemyStatCard Enemy)> GetEnemyUnitComposition(VDifficulty difficulty, CompositionOptions options)
		{
			if (UnitCompOverride != null)
			{
				return UnitCompOverride.Select(x => (x.Item2, new EnemyStatCard { Type = x.Item1 }));
			}
			var comp = UnitCompositionGenerator.GetComposition(difficulty, options);
			if (difficulty.Difficulty < DifficultyLevel.Titanic)
			{
				return comp.Select(x => (x.Item2, new EnemyStatCard { Type = x.Item1 }));
			}
			else
			{
				return ApplyTitanicBuffedComposition(comp, difficulty.TitanChance);
			}
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

		static EnemyStatCard GetEnemyStats(EnemyStatCard stats, VDifficulty difficulty)
		{
			var unit = EnemyUnit.New(stats.Type);
			stats.Damage = GetEnemyDamage(unit, stats.IsTitan, difficulty);
			stats.Armor = GetEnemyArmor(unit, stats.IsTitan, difficulty);
			stats.TitanicDR = stats.IsTitan ? GetTitanicDR(stats.Type) : 0;
			stats.TitanicDRChance = stats.IsTitan ? GetTitanicDRChance(stats.Type) : 0;
			return stats;
		}

		static double GetTitanicDR(EnemyType type) => type.IsHeroic() ? 0.6 : 0.8;
		static double GetTitanicDRChance(EnemyType type) => type.IsHeroic() ? 0.3 : 0.2;
		static double GetEnemyDamage(EnemyUnit unit, bool isTitanic, VDifficulty difficulty)
		{
			var unitDamage = unit.Attack + unit.AttackIncrement * ((int)difficulty.RoomToClear + difficulty.StartingUpgrades);
			var damageModifier = difficulty.Damage;
			if (unit.EnemyType.IsHeroic())
			{
				damageModifier += difficulty.MythicBoss / 100.0; // additive mythic bonus
			}

			if (isTitanic)
			{
				damageModifier += unit.EnemyType.IsHeroic()
					? 0.5				// additive heroic titan buff
					: 2;				// additive regular titan buff
			}

			if (difficulty.Difficulty >= DifficultyLevel.Hard)
			{
				damageModifier += 0.2; // assumed additive spire buff
			}
			unitDamage *= damageModifier;
			unitDamage *= (1 + difficulty.DamageIncrease / 100.0);
			return unitDamage;
		}

		static double GetEnemyArmor(EnemyUnit unit, bool hasTitanicBuff, VDifficulty difficulty)
		{
			var baseArmor = unit.HealthArmor + ((int)difficulty.RoomToClear + difficulty.StartingUpgrades) * unit.HealthArmorIncrement;
			var totalArmor = baseArmor * difficulty.Armor;
			totalArmor *= hasTitanicBuff ? 1.5 : 1; // multiplicitive armor from titan buff
			if (unit.EnemyType.IsHeroic())
			{
				totalArmor *= (1 + difficulty.MythicBoss / 100.0); // mulitplicitive armor from mythic bonus 
			}
			if (difficulty.Difficulty >= DifficultyLevel.Hard)
			{
				totalArmor *= (1 + 0.2); // spire buff, haven't tested if multiplicitive or not, assuming it is as others were
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

		struct EnemyStatCard
		{
			public EnemyType Type { get; set; }
			public bool IsTitan { get; set; }
			public double Damage { get; set; }
			public double Armor { get; set; }
			public double TitanicDR{ get; set; }
			public double TitanicDRChance{ get; set; }
			public double DamageIncrease { get; set; }

#if DEBUG // this is for debugging display - DebuggerDisplayAttribute doesn't appear to work for nested classes
			public override string ToString() => $"{Type} - tit:{IsTitan}, atk:{Damage}";
#endif
		}

		struct CritChances
		{
			public double YellowChance { get; set; }
			public double RedChance { get; set; }
			public double BlackChance { get; set; }
			public double RegularChance { get; set; }
		}

		#endregion
	}
}
