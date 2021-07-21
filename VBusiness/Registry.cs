using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VBusiness
{
	public class Registry : VRegistry
	{
		#region GetRegistry

		public static Registry GetRegistry()
		{
			if (fRegistry == null)
			{
				fRegistry = VDataContext.Instance.Get<Registry>();
			}
			return fRegistry;
		}
		static Registry fRegistry;

		#endregion
	}
}
