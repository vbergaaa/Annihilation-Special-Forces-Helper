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
	}
}
