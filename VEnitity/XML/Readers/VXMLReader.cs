using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Xml;
using VEntityFramework.Attributes;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VEntityFramework.XML
{
	class VXMLReader
	{
		#region GetAllNames

		internal string[] GetAllFilenames<T>() where T : VBusinessObject
		{
			var fullPath = GetFullDirectory<T>();
			var files = Directory.GetFiles(fullPath);
			return files.Where(f => f.EndsWith(".xml")).Select(f => Path.GetFileNameWithoutExtension(f)).ToArray();
		}

#endregion

		#region Read

		internal T Read<T>(string fileName) where T : VBusinessObject
		{
			EnsureFileNameHasXMLExtension(ref fileName);
			if (CheckFileExists<T>(fileName))
			{
				return ReadXML<T>(fileName);
			}
			return null;
		}

		T ReadXML<T>(string fileName) where T : VBusinessObject
		{
			var xml = new XmlDocument();
			var xmlPath = GetFullPath<T>(fileName);
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
				_ when typeof(VSoulCollection).IsAssignableFrom(type) => new SimpleXMLReader(),
				_ when typeof(VChallengePoint).IsAssignableFrom(type) => new SimpleXMLReader(),
				_ when typeof(VBusinessObject).IsAssignableFrom(type) => throw new NotImplementedException($"{type.Name} does not have an associated xml reader. Create one, or add it to this exception list"),
#endif
				_ => new SimpleXMLReader(),
			};
		}

		VBusinessObject CreateInstance(Type type, XmlElement documentElement)
		{
			if (typeof(VSoul).IsAssignableFrom(type))
			{
				var typeName = GetTypeNameForSoul(documentElement);
				var myAssembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(Directory.GetCurrentDirectory() + "/VBusiness.dll");
				var myType = myAssembly.GetType(typeName);
				var ctor = myType.GetConstructors()[0];
				return (VBusinessObject)ctor.Invoke(new object[] { null });
			}
			return (VBusinessObject)type.Assembly.CreateInstance(type.FullName);
		}

		string GetTypeNameForSoul(XmlElement documentElement)
		{
			var soulType = "";
			foreach (XmlNode xmlNode in documentElement.ChildNodes)
			{
				if (xmlNode.Name == "Type")
				{
					soulType = xmlNode.InnerText;
					break;
				}
			}

			return $"VBusiness.Souls.{soulType}Soul";
		}

		bool CheckFileExists<T>(string fileName)
		{
			return File.Exists(GetFullPath<T>(fileName));
		}

		void EnsureFileNameHasXMLExtension(ref string fileName)
		{
			var extension = Path.GetExtension(fileName);
			if (extension != "xml")
			{
				if (extension != "")
				{
					throw new DeveloperException("What type is this extension?");
				}
				else
				{
					fileName += ".xml";
				}
			}
		}

		internal string GetFullPath<T>(string fileName)
		{
			return GetFullDirectory<T>() + fileName;
		}

		string GetFullDirectory<T>()
		{
			var atr = (TopLevelBusinessObjectAttribute)typeof(T).GetCustomAttribute(typeof(TopLevelBusinessObjectAttribute));
			if (atr != null)
			{
				var pathHint = atr.PathHint;
				var fullDirectory = $"{Directory.GetCurrentDirectory()}/{pathHint}/";

				if (!Directory.Exists(fullDirectory))
				{
					Directory.CreateDirectory(fullDirectory);
				}

				return fullDirectory;
			}

			throw new DeveloperException("We shouldn't be trying to retrieve objects that aren't TopLevelBusinessObjects. Please implement the attribute to define the storage location");
		}

		#endregion
	}
}
