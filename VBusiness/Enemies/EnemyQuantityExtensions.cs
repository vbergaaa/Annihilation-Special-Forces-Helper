using System.Collections.Generic;
using VBusiness.HelperClasses;

namespace VBusiness.Enemies
{
	public static class EnemyQuantityExtensions
	{
		public static IEnumerable<EnemyQuantity> Multiply(this IEnumerable<EnemyQuantity> quantities, int value)
		{
			var list = new List<EnemyQuantity>();
			foreach (var quantity in quantities)
			{
				list.Add(new EnemyQuantity(quantity.Type, quantity.Quantity * value));
			};
			return list;
		}

		public static IEnumerable<EnemyQuantity> TierUp(this IEnumerable<EnemyQuantity> quantities, int tier)
		{
			foreach (var unit in quantities)
			{
				var newUnit = unit;
				if (!(unit.Type.IsBoss() || unit.Type.IsBuilding() || unit.Type == VEntityFramework.Model.EnemyType.None))
				{
					newUnit.Type += tier;
				}
				yield return newUnit;
			}
		}
	}
}
