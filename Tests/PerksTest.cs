using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using VBusiness.Loadouts;
using VBusiness.Perks;
using VEntityFramework.Model;

namespace Tests
{
	public class PerksTest
	{
		[Test]
		public void TestAllSoulsAreInSoulCollection()
		{
			var perkCollection = new PerkCollectionForTest();

			var allPerkPropertyInfos = typeof(PerkCollection).GetProperties().Where(p => p.PropertyType == typeof(VPerk));

			foreach (var property in allPerkPropertyInfos)
			{
				var actualPerk = property.GetValue(perkCollection);
				Assert.That(perkCollection.AllPerks.Contains(actualPerk), $"{actualPerk.GetType().Name} wasn't found in AllPerks");
			}
		}
	}

	class PerkCollectionForTest : PerkCollection
	{
		public PerkCollectionForTest() : base(new Loadout())
		{
		}

		public IEnumerable<VPerk> AllPerks => this.allPerks;
	}
}
