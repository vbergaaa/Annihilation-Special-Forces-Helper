using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
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
	}
}
