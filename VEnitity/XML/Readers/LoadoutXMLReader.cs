using System;
using System.Reflection;
using System.Xml;

namespace VEntityFramework.XML
{
	internal class LoadoutXMLReader : BaseXMLReader
	{
		protected override PropertyInfo GetPropertyFromXML(Type type, XmlNode child)
		{
			return child.Name switch
			{
				"PerkCollection" => type.GetProperty("Perks"),
				"GemCollection" => type.GetProperty("Gems"),
				"SoulCollection" => type.GetProperty("Souls"), // This is now for legacy only, v0.6 and earlier. BizoName = "Souls" now so this will nolonger be needed after they open/resave
				"ChallengePointCollection" => type.GetProperty("ChallengePoints"),
				_ => base.GetPropertyFromXML(type, child)
			};
		}
	}
}
