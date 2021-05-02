using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VBusiness.HelperClasses
{
	public static class LinqExtensions
	{
		public static IEnumerable<T> SelectRecursive<T>(this IEnumerable<T> collection, Func<T, IEnumerable<T>> selector)
		{
			var returnList = new List<T>();
			var currentRecursion = collection.SelectMany(x => selector(x));

			while (currentRecursion.Any())
			{
				returnList.AddRange(currentRecursion);
				currentRecursion = currentRecursion.SelectMany(x => selector(x));
			}

			return returnList;
		}
	}
}
