using System;
using System.IO;
using System.Linq;
using System.Xml;
using VEntityFramework.Data;
using VEntityFramework.DataContext;
using VEntityFramework.Model;

namespace VEntityFramework.XML
{
	class VXMLReader
	{
		#region GetAllNames

		internal string[] GetAllFilenames<T>() where T : VBusinessObject
		{
			var directory = DirectoryManager.GetFullDirectory<T>();
			var files = Directory.GetFiles(directory);
			return files.Where(f => f.EndsWith(".xml")).Select(f => Path.GetFileNameWithoutExtension(f)).ToArray();
		}

		#endregion

		#region Read

		internal T Read<T>(string fileName) where T : VBusinessObject
		{
			if (DirectoryManager.CheckFileExists<T>(fileName))
			{
				return ReadXML<T>(fileName);
			}
			return null;
		}

		T ReadXML<T>(string fileName) where T : VBusinessObject
		{
			var xml = new XmlDocument();
			var xmlPath = DirectoryManager.GetFullPathWithExtension<T>(fileName);
			xml.Load(xmlPath);
			var bizo = (T)CreateBizoFromXML(typeof(T), xml.DocumentElement);
			bizo.OnLoadedFromXML(new OnLoadedEventArgs(Path.GetFileNameWithoutExtension(fileName)));
			bizo.XmlLocation = xmlPath;
			return bizo;
		}

		VBusinessObject CreateBizoFromXML(Type type, XmlElement documentElement)
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
#if DEBUG
				_ when typeof(VLoadoutSouls).IsAssignableFrom(type) => new SimpleXMLReader(),
				_ when typeof(VChallengePoint).IsAssignableFrom(type) => new SimpleXMLReader(),
				_ when typeof(VProfile).IsAssignableFrom(type) => new SimpleXMLReader(),
				_ when typeof(VSoulCollection).IsAssignableFrom(type) => new SimpleXMLReader(),
				_ when typeof(VBusinessObject).IsAssignableFrom(type) => throw new NotImplementedException($"{type.Name} does not have an associated xml reader. Create one if needed, or add it to this exception list"),
#endif
				_ => new SimpleXMLReader(),
			};
		}

		VBusinessObject CreateInstance(Type type, XmlElement documentElement)
		{
			if (typeof(VSoul).IsAssignableFrom(type))
			{
				var typeName = GetSoulName(documentElement);
				return BizoCreator.Create(type, typeName);
			}
			return (VBusinessObject)type.Assembly.CreateInstance(type.FullName);
		}

		string GetSoulName(XmlElement documentElement)
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
