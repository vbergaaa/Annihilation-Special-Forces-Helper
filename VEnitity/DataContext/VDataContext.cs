﻿using System;
using System.IO;
using System.Linq;
using VEntityFramework.DataContext;
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

		public void SaveAsXML(BusinessObject bizo)
		{
			new VXMLWriter().Write(bizo);
			var cache = BizoCache.Instance;
			if (!cache.Exists(bizo))
			{
				BizoCache.Instance.Add(bizo);
			}
		}

		public T ReadFromXML<T>(string fileName) where T : BusinessObject
		{
			return new VXMLReader().Read<T>(fileName);
		}

		public T ReadFromXMLWithCache<T>(string fileName) where T : BusinessObject
		{
			var cache = BizoCache.Instance;
			if (cache.Exists(typeof(T), fileName))
			{
				return (T)cache.Retrieve(typeof(T), fileName);
			}
			var loadedBizo = ReadFromXML<T>(fileName);
			cache.Add(loadedBizo);
			return loadedBizo;
		}

		// Gets any matching bizo otherwise creates a new one
		public T Get<T>() where T : BusinessObject
		{
			var existingBizo = ReadFirstWithCache<T>();
			if (existingBizo != null)
			{
				return existingBizo;
			}

			return (T)BizoCreator.Create(typeof(T));
		}

		public T ReadFirstWithCache<T>() where T : BusinessObject
		{
			var cache = BizoCache.Instance;
			if (cache.Exists(typeof(T), null))
			{
				return (T)cache.Retrieve(typeof(T), null);
			}
			var fileNames = GetAllFileNames<T>();
			if (fileNames.Any())
			{
				var loadedBizo = new VXMLReader().Read<T>(fileNames.First());
				cache.Add(loadedBizo);
				return loadedBizo;
			}
			return null;
		}

		public string[] GetAllFileNames(Type bizoType)
		{
			var method = typeof(VDataContext).GetMethod(nameof(GetAllFileNames), new Type[] { });
			var generic = method.MakeGenericMethod(bizoType);
			return (string[])generic.Invoke(this, null);
		}

		public string[] GetAllFileNames<T>() where T : BusinessObject
		{
			return new VXMLReader().GetAllFilenames<T>();
		}

		public void Delete<T>(string fileName) where T : BusinessObject
		{
			var path = DirectoryManager.GetFullPathWithExtension<T>(fileName);
			if (File.Exists(path))
			{
				File.Delete(path);
				return;
			}
			ErrorReporter.ReportDebug($"filename {fileName} couldn't be found and wasn't deleted. Investigate and Fix.");
		}

		public void Delete(Type bizoType, string fileName)
		{
			var method = typeof(VDataContext).GetMethod(nameof(Delete), new Type[] { typeof(string) });
			var generic = method.MakeGenericMethod(bizoType);
			generic.Invoke(this, new[] { fileName });
		}
	}
}
