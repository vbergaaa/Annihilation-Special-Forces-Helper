using System;
using System.Collections.Generic;
using System.Linq;
using VBusiness.HelperClasses;
using VBusiness.Rooms;
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
			return type > EnemyUnit.LastBoss && type < EnemyUnit.FirstBruta;
		}

		public static bool IsBoss(this EnemyType type)
		{
			return type >= EnemyUnit.FirstBoss && type <= EnemyUnit.LastBoss;
		}

		public static IEnumerable<EnemyQuantity> GetAdditionalSpawns(this EnemyType parentType, int tierUpLevels, RoomNumber room)
		{
			var key = new OnDeathCacheKey { Type = parentType, TierUp = tierUpLevels, Room = room };
			if (AdditionalSpawnsCache.ContainsKey(key))
			{
				return AdditionalSpawnsCache[key];
			}
			if (parentType == EnemyType.None)
			{
				return (AdditionalSpawnsCache[key] = Array.Empty<EnemyQuantity>());
			}

			var unit = EnemyUnit.New(parentType);
			var additionalUnitsSpawned = unit.GetUnitsSpawnedOnDeath(tierUpLevels, room);
			return (AdditionalSpawnsCache[key] = additionalUnitsSpawned);
		}

		static IDictionary<OnDeathCacheKey, IEnumerable<EnemyQuantity>> AdditionalSpawnsCache => fAdditionalSpawnsCache ??= new Dictionary<OnDeathCacheKey, IEnumerable<EnemyQuantity>>();
		static IDictionary<OnDeathCacheKey, IEnumerable<EnemyQuantity>> fAdditionalSpawnsCache;

		struct OnDeathCacheKey
		{
			public EnemyType Type { get; set; }
			public int TierUp { get; set; }
			public RoomNumber Room { get; set; }
		}
	}
}
