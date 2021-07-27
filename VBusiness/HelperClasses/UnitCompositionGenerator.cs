using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using VBusiness.Enemies;
using VBusiness.Rooms;
using VEntityFramework.Model;

namespace VBusiness.HelperClasses
{
	internal class UnitCompositionGenerator
	{
		static IDictionary<CompositionCacheKey, IEnumerable<(EnemyType, double)>> Cache => fCache ??= new Dictionary<CompositionCacheKey, IEnumerable<(EnemyType, double)>>();
		static IDictionary<CompositionCacheKey, IEnumerable<(EnemyType, double)>> fCache;

		internal static IEnumerable<(EnemyType, double)> GetComposition(VDifficulty difficulty, CompositionOptions options = CompositionOptions.Normal, double modTierIncrease = 0.0)
		{
			var compositionKey = new CompositionCacheKey { Difficulty = difficulty, Options = options, TierUp = difficulty.UnitTierIncrease + modTierIncrease };
			if (Cache.TryGetValue(compositionKey, out var composition))
			{
				return composition;
			}
			else
			{
				composition = GetNewComposition(compositionKey);
				Cache[compositionKey] = composition;
				return composition;
			}

		}

		static IEnumerable<(EnemyType, double)> GetNewComposition(CompositionCacheKey key)
		{
			var composition = new List<EnemyQuantity>();

			AddRoomToComposition(composition, key.Difficulty.RoomToClear, key.Options, key.TierUp);
			AddRoomToComposition(composition, key.Difficulty.RoomToClear - 1, key.Options, key.TierUp);
			AddRoomToComposition(composition, key.Difficulty.RoomToClear - 2, key.Options, key.TierUp);
			return ConsolidateComposition(composition);
		}

		static void AddRoomToComposition(List<EnemyQuantity> composition, RoomNumber roomToClear, CompositionOptions options, double tierUp)
		{
			var room = Room.New(roomToClear);
			AddAllIncludingSpawns(composition, room.EnemiesPerWave, roomToClear, options, tierUp);
			AddAllIncludingSpawns(composition, room.EnemiesPerWave, roomToClear, options, tierUp);
			AddAllIncludingSpawns(composition, room.EnemiesPerWave, roomToClear, options, tierUp);
			AddAllIncludingSpawns(composition, room.Buildings, roomToClear, options, tierUp);
			AddAllIncludingSpawns(composition, room.GetBoss, roomToClear, options, tierUp);
		}

		static void AddAllIncludingSpawns(List<EnemyQuantity> composition, EnemyType unit, RoomNumber room, CompositionOptions options, double tierUp)
		{
			AddAllIncludingSpawns(composition, new[] { new EnemyQuantity(unit, 1) }, room, options, tierUp);
		}

		static void AddAllIncludingSpawns(List<EnemyQuantity> composition, IEnumerable<EnemyQuantity> enemiesToAdd, RoomNumber room, CompositionOptions options, double tierUp)
		{
			enemiesToAdd = enemiesToAdd.TierUp(tierUp);
			composition.AddRange(enemiesToAdd.Where(e => e.Type != EnemyType.None && (e.Type.CanAttack() || !options.HasFlag(CompositionOptions.AttackingUnitsOnly))));
			composition.AddRange(enemiesToAdd.SelectRecursive(e => e.Type.GetAdditionalSpawns(tierUp, room).Multiply(e.Quantity)));
		}

		static IEnumerable<(EnemyType, double)> ConsolidateComposition(List<EnemyQuantity> composition)
		{
			var newComp = new Dictionary<EnemyType, double>();

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
			public VDifficulty Difficulty { get; set; }
			public CompositionOptions Options { get; set; }
			public double TierUp { get; set; }
		}
	}

	[DebuggerDisplay("{Type} - {Quantity}")]
	public struct EnemyQuantity
	{
		public EnemyQuantity(EnemyType type, double quantity)
		{
			Type = type;
			Quantity = quantity;
		}
		public EnemyType Type { get; set; }
		public double Quantity { get; set; }
	}

	enum CompositionOptions
	{
		Normal,
		AttackingUnitsOnly
	}
}