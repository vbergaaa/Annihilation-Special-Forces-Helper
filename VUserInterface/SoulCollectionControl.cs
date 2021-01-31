using EnumsNET;
using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VUserInterface
{
	class SoulCollectionControl : VCommonSoulCollectionControl
	{
		protected override string GetSoulBindingStringCore(SoulType type)
		{
			return $"Has{type.AsString(EnumFormat.Name)}Soul";
		}
	}
}
