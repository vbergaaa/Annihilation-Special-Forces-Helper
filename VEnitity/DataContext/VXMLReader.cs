using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using VEntityFramework;
using VEntityFramework.Model;

namespace VEntityFramework.Data
{
	class VXMLReader
	{
		#region GetAllNames

		internal string[] GetAllLoadoutNames()
		{
			var path = GetLoadoutsDirectory();
			var files = Directory.GetFiles(path);
			return files.Where(fileName => fileName.EndsWith(".xml"))
				.Select(fileName => Path.GetFileNameWithoutExtension(fileName)).ToArray();
		}
		internal string[] GetAllSoulNames()
		{
			var path = GetSoulsDirectory();
			var files = Directory.GetFiles(path);
			return files.Where(fileName => fileName.EndsWith(".xml"))
				.Select(fileName => Path.GetFileNameWithoutExtension(fileName)).ToArray();
		}

		#endregion

		#region Read

		internal T Read<T>(string fileName) where T : VBusinessObject
		{
			EnsureFileNameHasXMLExtension(ref fileName);
			if (CheckFileExists(typeof(T), fileName))
			{
				return ReadXML<T>(fileName);
			}
			return null;
		}

		T ReadXML<T>(string fileName) where T : VBusinessObject
		{
			var xml = new XmlDocument();
			var xmlPath = GetFullPath(typeof(T), fileName);
			xml.Load(xmlPath);
			var bizo = (T)CreateBizoFromXML(typeof(T), xml.DocumentElement);
			bizo.OnLoadedFromXML(new OnLoadedEventArgs(Path.GetFileNameWithoutExtension(fileName)));
			bizo.XmlLocation = xmlPath;
			return bizo;
		}

		VBusinessObject CreateBizoFromXML(Type type, XmlElement documentElement)
		{
			var bizo = CreateInstance(type, documentElement);
			var reader = new VBizoXMLReader();
			reader.PopulateFromXML(bizo, documentElement);
			return bizo;
		}

		private VBusinessObject CreateInstance(Type type, XmlElement documentElement)
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

		bool CheckFileExists(Type bizoType, string fileName)
		{
			return File.Exists(GetFullPath(bizoType, fileName));
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

		internal string GetFullPath(Type bizoType, string fileName)
		{
			if (typeof(VLoadout).IsAssignableFrom(bizoType))
			{
				return GetLoadoutsDirectory() + fileName;
			}
			else if (typeof(VSoul).IsAssignableFrom(bizoType))
			{
				return GetSoulsDirectory() + fileName;
			}
			else
			{
				throw new DeveloperException($"Cannot read for type ${bizoType}");
			}
		}

		string GetLoadoutsDirectory()
		{
			var rootDirectory = Directory.GetCurrentDirectory();
			var loadoutsDirectory = rootDirectory + "/Loadouts/";

			if (!Directory.Exists(loadoutsDirectory))
			{
				Directory.CreateDirectory(loadoutsDirectory);
			}

			return loadoutsDirectory;
		}

		string GetSoulsDirectory()
		{
			var rootDirectory = Directory.GetCurrentDirectory();
			var soulsDirectory = rootDirectory + "/Souls/";

			if (!Directory.Exists(soulsDirectory))
			{
				Directory.CreateDirectory(soulsDirectory);
			}

			return soulsDirectory;
		}

		#endregion
	}

	internal class VBizoXMLReader
	{
		public void PopulateFromXML(VBusinessObject bizo, XmlNode documentElement)
		{
			using (bizo.SuspendSettingHasChanges())
			{
				foreach (XmlNode childNode in documentElement.ChildNodes)
				{
					var matchingProperty = GetMatchingProperty(bizo.GetType(), childNode);

					if (matchingProperty == null)
					{
						continue;
					}

					if (matchingProperty.IsBusinessObject())
					{
						var childBizo = (VBusinessObject)matchingProperty.GetValue(bizo);
						PopulateFromXML(childBizo, childNode);
					}
					else
					{
						if (!XmlKeys.Contains(childNode.Name))
						{
							matchingProperty.CastAndSetValue(childNode.InnerText, bizo);
						}
					}
				}
			}
			bizo.ExistsInXML = true;
		}

		string[] XmlKeys => xmlKeys ?? (xmlKeys = GetXmlKeys());
		string[] xmlKeys;
		string[] GetXmlKeys()
		{
			return new string[] { "Code", "Key", "Type" };
		}

		PropertyInfo GetMatchingProperty(Type type, XmlNode child)
		{
			return child.Name switch
			{
				"PerkCollection" => type.GetProperty("Perks"),
				"GemCollection" => type.GetProperty("Gems"),
				"SoulCollection" => type.GetProperty("Souls"),
				"ChallengePointCollection" => type.GetProperty("ChallengePoints"),
				"Gem" => GetGem(type, child),
				"Perk" => GetPerkFromCode(type, child),
				"ChallengePoint" => GetDefaultBizo(type, child),
				_ => type.GetProperty(child.Name),
			};
		}

		PropertyInfo GetGem(Type type, XmlNode node)
		{
			var name = "";
			foreach (XmlNode child in node.ChildNodes)
			{
				if (child.Name == "Key")
				{
					name = child.InnerText.Replace(" ", "") + "Gem";
				}
			}
			return type.GetProperty(name);
		}

		PropertyInfo GetDefaultBizo(Type type, XmlNode node)
		{
			var name = "";
			foreach (XmlNode child in node.ChildNodes)
			{
				if (child.Name == "Key")
				{
					name = child.InnerText.Replace(" ", "");
				}
			}
			return type.GetProperty(name);
		}

		PropertyInfo GetPerkFromCode(Type type, XmlNode node)
		{
			var code = "";
			foreach (XmlNode child in node.ChildNodes)
			{
				if (child.Name == "Code")
				{
					code = child.InnerText;
					break;
				}
			}

			return GetPerkFromCode(type, code);
		}

		PropertyInfo GetPerkFromCode(Type type, string code)
		{
			return code switch
			{
				"1_1" => type.GetProperty("Attack"),
				"1_2" => type.GetProperty("AttackSpeed"),
				"1_3" => type.GetProperty("Shields"),
				"1_4" => type.GetProperty("ShieldsArmor"),
				"1_5" => type.GetProperty("Health"),
				"1_6" => type.GetProperty("HealthArmor"),
				"2_1" => type.GetProperty("KillEfficiency"),
				"2_2" => type.GetProperty("KillRecycle"),
				"2_3" => type.GetProperty("MaximumPotiential"),
				"2_4" => type.GetProperty("Veterancy"),
				"2_5" => type.GetProperty("Rank"),
				"2_6" => type.GetProperty("InfusionRecycle"),
				"3_1" => type.GetProperty("DoubleWarp"),
				"3_2" => type.GetProperty("StartingMinerals"),
				"3_3" => type.GetProperty("MasterTrainer"),
				"3_4" => type.GetProperty("ExtraSupply"),
				"3_5" => type.GetProperty("MineralJackpot"),
				"3_6" => type.GetProperty("AutomaticRefinery"),
				"4_3" => type.GetProperty("AdrenalineRush"),
				"4_1" => type.GetProperty("CriticalChance"),
				"4_2" => type.GetProperty("CriticalDamage"),
				"4_6" => type.GetProperty("DamageReduction"),
				"4_4" => type.GetProperty("OverSpeed"),
				"4_5" => type.GetProperty("UnitSpecialization"),
				"5_1" => type.GetProperty("KillEfficiency2"),
				"5_4" => type.GetProperty("MaximumGather"),
				"5_3" => type.GetProperty("MaximumPotiential2"),
				"5_2" => type.GetProperty("QuickStart"),
				"5_6" => type.GetProperty("RankRevision"),
				"5_5" => type.GetProperty("Veterancy2"),
				"6_2" => type.GetProperty("BuildingRecycle"),
				"6_5" => type.GetProperty("CriticalCollection"),
				"6_6" => type.GetProperty("CriticalHarvest"),
				"6_1" => type.GetProperty("DoubleWarp2"),
				"6_3" => type.GetProperty("ExpertMiner"),
				"6_4" => type.GetProperty("MineralJackpot2"),
				"7_4" => type.GetProperty("AcceleratedFusion"),
				"7_6" => type.GetProperty("FastLearner"),
				"7_2" => type.GetProperty("MiningExpertise"),
				"7_3" => type.GetProperty("TrainingCenter"),
				"7_1" => type.GetProperty("TrifectaPower"),
				"7_5" => type.GetProperty("UnitStorage"),
				"8_5" => type.GetProperty("Alacrity"),
				"8_3" => type.GetProperty("BalancedTraining"),
				"8_4" => type.GetProperty("CooldownSpeed"),
				"8_1" => type.GetProperty("CriticalChance2"),
				"8_2" => type.GetProperty("CriticalDamage2"),
				"8_6" => type.GetProperty("RedCrits"),
				"9_2" => type.GetProperty("InfusionRecycle2"),
				"9_1" => type.GetProperty("KillHarvest"),
				"9_3" => type.GetProperty("MaximumPotiental3"),
				"9_4" => type.GetProperty("MaximumGather2"),
				"9_6" => type.GetProperty("RankRevision2"),
				"9_5" => type.GetProperty("Veterancy3"),
				"10_6" => type.GetProperty("AutomaticRefinery2"),
				"10_3" => type.GetProperty("CriticalHarvest2"),
				"10_1" => type.GetProperty("DoubleWarp3"),
				"10_5" => type.GetProperty("MineralJackpot3"),
				"10_4" => type.GetProperty("SuperJackpot"),
				"10_2" => type.GetProperty("TripleWarp"),
				"11_3" => type.GetProperty("BalancedTraining2"),
				"11_1" => type.GetProperty("CriticalChance3"),
				"11_2" => type.GetProperty("CriticalDamage3"),
				"11_5" => type.GetProperty("DamageReduction2"),
				"11_4" => type.GetProperty("SuperRush"),
				"11_6" => type.GetProperty("Alacrity2"),
				_ => throw new InvalidDataException($"Somehow, a code of {code} was passed in."),
			};
		}
	}
}
