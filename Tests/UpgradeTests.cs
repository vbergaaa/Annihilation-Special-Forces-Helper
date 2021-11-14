using NUnit.Framework;
using VEntityFramework.Model;

namespace Tests
{
	public class UpgradeTests
	{
		[TestCase(DifficultyLevel.VeryEasy, 1, 400)]
		[TestCase(DifficultyLevel.VeryEasy, 2, 870)]
		[TestCase(DifficultyLevel.ZeroV, 1, 1200)]
		[TestCase(DifficultyLevel.ZeroV, 2, 2470)]
		public void TestBaseArmorUpgradeCosts(DifficultyLevel diff, int level, int expected)
		{
			var loadout = TestHelper.GetEmptyLoadout();
			loadout.UnitConfiguration.DifficultyLevel = diff;
			loadout.Upgrades.HealthArmorUpgrade = level;

			Assert.That(loadout.Upgrades.UpgradesCost, Is.EqualTo(expected));
		}
	}
}
