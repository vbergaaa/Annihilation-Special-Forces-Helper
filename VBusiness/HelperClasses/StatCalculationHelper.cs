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
		public static double GetToughness(VLoadout loadout)
		{
			if (loadout.UseUnitStats && loadout.CurrentUnit != null)
			{
				var difficulty = loadout.UnitConfiguration.Difficulty;
				var rawEnemyDamages = GetEnemyCompositionStats(difficulty, CompositionOptions.AttackingUnitsOnly);
				var enemyDamages = ApplyDifficultyModifiers(loadout, rawEnemyDamages);

				var hitsTillDeath = GetHitsTillDeath(enemyDamages, loadout.Stats);
				var totalDamageTillDeath = hitsTillDeath * rawEnemyDamages.Sum(x => (x.Chance * x.Enemy.Damage));
				return totalDamageTillDeath;
			}
			return 0;
		}

		static IEnumerable<(double Chance, double)> ApplyDifficultyModifiers(VLoadout loadout, IEnumerable<(double Chance, EnemyStatCard Enemy)> rawEnemyDamages)
		{
			if (loadout.UnitConfiguration.DifficultyLevel >= DifficultyLevel.Mythic)
			{
				rawEnemyDamages = rawEnemyDamages.SelectMany(x => ApplyMythicBossAttacks(x));
			}

			return rawEnemyDamages.Select(x => (x.Chance, x.Enemy.Damage * (1 - loadout.Stats.DamageReduction / 100)));
		}

		private static IEnumerable<(double Chance, EnemyStatCard Enemy)> ApplyMythicBossAttacks((double Chance, EnemyStatCard Enemy) x)
		{
			if (x.Enemy.Type.IsHeroic())
			{
				yield return (x.Chance * 0.8, x.Enemy);
				x.Enemy.Damage *= 2;
				yield return (x.Chance * 0.2, x.Enemy);
			}
			else
			{
				yield return x;
			}
		}

		public static double GetDamage(VLoadout loadout)
		{
			if (loadout.UseUnitStats && loadout.CurrentUnit != null)
			{
				var crits = GetCritChances(loadout);
				var composition = GetEnemyCompositionStats(loadout.UnitConfiguration.Difficulty, CompositionOptions.Normal);
				var damages = GetBaseDamageDealt(composition, loadout);
				damages = ApplyCrits(damages, crits, loadout.Stats.CriticalDamage);
				var averageDamagePerHit = damages.Sum(x => (x.Chance * x.Damage));
				var dps = averageDamagePerHit / loadout.Stats.UnitAttackSpeed * loadout.CurrentUnit.UnitData.AttackCount;

				return Math.Round(dps, 2);
			}
			return 0;
		}

		static IEnumerable<(double, double)> ApplyCrits(IEnumerable<(double, double)> damages, CritChances crits, double critDamage)
		{
			critDamage /= 100.0;
			var avgCritMultiplier = (1 * crits.RegularChance)
				+ (1 + critDamage) * crits.YellowChance
				+ (1 + 2 * critDamage) * crits.RedChance
				+ (1 + 3.5 * critDamage) * crits.BlackChance;
			return damages.Select(e => (e.Item1, e.Item2 * avgCritMultiplier));
		}

		static IEnumerable<(double Chance, double Damage)> GetBaseDamageDealt(IEnumerable<(double Chance, EnemyStatCard Enemy)> compositionStats, VLoadout loadout)
		{
			var unitDamage = loadout.Stats.UnitAttack;
			unitDamage *= loadout.Stats.DamageIncrease / 100;
			unitDamage *= (1 - loadout.UnitConfiguration.Difficulty.DamageReduction / 100.0); 

			return compositionStats.SelectMany(x => GetTotalDamageDealt(x.Chance, x.Enemy, unitDamage));
		}

		static IEnumerable<(double, double)> GetTotalDamageDealt(double chance, EnemyStatCard stats, double damage)
		{
			if (stats.TitanicDRChance > 0)
			{
				yield return (chance * stats.TitanicDRChance, Math.Max(damage * (1 - stats.TitanicDR) - stats.Armor, 0.5));
				yield return (chance * (1 - stats.TitanicDRChance), Math.Max(damage - stats.Armor, 0.5));
			}
			else
			{
				yield return (chance, Math.Max(damage - stats.Armor, 0.5));
			}
		}

		static double GetEnemyArmorForDifficulty(EnemyUnit unit, bool hasTitanicBuff, VDifficulty difficulty)
		{
			var baseArmor = unit.HealthArmor + (difficulty.RoomToClear + difficulty.StartingUpgrades) * unit.HealthArmorIncrement;
			var totalArmor = baseArmor * difficulty.Armor;
			var armorModifier = hasTitanicBuff ? 1.5 : 1;
			if (unit.EnemyType.IsHeroic())
			{
				armorModifier += difficulty.MythicBoss / 100.0;
			}
			totalArmor *= armorModifier;
			return totalArmor;
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

			var redCritChance = perks.RedCrits.DesiredLevel>0 ? remainingChance * stats.CriticalChance / 200 : 0;
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

		static double GetHitsTillDeath(IEnumerable<(double, double)> enemyDamages, VStats stats)
		{
			if (!stats.Loadout.UseUnitStats || stats.Loadout.CurrentUnit == null)
			{
				throw new NotImplementedException();
			}

			var damageOnShields = enemyDamages.Select(tuple => (tuple.Item1, Math.Max(0.5, tuple.Item2 - stats.UnitShieldsArmor)));
			var damageOnHealth = enemyDamages.Select(tuple => (tuple.Item1, Math.Max(0.5, tuple.Item2 - stats.UnitHealthArmor)));

			var averageShieldDamage = damageOnShields.Sum(tuple => tuple.Item1 * tuple.Item2);
			var averageHealthDamage = damageOnHealth.Sum(tuple => tuple.Item1 * tuple.Item2);
			var hitsTillNoShields = stats.UnitShields / averageShieldDamage;
			var hitsTillNoHealth = stats.UnitHealth / averageHealthDamage;

			return hitsTillNoShields + hitsTillNoHealth;
		}

		static IEnumerable<(double Chance, EnemyStatCard Enemy)> GetEnemyCompositionStats(VDifficulty difficulty, CompositionOptions options)
		{
			var unitComp = GetEnemyUnitComposition(difficulty, options);
			return unitComp.Select(x => (x.Chance, GetEnemyStats(x.Enemy, difficulty)));
		}

		static EnemyStatCard GetEnemyStats(EnemyStatCard stats, VDifficulty difficulty)
		{
			var unit = EnemyUnit.New(stats.Type);
			stats.Damage = GetEnemyDamage(unit, stats.IsTitan, difficulty);
			stats.Armor = GetEnemyArmorForDifficulty(unit, stats.IsTitan, difficulty);
			stats.TitanicDR = stats.IsTitan ? GetTitanicDR(stats.Type) : 0;
			stats.TitanicDRChance = stats.IsTitan ? GetTitanicDRChance(stats.Type) : 0;
			return stats;
		}

		static double GetTitanicDR(EnemyType type) => type.IsHeroic() ? 0.6 : 0.8;
		static double GetTitanicDRChance(EnemyType type) => type.IsHeroic() ? 0.3 : 0.2;

		static double GetEnemyDamage(EnemyUnit unit, bool isTitanic, VDifficulty difficulty)
		{
			var unitDamage = unit.Attack + unit.AttackIncrement * (difficulty.RoomToClear + difficulty.StartingUpgrades);
			var damageModifier = difficulty.Damage;
			if (unit.EnemyType.IsHeroic())
			{
				damageModifier += difficulty.MythicBoss / 100.0;
			}
			if (isTitanic && unit.EnemyType.IsHeroic())
			{
				damageModifier += 0.5;
			}
			else if (isTitanic)
			{
				damageModifier += 2;
			}
			unitDamage *= damageModifier;
			unitDamage *= (1 + difficulty.DamageIncrease / 100.0);
			return unitDamage;
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

		static IEnumerable<(double, EnemyStatCard)> ApplyTitanicBuffedComposition(IEnumerable<(EnemyType, double)> comp, int titanicChance)
		{
			foreach (var unit in comp)
			{
				yield return (unit.Item2 * titanicChance / 100, new EnemyStatCard { Type = unit.Item1, IsTitan = true });
				yield return (unit.Item2 * (1 - titanicChance / 100), new EnemyStatCard { Type = unit.Item1, IsTitan = false });
			}
		}

		internal static IEnumerable<(EnemyType, double)> UnitCompOverride;

		struct EnemyStatCard
		{
			public EnemyType Type { get; set; }
			public bool IsTitan { get; set; }
			public double Damage { get; set; }
			public double Armor { get; set; }
			public double TitanicDR{ get; set; }
			public double TitanicDRChance{ get; set; }

#if DEBUG // this is for debugging display - DebuggerDisplayAttribute doesn't appear to work for nested classes
			public override string ToString() => $"{Type} - tit:{IsTitan}, atk:{Damage}";
#endif
		}
	}

	public struct CritChances
	{
		public double YellowChance { get; set; }
		public double RedChance { get; set; }
		public double BlackChance { get; set; }
		public double RegularChance { get; set; }
	}
}
