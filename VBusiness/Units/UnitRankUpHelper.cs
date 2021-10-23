using System;
using System.Collections.Generic;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public static class UnitRankUpHelper
	{
		public static double GetRankCost(UnitRankType rank, int revision, bool hasRefundSoul)
		{
			var cacheKey = new RankCacheKey(rank, revision, hasRefundSoul);
			if (Cache.TryGetValue(cacheKey, out var value))
			{
				return value;
			}

			value = GetNewRankCost(rank, revision, hasRefundSoul);
			Cache[cacheKey] = value;
			return value;
		}

		static double GetNewRankCost(UnitRankType rank, int revision, bool hasRefundSoul)
		{
			var totalCost = 0.0;

			for (var i = 0; i < (int)rank; i++)
			{
				var chance = Math.Pow(0.902, i) * (1 + revision / 100.0);
				chance = Math.Min(1, chance);
				var successCost = (100 + 75 * i) * (1 + 0.03 * i);
				var refundAmount = hasRefundSoul ? 20 * (i - 1) : 0;
				var failCost = successCost - refundAmount;
				var expectedRankUpAttempts = 1 / chance;
				var expectedFails = expectedRankUpAttempts - 1;
				var expectedCost = successCost + failCost * expectedFails;
				totalCost += expectedCost;
			}

			return totalCost;
		}

		static IDictionary<RankCacheKey, double> Cache => fCache ??= new Dictionary<RankCacheKey, double>();
		static IDictionary<RankCacheKey, double> fCache;

		struct RankCacheKey
		{
			public RankCacheKey(UnitRankType rank, int rankRevision, bool refundSoul)
			{
				UnitRank = rank;
				RankRevision = rankRevision;
				HasRefundSoul = refundSoul;
			}
			public UnitRankType UnitRank { get; }
			public int RankRevision { get; }
			public bool HasRefundSoul { get; }
		}
	}
}
