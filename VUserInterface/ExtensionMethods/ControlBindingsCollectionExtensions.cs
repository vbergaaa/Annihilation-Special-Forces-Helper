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

		public static string GetBindingField(this ControlBindingsCollection dataBindings, string property)
		{
			Binding bindingOfInterest = null;
			foreach (Binding binding in dataBindings)
			{
				if (binding.PropertyName == property)
				{
					bindingOfInterest = binding;
				}
			}

			return bindingOfInterest?.BindingMemberInfo.BindingField ?? null;
		}
	}
}
