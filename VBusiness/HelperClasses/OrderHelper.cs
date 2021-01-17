using System.Collections.Generic;
using System.Linq;

namespace VBusiness.HelperClasses
{
	public static class OrderHelper
	{
		public static string[] OrderNamesByKey(string[] names)
		{
			var kvps = new List<KeyValuePair<int, string>>();
			var badNames = new List<string>();
			foreach (var name in names)
			{
				if (int.TryParse(name.Split('-')[0], out var num))
				{
					kvps.Add(new KeyValuePair<int, string>(num, name));
				}
				else
				{
					badNames.Add(name);
				}
			}

			var orderedKvps = kvps.OrderBy(kvp => kvp.Key);
			var orderedBadNames = badNames.OrderBy(name => name);
			return orderedKvps.Select(kvp => kvp.Value).Union(orderedBadNames).ToArray();
		}
	}
}
