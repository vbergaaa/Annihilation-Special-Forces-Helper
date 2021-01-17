using System;
using System.IO;
using System.Runtime.Loader;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VEntityFramework.DataContext
{
	public static class BizoCreator
	{
		public static VBusinessObject Create(Type bizoType, string specificTypeName = null)
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
			else
			{
				return (VBusinessObject)bizoType.Assembly.CreateInstance(bizoType.FullName);
			}
		}
	}
}
