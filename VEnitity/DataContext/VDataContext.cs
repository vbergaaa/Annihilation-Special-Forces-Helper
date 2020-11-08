﻿using System;
using System.IO;
using VEntityFramework.XML;

namespace VEntityFramework.Data
{
	public class VDataContext
	{
		VDataContext()
		{
		}

		static VDataContext fInstance;
		public static VDataContext Instance = fInstance ??= new VDataContext();

		public void SaveAsXML(VBusinessObject bizo)
		{
			new VXMLWriter().Write(bizo);
		}

		public T ReadFromXML<T>(string fileName) where T:VBusinessObject
		{
			return new VXMLReader().Read<T>(fileName);
		}

		public string[] GetAllFileNames(Type bizoType)
		{
			var method = typeof(VDataContext).GetMethod(nameof(GetAllFileNames), new Type[] { });
			var generic = method.MakeGenericMethod(bizoType);
			return (string[])generic.Invoke(this, null);
		}

		public string[] GetAllFileNames<T>() where T : VBusinessObject
		{
			return new VXMLReader().GetAllFilenames<T>();
		}

		public void Delete<T>(string fileName) where T : VBusinessObject
		{
			var path = DirectoryManager.GetFullPathWithExtension<T>(fileName);
			if (File.Exists(path))
			{
				File.Delete(path);
			}
#if DEBUG
			else
			{
				throw new DeveloperException($"filename {fileName} couldn't be found and wasn't deleted. Investigate and Fix.");
			}
#endif
		}

		public void Delete(Type bizoType, string fileName)
		{
			var method = typeof(VDataContext).GetMethod(nameof(Delete), new Type[] { typeof(string) });
			var generic = method.MakeGenericMethod(bizoType);
			generic.Invoke(this, new[] { fileName });
		}
	}
}
