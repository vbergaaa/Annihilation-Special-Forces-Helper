using NUnit.Framework;
using System.IO;
using System.Linq;
using System.Xml;
using VBusiness.Loadouts;
using VBusiness.Perks;
using VEntityFramework.Data;
using VEntityFramework.Model;
using VEntityFramework.XML;

namespace Tests
{
	class XMLTests
	{
		[Test]
		public void TestXmlPerks()
		{
			var collection = new PerkCollectionForTest();
			foreach (var perk in collection.AllPerks)
			{
				Assert.IsNotNull(PerkCollectionXMLReaderTestMethods.TestGetPerkFromCode(typeof(PerkCollection), perk.Code), $"Perk {perk.Code} will fail to import");
			}
		}

		[Test]
		public void TestReadUnitsList()
		{
			// This XML format is for XML's created in v0.8
			// The format changed in v0.9
			var xmlToRead = @"<Loadout>
  <Units>
	<Unit>
	  <CurrentInfusion>2</CurrentInfusion>
	  <UnitRank>SC</UnitRank>
	  <EssenceStacks>0</EssenceStacks>
	  <HasUnitSpec>True</HasUnitSpec>
	  <Key>Striker</Key>
	</Unit>
	<Unit>
	  <CurrentInfusion>3</CurrentInfusion>
	  <UnitRank>None</UnitRank>
	  <EssenceStacks>6</EssenceStacks>
	  <HasUnitSpec>True</HasUnitSpec>
	  <Key>UnstableDreadnought</Key>
	</Unit>
	<Unit>
	  <CurrentInfusion>3</CurrentInfusion>
	  <UnitRank>XYZ</UnitRank>
	  <EssenceStacks>6</EssenceStacks>
	  <HasUnitSpec>True</HasUnitSpec>
	  <Key>SplitterAdept</Key>
	</Unit>
  </Units>
</Loadout>";

			var xmlDoc = new XmlDocument();
			xmlDoc.LoadXml(xmlToRead);

			var loadout = (Loadout)VXMLReader.CreateBizoFromXML(typeof(Loadout), xmlDoc.DocumentElement);
			Assert.That(loadout.Units.ToArray(), Has.Length.EqualTo(3));
		}

		[Test]
		public void FullXml()
		{
			var loadout = GetFullyPopulatedLoadout();
			loadout.Save();
			
			var xml = new XmlDocument();
			var xmlPath = Directory.GetCurrentDirectory() + "/Loadouts/9999-XMLTEST.xml";
			xml.Load(xmlPath);
			var firstXml = xml.DocumentElement.InnerText;

			var loadout2 = VDataContext.ReadFromXML<Loadout>("9999-XMLTEST");
			loadout2.Save();

			xml = new XmlDocument();
			xml.Load(xmlPath);
			var secondXml = xml.DocumentElement.InnerText;

			Assert.That(firstXml, Is.EqualTo(secondXml), "if these are different, then the xml import > export doesn't work correctly");
		}

        #region	GetFullyPopulatedLoadout

        static VLoadout GetFullyPopulatedLoadout()
		{
			var loadout = new Loadout();
			loadout.ShouldRestrict = false;
            AddMaxPerks(loadout);
            AddCP(loadout);
            AddMaxGems(loadout);
            AddUnits(loadout);
            AddUpgrades(loadout);
            AddSouls(loadout);
            PopulateOtherProperties(loadout);
			return loadout;
		}

        static void PopulateOtherProperties(Loadout loadout)
		{
			loadout.UnitSpec = UnitType.Templar;
			loadout.Name = "XMLTEST";
			loadout.Slot = 9999;
			loadout.IncomeManager.FarmRoom = VBusiness.Rooms.RoomNumber.Room5;
		}

		private static void AddSouls(Loadout loadout)
		{
			loadout.Souls.SoulSlot1 = 1;
			loadout.Souls.SoulSlot2 = 2;
			loadout.Souls.SoulSlot3 = 3;
		}

        static void AddUpgrades(Loadout loadout)
		{
			loadout.Upgrades.AttackSpeedUpgrade = 15;
			loadout.Upgrades.AttackUpgrade = 20;
			loadout.Upgrades.HealthArmorUpgrade = 43;
			loadout.Upgrades.HealthUpgrade = 58;
			loadout.Upgrades.ShieldsArmorUpgrade = 81;
			loadout.Upgrades.ShieldsUpgrade = 99;
		}

        static void AddUnits(Loadout loadout)
		{
			var unit = VUnit.New(UnitType.WarpLord, loadout);
			unit.EssenceStacks = 15;
			unit.CurrentInfusion = 10;
			unit.UnitRank = UnitRankType.XYZ;
			loadout.Units.Add(unit);

			unit = VUnit.New(UnitType.WingedArchon, loadout);
			unit.EssenceStacks = 3;
			unit.CurrentInfusion = 8;
			unit.UnitRank = UnitRankType.SSS;
			loadout.Units.Add(unit);
		}

        static void AddMaxGems(Loadout loadout)
		{
			loadout.Gems.AttackGem.CurrentLevel = 10;
			loadout.Gems.AttackSpeedGem.CurrentLevel = 20;
			loadout.Gems.HealthGem.CurrentLevel = 30;
			loadout.Gems.HealthArmorGem.CurrentLevel = 40;
			loadout.Gems.ShieldsGem.CurrentLevel = 50;
			loadout.Gems.ShieldsArmorGem.CurrentLevel = 60;
			loadout.Gems.CritChanceGem.CurrentLevel = 70;
			loadout.Gems.CritDamageGem.CurrentLevel = 80;
			loadout.Gems.DoubleWarpGem.CurrentLevel = 90;
			loadout.Gems.TripleWarpGem.CurrentLevel = 100;
		}

        static void AddCP(Loadout loadout)
		{
			loadout.ChallengePoints.Attack.CurrentLevel = 1;
			loadout.ChallengePoints.AttackSpeed.CurrentLevel = 2;
			loadout.ChallengePoints.CriticalChance.CurrentLevel = 3;
			loadout.ChallengePoints.CriticalDamage.CurrentLevel = 4;
			loadout.ChallengePoints.Health.CurrentLevel = 5;
			loadout.ChallengePoints.Shields.CurrentLevel = 6;
			loadout.ChallengePoints.DefensiveEssence.CurrentLevel = 7;
			loadout.ChallengePoints.DamageReduction.CurrentLevel = 8;
			loadout.ChallengePoints.Mining.CurrentLevel = 9;
			loadout.ChallengePoints.Kills.CurrentLevel = 10;
			loadout.ChallengePoints.Veterancy.CurrentLevel = 1;
			loadout.ChallengePoints.Acceleration.CurrentLevel = 2;
		}

        static void AddMaxPerks(Loadout loadout)
		{
			var perks = (PerkCollection)loadout.Perks;
			foreach (var perk in perks.AllPerks)
			{
				perk.DesiredLevel = perk.MaxLevel;
			}
		}

		#endregion
	}
}
