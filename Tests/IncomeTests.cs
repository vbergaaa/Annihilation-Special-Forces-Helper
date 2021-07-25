using NUnit.Framework;
using VBusiness.HelperClasses;
using VBusiness.Rooms;
using VEntityFramework.Model;

namespace Tests
{
	public class IncomeTests
	{
		[TestCase(RoomNumber.Room7, DifficultyLevel.Easy, 9 * 100 * 60.0 / 17.0, 0)]
		[TestCase(RoomNumber.Room7, DifficultyLevel.Impossible, 5 * 100 * 60.0 / 17, 100 * 60.0 / 17)]
		[TestCase(RoomNumber.Room5, DifficultyLevel.Easy, (10 * 20 + 40 * 4) * 60.0 / 17, 0)]
		[TestCase(RoomNumber.Room5, DifficultyLevel.Impossible, (10 * 35 + 80 * 5) * 60.0 / 17.0, 80 * 60.0 / 17)]
		public void TestResourcesPerWave(RoomNumber room, DifficultyLevel diff, double expectedMinerals, double expectedKills)
		{
			var loadout = TestHelper.GetTestLoadout();
			loadout.SetDifficulty(diff);
			loadout.SetFarmRoom(room);
			var calc = new IncomeCalculator(loadout);

			Assert.That(calc.GetMineralsPerMinute(), Is.EqualTo(expectedMinerals).Within(0.1));
			Assert.That(calc.GetKillsPerMinute(), Is.EqualTo(expectedKills).Within(0.1));
		}

		[TestCase(RoomNumber.Room9, DifficultyLevel.Insane, 2541.1, 0)]
		[TestCase(RoomNumber.Room9, DifficultyLevel.Brutal, 3141.1, 0)]
		public void TestResourcesPerWaveForBrutas(RoomNumber room, DifficultyLevel diff, double expectedMinerals, double expectedKills)
		{
			var loadout = TestHelper.GetTestLoadout();
			loadout.SetDifficulty(diff);
			loadout.SetFarmRoom(room);
			var calc = new IncomeCalculator(loadout);

			Assert.That(calc.GetMineralsPerMinute(), Is.EqualTo(expectedMinerals).Within(0.1));
			Assert.That(calc.GetKillsPerMinute(), Is.EqualTo(expectedKills).Within(0.1));
		}
	}
}
