using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using VBusiness.Enemies;
using VEntityFramework.Model;

namespace VBusiness.HelperClasses
{
	internal class UnitCompositionGenerator
	{
		static IDictionary<CompositionCacheKey, IEnumerable<(EnemyType, double)>> Cache => fCache ??= new Dictionary<CompositionCacheKey, IEnumerable<(EnemyType, double)>>();
		static IDictionary<CompositionCacheKey, IEnumerable<(EnemyType, double)>> fCache;
		
		internal static IEnumerable<(EnemyType, double)> GetComposition(VDifficulty difficulty, CompositionOptions options = CompositionOptions.Normal)
		{
			var compositionKey = new CompositionCacheKey { Difficulty = difficulty.Difficulty, Options = options };
			if (Cache.TryGetValue(compositionKey, out var composition))
			{
				return composition;
			}
			else
			{
				composition = GetNewComposition(difficulty, options);
				Cache[compositionKey] = composition;
				return composition;
			}

		}

		static IEnumerable<(EnemyType, double)> GetNewComposition(VDifficulty difficulty, CompositionOptions options)
		{
			var composition = new List<EnemyQuantity>();

			AddRoomToComposition(composition, difficulty.RoomToClear, options);
			AddRoomToComposition(composition, difficulty.RoomToClear - 1, options);
			AddRoomToComposition(composition, difficulty.RoomToClear - 2, options);
			return ConsolidateComposition(composition);
		}

		static void AddRoomToComposition(List<EnemyQuantity> composition, int roomToClear, CompositionOptions options)
		{
			var room = Room.New(roomToClear);
			AddAllIncludingSpawns(composition, room.EnemiesPerWave, options);
			AddAllIncludingSpawns(composition, room.EnemiesPerWave, options);
			AddAllIncludingSpawns(composition, room.EnemiesPerWave, options);
			AddAllIncludingSpawns(composition, room.Buildings, options);
			AddAllIncludingSpawns(composition, room.GetBoss, options);
		}

		static void AddAllIncludingSpawns(List<EnemyQuantity> composition, EnemyType unit, CompositionOptions options)
		{
			AddAllIncludingSpawns(composition, new[] { new EnemyQuantity(unit, 1) }, options);
		}

		static void AddAllIncludingSpawns(List<EnemyQuantity> composition, IEnumerable<EnemyQuantity> enemiesToAdd, CompositionOptions options)
		{
			// TODO: Add UnitsSpawnedOnHit to this list
			// Or - Rethink this whole complicated design
			composition.AddRange(enemiesToAdd.Where(e => e.Type != EnemyType.None && (e.Type.CanAttack() || !options.HasFlag(CompositionOptions.ExcludeNoAttack))));
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

		struct CompositionCacheKey
		{
			public DifficultyLevel Difficulty { get; set; }
			public CompositionOptions Options { get; set; }
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

	enum CompositionOptions
	{
		Normal,
		ExcludeNoAttack
	}
}