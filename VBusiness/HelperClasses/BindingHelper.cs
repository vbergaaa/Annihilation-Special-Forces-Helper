using System.Collections.Generic;
using System.Linq;

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
