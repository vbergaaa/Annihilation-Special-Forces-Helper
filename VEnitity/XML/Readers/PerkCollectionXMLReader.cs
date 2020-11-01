﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;

namespace VEntityFramework.XML
{
	internal class PerkCollectionXMLReader : BaseXMLReader
	{
		protected override PropertyInfo GetPropertyFromXML(Type type, XmlNode child)
		{
			if (child.Name == "Perk")
			{
				return GetPerkFromCode(type, child);
			}
			return base.GetPropertyFromXML(type, child);
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
				_ => throw new InvalidDataException($"{code} is an invalid code."),
			};
		}
	}
}