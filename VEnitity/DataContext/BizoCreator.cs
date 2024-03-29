﻿using EnumsNET;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Loader;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VEntityFramework.DataContext
{
	public static class BizoCreator
	{
		public static BusinessObject Create(Type bizoType, params object[] parameters)
		{
			return Create(bizoType, null, parameters);
		}

		public static BusinessObject Create(Type bizoType, string specificTypeName, params object[] parameters)
		{
			if (typeof(VSoul).IsAssignableFrom(bizoType))
			{
				var soulType = specificTypeName ?? "Empty";
				var fullType = $"VBusiness.Souls.{soulType}Soul";
				var myAssembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(Directory.GetCurrentDirectory() + "/VBusiness.dll");
				var myType = myAssembly.GetType(fullType);
				var ctor = myType.GetConstructors()[0];
				return specificTypeName != null
					? (BusinessObject)ctor.Invoke(new object[] { parameters.FirstOrDefault() })
					: (BusinessObject)ctor.Invoke(null); // EmptySoul initialiser
			}
			else if (typeof(VUnit).IsAssignableFrom(bizoType))
			{
				if (specificTypeName != null)
				{
					if (parameters.Length == 1)
					{
						var type = Enums.GetValues<UnitType>().FirstOrDefault(uType => uType.AsString(EnumFormat.Name) == specificTypeName);
						var paramList = parameters.ToList();
						paramList.Add(type);
						parameters = paramList.ToArray();
					}
					var typeFullName = $"VBusiness.Units.Unit";
					var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(Directory.GetCurrentDirectory() + "/VBusiness.dll");
					var myType = assembly.GetType(typeFullName);
					var ctor = myType.GetConstructors()[0];
					return (BusinessObject)ctor.Invoke(parameters);
				}

				return null;
			}

			if (VBusinessBizoTypeMappings.TryGetValue(bizoType.FullName, out var mappedType))
			{
				var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(Directory.GetCurrentDirectory() + "/VBusiness.dll");
				var myType = assembly.GetType(mappedType);
				var ctor = myType.GetConstructors()[0];
				return (BusinessObject)ctor.Invoke(parameters);
			}

			return (BusinessObject)bizoType.Assembly.CreateInstance(bizoType.FullName);
		}

		public static IDictionary<string, string> VBusinessBizoTypeMappings => vBusinessBizoTypeMappings ??= GetVBusinessBizoTypeMappings();
		static IDictionary<string, string> vBusinessBizoTypeMappings;

		static IDictionary<string, string> GetVBusinessBizoTypeMappings()
		{
			return new Dictionary<string, string>()
			{
				{ "VEntityFramework.Model.VRegistry", "VBusiness.Registry" }
			};
		}
	}
}
