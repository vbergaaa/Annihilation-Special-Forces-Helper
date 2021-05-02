using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using VBusiness.Enemies;
using VEntityFramework.Model;

namespace VBusiness.HelperClasses
{
	internal class UnitCompositionGenerator
	{
		internal static IEnumerable<(EnemyType, double)> GetComposition(VDifficulty difficulty)
		{
			var composition = new List<EnemyQuantity>();

			AddRoomToComposition(composition, difficulty.RoomToClear);
			AddRoomToComposition(composition, difficulty.RoomToClear - 1);
			AddRoomToComposition(composition, difficulty.RoomToClear - 2);
			return ConsolidateComposition(composition);
		}

		static void AddRoomToComposition(List<EnemyQuantity> composition, int roomToClear)
		{
			var room = Room.New(roomToClear);
			AddAllIncludingSpawns(composition, room.EnemiesPerWave);
			AddAllIncludingSpawns(composition, room.EnemiesPerWave);
			AddAllIncludingSpawns(composition, room.EnemiesPerWave);
			AddAllIncludingSpawns(composition, room.Buildings);
			AddAllIncludingSpawns(composition, room.GetBoss);
		}

		static void AddAllIncludingSpawns(List<EnemyQuantity> composition, EnemyType unit)
		{
			AddAllIncludingSpawns(composition, new[] { new EnemyQuantity(unit, 1) });
		}

		static void AddAllIncludingSpawns(List<EnemyQuantity> composition, IEnumerable<EnemyQuantity> enemiesToAdd)
		{
			// TODO: Add UnitsSpawnedOnHit to this list
			// Or - Rethink this whole complicated design
			composition.AddRange(enemiesToAdd.Where(e => e.Type != EnemyType.None && e.Type.CanAttack()));
			composition.AddRange(enemiesToAdd.SelectRecursive(e => e.Type.GetUnitsOnDeath().Multiply(e.Quantity)));
		}

		static IEnumerable<(EnemyType, double)> ConsolidateComposition(List<EnemyQuantity> composition)
		{
			var newComp = new Dictionary<EnemyType, int>();

			foreach (var enemyQuanity in composition)
			{
				if (newComp.ContainsKey(enemyQuanity.Type))
				{
					newComp[enemyQuanity.Type] += enemyQuanity.Quantity;
				}
				else
				{
					newComp[enemyQuanity.Type] = enemyQuanity.Quantity;
				}
			}

			double totalUnitCount = newComp.Sum(kvp => kvp.Value);

			return newComp.Select(kvp => (kvp.Key, kvp.Value / totalUnitCount));
		}
	}

	[DebuggerDisplay("{Type} - {Quantity}")]
	public struct EnemyQuantity
	{
		public EnemyQuantity(EnemyType type, int quantity)
		{
			Type = type;
			Quantity = quantity;
		}
		public EnemyType Type { get; set; }
		public int Quantity { get; set; }
	}
}