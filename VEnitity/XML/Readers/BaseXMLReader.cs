﻿using System;
using System.Collections;
using System.Reflection;
using System.Xml;
using VEntityFramework.Data;
using VEntityFramework.DataContext;

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
				PopulateBusinessObject(childBizo, childNode);
			}
		}

		void PopulateBusinessObject(VBusinessObject childBizo, XmlNode childNode)
		{
			var reader = VXMLReader.GetXmlReader(childBizo.GetType());
			reader.PopulateFromXML(childBizo, childNode);
		}

		protected virtual void PopulateNonKeyProperty(VBusinessObject bizo, XmlNode childNode, PropertyInfo matchingProperty)
		{
			if (!IsKey(childNode))
			{
				if (typeof(IList).IsAssignableFrom(matchingProperty.PropertyType))
				{
					ReadListIntoBizo(bizo, childNode, matchingProperty);
				}
				else
				{
					matchingProperty.CastAndSetValue(childNode.InnerText, bizo);
				}
			}
		}

		void ReadListIntoBizo(VBusinessObject bizo, XmlNode childNode, PropertyInfo matchingProperty)
		{
			var list = (IList)matchingProperty.GetValue(bizo);
			var listType = list.GetType().GetGenericArguments()[0];
			var listBaseMemberName = list.GetType().GetGenericArguments()[0].Name;

			foreach (XmlNode node in childNode.ChildNodes)
			{
				if (typeof(VBusinessObject).IsAssignableFrom(listType))
				{
					var key = GetKeyNode(node);
					var item = BizoCreator.Create(listType, key.InnerText, bizo);
					PopulateBusinessObject(item, node);
					list.Add(item);
				}
				else
				{
					var item = CastFromStringHelper.GetValueForPropertyTypeFromString(listBaseMemberName, node.InnerText);
					list.Add(item);
				}
			}
		}

		bool IsKey(XmlNode childNode) => XmlKey == childNode.Name;

		protected virtual string XmlKey => "Key";

		protected virtual PropertyInfo GetPropertyFromXML(Type type, XmlNode child)
		{
			return type.GetProperty(child.Name);
		}

		XmlNode GetKeyNode(XmlNode node)
		{
			foreach (XmlNode child in node)
			{
				if (child.Name == "Key")
				{
					return child;
				}
			}
			return null;
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
