using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VBusiness.HelperClasses
{
	public static class BindingHelper<T>
	{
		public static List<object> ConvertForBinding(IList<T> list)
		{
			return list.Cast<object>().ToList();
		}
	}
}
