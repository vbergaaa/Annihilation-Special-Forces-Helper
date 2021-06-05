using System;
using System.Linq;
using System.Reflection;
using VBusiness.Rooms;
using VEntityFramework.Model;

namespace VEntityFramework.Data
{
	public static class PropertyInfoExtensions
	{
		public static bool IncludeInVXml(this PropertyInfo info)
		{
			// by default, VBusinessObjects are included, and all other property infos are excluded.
			// default can be overriden by VXMLAttribute.ShouldInclude
			var attribute = (VXMLAttribute)info.InheritsCustomAttribute(typeof(VXMLAttribute));

			if (attribute != null)
			{
				return attribute.ShouldInclude;
			}
			else
			{
				return typeof(BusinessObject).IsAssignableFrom(info.PropertyType);
			}
		}

		public static string GetXmlAlias(this PropertyInfo info)
		{
			if (IncludeInVXml(info))
			{
				var attribute = (VXMLAttribute)info.InheritsCustomAttribute(typeof(VXMLAttribute));
				if (attribute != null)
				{
					return attribute.Alias ?? info.Name;
				}
			}
			return null;
		}

		public static void CastAndSetValue(this PropertyInfo property, string value, BusinessObject bizo)
		{
			var objectValue = CastFromStringHelper.GetValueForPropertyTypeFromString(property.PropertyType.Name, value);
			if (objectValue != null)
			{
				property.SetValue(bizo, objectValue);
			}
		}

		public static bool IsBusinessObject(this PropertyInfo info)
		{
			return typeof(BusinessObject).IsAssignableFrom(info?.PropertyType);
		}

		public static bool IsXmlObject(this PropertyInfo info)
		{
			return typeof(IXmlObject).IsAssignableFrom(info?.PropertyType);
		}

		public static string GetNameForXML(this PropertyInfo info)
		{
			if (typeof(BusinessObject).IsAssignableFrom(info.PropertyType))
			{
				var propInfo = info.PropertyType.GetProperty("BizoName");
				var value = propInfo.GetValue(null);
				var ret = value.ToString();
				return ret;
			}
			else
			{
				return info.Name;
			}
		}

		static Attribute InheritsCustomAttribute(this PropertyInfo info, Type attributeType)
		{
			var attribute = info.GetCustomAttribute(attributeType);
			if (attribute != null)
			{
				return attribute;
			}

			var propertyHostType = info.DeclaringType;
			var typesToCheck = propertyHostType.GetInterfaces().ToList();
			typesToCheck.Add(propertyHostType.BaseType);
			foreach (var baseInterface in typesToCheck)
			{
				var property = baseInterface?.GetProperty(info.Name);
				if (property != null)
				{
					var matchingAttribute = property.InheritsCustomAttribute(attributeType);
					if (matchingAttribute != null)
					{
						return matchingAttribute;
					}
				}
			}

			return null;
		}
	}

	public static class CastFromStringHelper
	{
		public static object GetValueForPropertyTypeFromString(string propertyType, string value)
		{
			return propertyType switch
			{
				"Int16" => short.Parse(value),
				"Int32" => int.Parse(value),
				"Int64" => long.Parse(value),
				"String" => value,
				"Boolean" => value.ToLower() == "true" ? true : false,
				"UnitRankType" => EnumHelper.GetEnumFromDescription<UnitRankType>(value),
				"PlayerRank" => EnumHelper.GetEnumFromDescription<PlayerRank>(value),
				"DifficultyLevel" => EnumHelper.GetEnumFromDescription<DifficultyLevel>(value),
				"SoulType" => EnumHelper.GetEnumFromDescription<SoulType>(value),
				"UnitType" => EnumHelper.GetEnumFromDescription<UnitType>(value),
				"RoomNumber" => EnumHelper.GetEnumFromDescription<RoomNumber>(value),
				_ => HandleUnknownType(propertyType),
			};
		}

		static object HandleUnknownType(string propertyType)
		{
			ErrorReporter.ReportDebug($"Add cast type for {propertyType} to method PropertyInfoExtensions.CastAndSetValue()");
			return null;
		}
	}
}
