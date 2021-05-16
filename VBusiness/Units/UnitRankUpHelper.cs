using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public static class UnitRankUpHelper
	{
		public static double GetRankCost(UnitRankType rank, int revision)
		{
			var cacheKey = new RankCacheKey(rank, revision);
			if (Cache.TryGetValue(cacheKey, out var value))
			{
				return value;
			}

			value = GetNewRankCost(rank, revision);
			Cache[cacheKey] = value;
			return value;
		}

		static double GetNewRankCost(UnitRankType rank, int revision)
		{
			var totalCost = 0.0;

			for (var i = 0; i < (int)rank; i++)
			{
				var chance = Math.Pow(0.902, i) * (1 + revision / 100.0);
				chance = Math.Min(1, chance);
				var attemptCost = (100 + 75 * i) * (1 + 0.03 * i);
				var expectedCost = attemptCost / chance;
				totalCost += expectedCost;
			}

			return totalCost;
		}

		static IDictionary<RankCacheKey, double> Cache => fCache ??= new Dictionary<RankCacheKey, double>();
		static IDictionary<RankCacheKey, double> fCache;

		struct RankCacheKey
		{
			public RankCacheKey(UnitRankType rank, int rankRevision)
			{
				UnitRank = rank;
				RankRevision = rankRevision;
			}
			public UnitRankType UnitRank { get; }
			public int RankRevision { get; }
		}
	}
}
