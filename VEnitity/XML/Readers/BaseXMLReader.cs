using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using VEntityFramework.Data;

namespace VEntityFramework.XML
{
	internal abstract class BaseXMLReader
	{
		public void PopulateFromXML(VBusinessObject bizo, XmlNode documentElement)
		{
			using (bizo.StartLoading())
			using (bizo.SuspendSettingHasChanges())
			{
				foreach (XmlNode childNode in documentElement.ChildNodes)
				{
					PopulateChild(bizo, childNode);
				}
			}
			bizo.ExistsInXML = true;
		}

		void PopulateChild(VBusinessObject bizo, XmlNode childNode)
		{
			var matchingProperty = GetPropertyFromXML(bizo.GetType(), childNode);

#if DEBUG
			if (matchingProperty == null)
			{
				throw new DeveloperException($"Cannot find property {childNode.Name} on {bizo.GetType().Name} Business Object");
			}
#endif

			if (matchingProperty != null)
			{
				if (matchingProperty.IsBusinessObject())
				{
					PopulateBusinessObject(bizo, childNode, matchingProperty);
				}
				else
				{
					PopulateNonKeyProperty(bizo, childNode, matchingProperty);
				}
			}
		}

		void PopulateBusinessObject(VBusinessObject bizo, XmlNode childNode, PropertyInfo matchingProperty)
		{
			if (matchingProperty.GetValue(bizo) is VBusinessObject childBizo)
			{
				var reader = VXMLReader.GetXmlReader(childBizo.GetType());
				reader.PopulateFromXML(childBizo, childNode);
			}
		}

		void PopulateNonKeyProperty(VBusinessObject bizo, XmlNode childNode, PropertyInfo matchingProperty)
		{
			if (!IsKey(childNode))
			{
				matchingProperty.CastAndSetValue(childNode.InnerText, bizo);
			}
		}

		bool IsKey(XmlNode childNode) => XmlKey == childNode.Name;

		protected virtual string XmlKey => "Key";

		protected virtual PropertyInfo GetPropertyFromXML(Type type, XmlNode child)
		{
			return type.GetProperty(child.Name);
		}

		protected PropertyInfo GetDefaultBizoProperty(Type type, XmlNode node)
		{
			var name = string.Empty;
			foreach (XmlNode child in node.ChildNodes)
			{
				if (IsKey(child))
				{
					name = child.InnerText.Replace(" ", "");
				}
			}
			return type.GetProperty(name);
		}
	}
}
