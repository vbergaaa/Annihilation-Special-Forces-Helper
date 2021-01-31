using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace VUserInterface
{
	static class ControlBindingsCollectionExtensions
	{
		public static void AddIfValid(this ControlBindingsCollection dataSource, string controlProperty, BindingSource binding, string bizoProperty)
		{
			if (!string.IsNullOrEmpty(bizoProperty))
			{
				dataSource.Add(controlProperty, binding, bizoProperty);
			}
		}
	}
}
