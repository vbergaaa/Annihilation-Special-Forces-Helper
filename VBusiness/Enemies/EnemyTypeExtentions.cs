using System;
using System.Collections.Generic;
using System.Linq;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public static class EnemyTypeExtentions
	{
		public static bool CanAttack(this EnemyType type)
		{
			if (type == EnemyType.EvolutionChamber
				|| type == EnemyType.SpawningPool
				|| type == EnemyType.RoachWarren
				|| type == EnemyType.HydraliskDen
				|| type == EnemyType.PygaliskCavern
				|| type == EnemyType.Spire
				|| type == EnemyType.Hatchery
				|| type == EnemyType.Lair
				|| type == EnemyType.Hive)
			{
				return false;
			}
			return true;
		}

		public static bool IsQueen(this EnemyType type)
		{
			return type >= EnemyUnit.FirstQueen && type <= EnemyUnit.LastQueen;
		}

		public static bool IsHeroic(this EnemyType type)
		{
			return type >= EnemyUnit.FirstQueen && type <= EnemyUnit.LastBoss;
		}

		public static bool IsBuilding(this EnemyType type)
		{
			return type > EnemyUnit.LastBoss;
		}

		public static bool IsBoss(this EnemyType type)
		{
			return type >= EnemyUnit.FirstBoss && type <= EnemyUnit.LastBoss;
		}

		public static IEnumerable<EnemyQuantity> GetUnitsOnDeath(this EnemyType parentType, int tierUpLevels)
		{
			var key = new OnDeathCacheKey { Type = parentType, TierUp = tierUpLevels };
			if (OnDeathCache.ContainsKey(key))
			{
				return OnDeathCache[key];
			}
			if (parentType == EnemyType.None)
			{
				return (OnDeathCache[key] = Array.Empty<EnemyQuantity>());
			}

			var unit = EnemyUnit.New(parentType);
			var unitsSpawnedOnDeath = unit.GetUnitsSpawnedOnDeath(tierUpLevels);
			return (OnDeathCache[key] = unitsSpawnedOnDeath);
		}

		static IDictionary<OnDeathCacheKey, IEnumerable<EnemyQuantity>> OnDeathCache => fOnDeathCache ??= new Dictionary<OnDeathCacheKey, IEnumerable<EnemyQuantity>>();
		static IDictionary<OnDeathCacheKey, IEnumerable<EnemyQuantity>> fOnDeathCache;

		struct OnDeathCacheKey
		{
			public EnemyType Type { get; set; }
			public int TierUp { get; set; }
		}
	}
}
