using NUnit.Framework;
using VBusiness.Mods;
using VBusiness.Profile;
using VEntityFramework.Model;

namespace Tests
{
	public class ModsTest
	{
		[TestCase(2008, DifficultyLevel.Nightmare)]
		[TestCase(2010, DifficultyLevel.Hard)]
		[TestCase(2013, DifficultyLevel.VeryEasy)]
		public void MaxModScore(int expectedScore, DifficultyLevel diff)
		{
			var loadout = TestHelper.GetTestLoadout();
			loadout.UnitConfiguration.DifficultyLevel = diff;
			foreach (var mod in loadout.Mods.AllMods)
			{
				mod.CurrentLevel = mod.MaxValue;
			}
			((ModsCollection)loadout.Mods).PreventRoundingModscoreForTest = true;
			Assert.That(loadout.Mods.TotalModScore, Is.EqualTo(expectedScore));
		}

		[TestCase(100, 0, 0, 100)]
		[TestCase(100, 0, 1, 94)]
		[TestCase(100, 0, 10, 40)]
		[TestCase(1000000, 20000, 0, 2000000)]
		[TestCase(1000000, 20000, 10, 800000)]
		[TestCase(2099326, 23938, 10, 1843040)]
		[TestCase(2099326, 23938, 5, 3225320)]
		[TestCase(2099326, 23938, 1, 4331144)]
		[TestCase(2099326, 23938, 0, 4607631)]
		public void Taxes(int rp, int modScore, short taxes, int expected)
		{
			var profile = Profile.GetProfile();
			var oldPP = profile.PerkPoints;

			using (profile.TemporarilyModifyProfile(rp, modScore))
			{
				var loadout = TestHelper.GetEmptyLoadout();
				loadout.Mods.Taxes.CurrentLevel = taxes;
				Assert.That(loadout.RemainingPerkPoints, Is.EqualTo(expected));
			}


			Assert.That(profile.PerkPoints, Is.EqualTo(oldPP));
		}
	}
}
