using System;
using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework;

namespace VBusiness.Enemies
{
	public static class EnemyQuantityExtensions
	{
		public static IEnumerable<EnemyQuantity> Multiply(this IEnumerable<EnemyQuantity> quantities, double value)
		{
			var list = new List<EnemyQuantity>();
			foreach (var quantity in quantities)
			{
				list.Add(new EnemyQuantity(quantity.Type, quantity.Quantity * value));
			};
			return list;
		}

		public static IEnumerable<EnemyQuantity> TierUp(this IEnumerable<EnemyQuantity> quantities, double tier)
		{
			if (tier >= 1.0001)
			{
				tier = 1;
			}
			ErrorReporter.ReportDebug("This shouldn't be possible unless ZX is released, in which case you need to rework what the max tier is for different difficulties", () => tier > 2.001);

			foreach (var unit in quantities)
			{
				var minTier = (int)Math.Floor(tier);
				var maxTier = minTier + 1;
				var minTierChance = maxTier - tier;
				var maxTierChance = 1 - minTierChance;

				var newMinUnit = unit;

				if (!(unit.Type.IsBoss() || unit.Type.IsBuilding() || unit.Type == VEntityFramework.Model.EnemyType.None))
				{
					newMinUnit.Type += minTier;
					newMinUnit.Quantity *= minTierChance;
					yield return newMinUnit;

					if (maxTierChance > 0)
					{
						var newMaxUnit = unit;
						newMaxUnit.Type += maxTier;
						newMaxUnit.Quantity *= maxTierChance;
						yield return newMaxUnit;
					}
				}
				else
				{
					yield return newMinUnit;
				}

			}
		}
	}
}
