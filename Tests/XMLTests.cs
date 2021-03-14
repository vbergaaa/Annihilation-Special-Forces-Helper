using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using VBusiness.Loadouts;
using VBusiness.Perks;
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

			var reader = new VXMLReader();
			var loadout = (Loadout)reader.CreateBizoFromXML(typeof(Loadout), xmlDoc.DocumentElement);
			Assert.That(loadout.Units.ToArray(), Has.Length.EqualTo(3));
		}
	}
}
