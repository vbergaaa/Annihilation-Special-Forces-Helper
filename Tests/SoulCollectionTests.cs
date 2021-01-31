using EnumsNET;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VBusiness.Profile;
using VBusiness.Souls;
using VEntityFramework.Model;
using VUserInterface;

namespace Tests
{
	class SoulCollectionTests
	{
		[Test]
		public void TestAddingSouls()
		{
			var soulCollection = new SoulCollection(Profile.GetProfile());

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
			var highestNonUniqueSoulType = Soul.HighestNonUniqueSoul;

			var type = typeof(SoulCollection);
			var allUniqueSoulTypes = Enums.GetValues<SoulType>().Where(s => s > highestNonUniqueSoulType);

			foreach (var soul in allUniqueSoulTypes)
			{
				Assert.That(type.GetProperty($"Has{soul}Soul"), Is.Not.Null, $"Has{soul}Soul could not be found");
			}
		}

		[Test]
		public void TestSoulCollectionFormBindingsWorkForAllEnums()
		{
			// this test will throw an exception if properties such as 'HasBronzeSoul' are missing from SoulCollection.cs and causing binding errors when trying to open on the soul collection form
			var totalUniqueSouls = Enums.GetValues<SoulType>().Count - (int)Soul.HighestNonUniqueSoul;
			var lastPage = ((totalUniqueSouls - 1) / 15) + 1;

			using (var form = new SoulCollectionForm(Profile.GetProfile()))
			{
				try
				{
					var soulCollectionControl = (SoulCollectionControl)form.Controls.Find("SoulCollectionControl", false).First();
					soulCollectionControl.Page = lastPage;
					form.Show();
				}
				catch (Exception ex)
				{
					Assert.Fail(ex.Message);
				}
			}
		}
	}
}
