using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using VEntityFramework;

namespace VEntityFramework.Data
{
	class VXMLReader
	{
		#region GetAllLoadoutNames

		internal string[] GetAllLoadoutNames()
		{
			var path = GetLoadoutsDirectory();
			var files = Directory.GetFiles(path);
			return files.Where(fileName => fileName.EndsWith(".xml"))
				.Select(fileName => Path.GetFileNameWithoutExtension(fileName)).ToArray();
		}

		#endregion

		#region Read

		internal T Read<T>(string fileName) where T : VBusinessObject
		{
			try
			{
				EnsureFileNameHasXMLExtension(ref fileName);
				if (CheckFileExists(fileName))
				{
					return ReadXML<T>(fileName);
				}
			}
			catch
			{
				throw new IOException("Unable to load xml");
			}
			return null;
		}

		T ReadXML<T>(string fileName) where T : VBusinessObject
		{
			var xml = new XmlDocument();
			xml.Load(GetFullPath(fileName));
			var bizo = (T)CreateBizoFromXML(typeof(T), xml.DocumentElement);
			bizo.OnLoadedFromXML(new OnLoadedEventArgs(Path.GetFileNameWithoutExtension(fileName)));
			return bizo;
		}

		VBusinessObject CreateBizoFromXML(Type type, XmlElement documentElement)
		{
			var bizo = (VBusinessObject)type.Assembly.CreateInstance(type.FullName);
			var reader = new VBizoXMLReader();

			reader.PopulateFromXML(bizo, documentElement);
			return bizo;
		}

		bool CheckFileExists(string fileName)
		{
			return File.Exists(GetFullPath(fileName));
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

		internal string GetFullPath(string fileName)
		{
			return GetLoadoutsDirectory() + fileName;
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

		#endregion
	}

	internal class VBizoXMLReader
	{
		public void PopulateFromXML(VBusinessObject bizo, XmlNode documentElement)
		{
			bizo.SuspendSettingHasChanges = true;

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
			bizo.SuspendSettingHasChanges = false;
		}

		string[] XmlKeys => xmlKeys ?? (xmlKeys = GetXmlKeys());
		string[] xmlKeys;
		string[] GetXmlKeys()
		{
			return new string[] { "Code" };
		}

		PropertyInfo GetMatchingProperty(Type type, XmlNode child)
		{
			switch (child.Name)
			{
				case "PerkCollection": return type.GetProperty("Perks");
				case "Perk": return GetPerkFromCode(type, child);
				default: return type.GetProperty(child.Name);
			}
		}

		private PropertyInfo GetPerkFromCode(Type type, XmlNode node)
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

		private PropertyInfo GetPerkFromCode(Type type, string code)
		{
			switch (code)
			{
				case "1_1": return type.GetProperty("Attack");
				case "1_2": return type.GetProperty("AttackSpeed");
				case "1_3": return type.GetProperty("Health");
				case "1_4": return type.GetProperty("HealthArmor");
				case "1_5": return type.GetProperty("Shields");
				case "1_6": return type.GetProperty("ShieldsArmor");
				case "2_1": return type.GetProperty("KillEfficiency");
				case "2_2": return type.GetProperty("KillRecycle");
				case "2_3": return type.GetProperty("MaximumPotiential");
				case "2_4": return type.GetProperty("Veterancy");
				case "2_5": return type.GetProperty("Rank");
				case "2_6": return type.GetProperty("InfusionRecycle");
				case "3_1": return type.GetProperty("DoubleWarp");
				case "3_2": return type.GetProperty("StartingMinerals");
				case "3_3": return type.GetProperty("MasterTrainer");
				case "3_4": return type.GetProperty("ExtraSupply");
				case "3_5": return type.GetProperty("MineralJackpot");
				case "3_6": return type.GetProperty("AutomaticRefinery");
				case "4_1": return type.GetProperty("AdrenalineRush");
				case "4_2": return type.GetProperty("CriticalChance");
				case "4_3": return type.GetProperty("CriticalDamage");
				case "4_4": return type.GetProperty("DamageReduction");
				case "4_5": return type.GetProperty("OverSpeed");
				case "4_6": return type.GetProperty("UnitSpecialization");
				case "5_1": return type.GetProperty("KillEfficiency2");
				case "5_2": return type.GetProperty("MaximumGather");
				case "5_3": return type.GetProperty("MaximumPotiential2");
				case "5_4": return type.GetProperty("QuickStart");
				case "5_5": return type.GetProperty("RankRevision");
				case "5_6": return type.GetProperty("Veterancy2");
				case "6_1": return type.GetProperty("BuildingRecycle");
				case "6_2": return type.GetProperty("CriticalCollection");
				case "6_3": return type.GetProperty("CriticalHarvest");
				case "6_4": return type.GetProperty("DoubleWarp2");
				case "6_5": return type.GetProperty("ExpertMiner");
				case "6_6": return type.GetProperty("MineralJackpot2");
				case "7_1": return type.GetProperty("AcceleratedFusion");
				case "7_2": return type.GetProperty("FastLearner");
				case "7_3": return type.GetProperty("MiningExpertise");
				case "7_4": return type.GetProperty("TrainingCenter");
				case "7_5": return type.GetProperty("TrifectaPower");
				case "7_6": return type.GetProperty("UnitStorage");
				case "8_1": return type.GetProperty("Alacrity");
				case "8_2": return type.GetProperty("BalancedTraining");
				case "8_3": return type.GetProperty("CooldownSpeed");
				case "8_4": return type.GetProperty("CriticalChance2");
				case "8_5": return type.GetProperty("CriticalDamage2");
				case "8_6": return type.GetProperty("RedCrits");
				case "9_1": return type.GetProperty("InfusionRecycle2");
				case "9_2": return type.GetProperty("KillHarvest");
				case "9_3": return type.GetProperty("MaximumPotiental3");
				case "9_4": return type.GetProperty("MaximumGather2");
				case "9_5": return type.GetProperty("RankRevision2");
				case "9_6": return type.GetProperty("Veterancy3");
				case "10_1": return type.GetProperty("AutomaticRefinery2");
				case "10_2": return type.GetProperty("CriticalHarvest2");
				case "10_3": return type.GetProperty("DoubleWarp3");
				case "10_4": return type.GetProperty("MineralJackpot3");
				case "10_5": return type.GetProperty("SuperJackpot");
				case "10_6": return type.GetProperty("TripleWarp");
				case "11_1": return type.GetProperty("BalancedTraining2");
				case "11_2": return type.GetProperty("CriticalChance3");
				case "11_3": return type.GetProperty("CriticalDamage3");
				case "11_4": return type.GetProperty("DamageReduction2");
				case "11_5": return type.GetProperty("SuperRush");
				case "11_6": return type.GetProperty("Alacrity2");
				default: throw new InvalidDataException($"Somehow, a code of {code} was passed in.");
			}
		}
	}
}
