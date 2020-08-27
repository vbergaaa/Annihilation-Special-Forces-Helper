﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using VEntityFramework;
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
			try
			{
				if (property.PropertyType.Name == "Int16")
				{
					property.SetValue(bizo, short.Parse(value));
				}
				else if (property.PropertyType.Name == "Int32")
				{
					property.SetValue(bizo, int.Parse(value));
				}
				else if (property.PropertyType.Name == "String")
				{
					property.SetValue(bizo, value);
				}
				else if (property.PropertyType.Name == "UnitRank")
				{
					property.SetValue(bizo, VRank.GetUnitRankFromString(value));
				}
				else if (property.PropertyType.Name == "Boolean")
				{
					property.SetValue(bizo, value.ToLower() == "true" ? true : false);
				}
				else
				{
#if DEBUG
					throw new DeveloperException($"Add cast type for {property.PropertyType.Name} to method PropertyInfoExtensions.CastAndSetValue()");
#endif
				}
			}
			catch (DeveloperException ex)
			{
				throw ex;
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
}
