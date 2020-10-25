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
				"SoulCollection" => type.GetProperty("Souls"),
				"ChallengePointCollection" => type.GetProperty("ChallengePoints"),
				_ => base.GetPropertyFromXML(type, child)
			};
		}
	}
}
