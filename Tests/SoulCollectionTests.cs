using EnumsNET;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VBusiness.Souls;
using VEntityFramework.Model;

namespace Tests
{
	class SoulCollectionTests
	{
		[Test]
		public void TestAddingSouls()
		{
			var soulCollection = new SoulCollection();

			Assert.That(soulCollection.DiscoveredSouls, Has.Count.EqualTo(0));
			Assert.That(soulCollection.HasBronzeSoul, Is.False);

			soulCollection.HasBronzeSoul = true;

			Assert.That(soulCollection.DiscoveredSouls, Has.Count.EqualTo(1));
			Assert.That(soulCollection.HasBronzeSoul, Is.True);

			soulCollection.HasBronzeSoul = false;

			Assert.That(soulCollection.DiscoveredSouls, Has.Count.EqualTo(0));
			Assert.That(soulCollection.HasBronzeSoul, Is.False);
		}

		[Test]
		public void TestAllUniqueSoulsAreInSoulCollection()
		{
			// In the future, if adding new souls, this test will fail. Please increment the highest soul type below to make the test suitable for the new unique souls
			var highestNonUniqueSoulType = SoulType.Divine;

			var type = typeof(SoulCollection);
			var allUniqueSoulTypes = Enums.GetValues<SoulType>().Where(s => s > highestNonUniqueSoulType);

			foreach (var soul in allUniqueSoulTypes)
			{
				Assert.That(type.GetProperty($"Has{soul}Soul"), Is.Not.Null, $"Has{soul}Soul could not be found");
			}
		}
	}
}
