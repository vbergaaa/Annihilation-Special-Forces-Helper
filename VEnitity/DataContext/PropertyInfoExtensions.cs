using System.Reflection;
using VEntityFramework.Model;

namespace VEntityFramework.Data
{
	public static class PropertyInfoExtensions
	{
		public static bool IncludeInVXml(this PropertyInfo info)
		{
			// by default, VBusinessObjects are included, and all other property infos are excluded.
			// default can be overriden by VXMLAttribute.ShouldInclude
			var attribute = (VXMLAttribute)info.GetCustomAttribute(typeof(VXMLAttribute));

			if (attribute != null)
			{
				return attribute.ShouldInclude;
			}
			else
			{
				return typeof(VBusinessObject).IsAssignableFrom(info.PropertyType);
			}
		}

		public static void CastAndSetValue(this PropertyInfo property, string value, VBusinessObject bizo)
		{
			var objectValue = CastFromStringHelper.GetValueForPropertyTypeFromString(property.PropertyType.Name, value);
			if (objectValue != null)
			{
				property.SetValue(bizo, objectValue);
			}
		}

		public static bool IsBusinessObject(this PropertyInfo info)
		{
			return typeof(VBusinessObject).IsAssignableFrom(info?.PropertyType);
		}

		public static string GetNameForXML(this PropertyInfo info)
		{
			if (typeof(VBusinessObject).IsAssignableFrom(info.PropertyType))
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
				"UnitRank" => EnumHelper.GetEnumFromDescription<UnitRank>(value),
				"PlayerRank" => EnumHelper.GetEnumFromDescription<PlayerRank>(value),
				"DifficultyLevel" => EnumHelper.GetEnumFromDescription<DifficultyLevel>(value),
				"SoulType" => EnumHelper.GetEnumFromDescription<SoulType>(value),
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
