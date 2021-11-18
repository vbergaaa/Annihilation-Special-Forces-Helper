using System;
using System.Reflection;
using System.Xml;

namespace VEntityFramework.XML
{
	internal class GemCollectionXMLReader : BaseXMLReader
	{
		protected override PropertyInfo GetPropertyFromXML(Type type, XmlNode child)
		{
			return child.Name == "Gem" 
				? GetGem(type, child) 
				: base.GetPropertyFromXML(type, child);
		}

        static PropertyInfo GetGem(Type type, XmlNode node)
		{
			var name = "";
			foreach (XmlNode child in node.ChildNodes)
			{
				if (child.Name == "Key")
				{
					name = child.InnerText.Replace(" ", "") + "Gem";
				}
			}
			return type.GetProperty(name);
		}
	}
}
