using EnumsNET;
using System;
using System.Collections.Generic;
using System.Linq;

namespace VEntityFramework
{
	public static class EnumHelper
	{
		public static T GetEnumFromDescription<T>(string description) where T : struct, Enum
		{
			IReadOnlyList<T> enums;
			enums = Enums.GetValues<T>();

			return enums.FirstOrDefault(e => e.AsString(EnumFormat.Description) == description || e.AsString(EnumFormat.Name) == description);
		}
	}
}
