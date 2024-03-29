﻿using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using VEntityFramework.Data;
using VEntityFramework.DataContext;
using VEntityFramework.Model;

[assembly: InternalsVisibleTo("Tests")]
namespace VEntityFramework.XML
{
	class VXMLReader
	{
		#region GetAllNames

		internal static string[] GetAllFilenames<T>() where T : BusinessObject
		{
			var directory = DirectoryManager.GetFullDirectory<T>();
			var files = Directory.GetFiles(directory);
			return files.Where(f => f.EndsWith(".xml")).Select(f => Path.GetFileNameWithoutExtension(f)).ToArray();
		}

		#endregion

		#region Read

		internal static T Read<T>(string fileName) where T : BusinessObject
		{
			if (DirectoryManager.CheckFileExists<T>(fileName))
			{
				return ReadXML<T>(fileName);
			}
			return null;
		}

		static T ReadXML<T>(string fileName) where T : BusinessObject
		{
			try
			{
				var xml = new XmlDocument();
				var xmlPath = DirectoryManager.GetFullPathWithExtension<T>(fileName);
				xml.Load(xmlPath);
				var bizo = (T)CreateBizoFromXML(typeof(T), xml.DocumentElement);
				bizo.XmlLocation = xmlPath;
				bizo.OnLoadedFromXML(new OnLoadedEventArgs(Path.GetFileNameWithoutExtension(fileName)));
				return bizo;
			}
			catch (Exception ex)
			{
				Log.Error($"Failed to read file: {fileName}", ex);
				return null;
			}
		}

		internal static BusinessObject CreateBizoFromXML(Type type, XmlElement documentElement)
		{
			var bizo = CreateInstance(type, documentElement);
			var reader = GetXmlReader(type);
			reader.PopulateFromXML(bizo, documentElement);
			return bizo;
		}

		internal static BaseXMLReader GetXmlReader(Type type)
		{
			return type switch
			{
				Type _ when typeof(VPerk).IsAssignableFrom(type) => new PerkXMLReader(),
				Type _ when typeof(VGem).IsAssignableFrom(type) => new GemXMLReader(),
				Type _ when typeof(VSoul).IsAssignableFrom(type) => new SoulXMLReader(),
				Type _ when typeof(VUnitConfiguration).IsAssignableFrom(type) => new UnitConfigurationXMLReader(),
				Type _ when typeof(VLoadout).IsAssignableFrom(type) => new LoadoutXMLReader(),
				Type _ when typeof(VPerkCollection).IsAssignableFrom(type) => new PerkCollectionXMLReader(),
				Type _ when typeof(VGemCollection).IsAssignableFrom(type) => new GemCollectionXMLReader(),
				Type _ when typeof(VChallengePointCollection).IsAssignableFrom(type) => new ChallengePointCollectionXMLReader(),
				_ => new SimpleXMLReader(),
			};
		}

        static BusinessObject CreateInstance(Type type, XmlElement documentElement)
		{
			if (typeof(VSoul).IsAssignableFrom(type))
			{
				var typeName = GetSoulName(documentElement);
				return BizoCreator.Create(type, typeName);
			}
			return BizoCreator.Create(type);
		}

        static string GetSoulName(XmlElement documentElement)
		{
			foreach (XmlNode xmlNode in documentElement.ChildNodes)
			{
				if (xmlNode.Name == "Type")
				{
					return xmlNode.InnerText;
				}
			}
			return null;
		}

		#endregion
	}
}
