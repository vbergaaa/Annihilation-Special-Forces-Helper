using System;
using System.Collections.Generic;
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

		public static IEnumerable<EnemyQuantity> GetUnitsOnDeath(this EnemyType parentType)
		{
			if (OnDeathCache.ContainsKey(parentType))
			{
				return OnDeathCache[parentType];
			}
			if (parentType == EnemyType.None)
			{
				return (OnDeathCache[parentType] = Array.Empty<EnemyQuantity>());
			}

			var unit = EnemyUnit.New(parentType);
			var unitsSpawnedOnDeath = unit.UnitsSpawnedOnDeath;
			return (OnDeathCache[parentType] = unitsSpawnedOnDeath);
		}

		static IDictionary<EnemyType, IEnumerable<EnemyQuantity>> OnDeathCache => fOnDeathCache ??= new Dictionary<EnemyType, IEnumerable<EnemyQuantity>>();
		static IDictionary<EnemyType, IEnumerable<EnemyQuantity>> fOnDeathCache;
	}
}
