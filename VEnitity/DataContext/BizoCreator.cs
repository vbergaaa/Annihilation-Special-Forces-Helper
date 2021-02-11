using System;
using System.IO;
using System.Runtime.Loader;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VEntityFramework.DataContext
{
	public static class BizoCreator
	{
		public static VBusinessObject Create(Type bizoType, params object[] parameters)
		{
			return Create(bizoType, null, parameters);
		}

		public static VBusinessObject Create(Type bizoType, string specificTypeName, params object[] parameters)
		{
			if (typeof(VSoul).IsAssignableFrom(bizoType))
			{
				var soulType = specificTypeName ?? "Empty";
				var fullType = $"VBusiness.Souls.{soulType}Soul";
				var myAssembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(Directory.GetCurrentDirectory() + "/VBusiness.dll");
				var myType = myAssembly.GetType(fullType);
				var ctor = myType.GetConstructors()[0];
				return specificTypeName != null
					? (VBusinessObject)ctor.Invoke(new object[] { null })
					: (VBusinessObject)ctor.Invoke(null); // EmptySoul initialiser
			}
			else if (typeof(VUnit).IsAssignableFrom(bizoType))
			{
				if (specificTypeName != null)
				{
					var typeFullName = $"VBusiness.Units.{specificTypeName}";
					var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(Directory.GetCurrentDirectory() + "/VBusiness.dll");
					var myType = assembly.GetType(typeFullName);
					var ctor = myType.GetConstructors()[0];
					return (VBusinessObject)ctor.Invoke(parameters);
				}

				return null;
			}

			return (VBusinessObject)bizoType.Assembly.CreateInstance(bizoType.FullName);
		}
	}
}
