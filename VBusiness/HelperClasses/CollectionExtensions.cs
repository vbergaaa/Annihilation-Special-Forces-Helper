﻿using System.Collections.Generic;

namespace VBusiness.HelperClasses
{
	public static class CollectionExtensions
	{
		public static void AddMultiple<T>(this IList<T> list, T elementToAdd, int quantity)
		{
			for (var i = 0; i < quantity; i++)
			{
				list.Add(elementToAdd);
			}
		}
	}
}
