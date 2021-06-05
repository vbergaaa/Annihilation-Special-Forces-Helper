using NUnit.Framework;
using VBusiness.HelperClasses;
using VBusiness.Rooms;
using VEntityFramework.Model;

namespace Tests
{
	public class IncomeTests
	{
		[TestCase(RoomNumber.Room7, DifficultyLevel.Easy, 9 * 100, 0)]
		[TestCase(RoomNumber.Room7, DifficultyLevel.Impossible, 5 * 100, 100)]
		[TestCase(RoomNumber.Room5, DifficultyLevel.Easy, 10 * 20 + 40 * 4, 0)]
		[TestCase(RoomNumber.Room5, DifficultyLevel.Impossible, 10 * 35 + 80 * 5, 80)]
		public void TestResourcesPerWave(RoomNumber room, DifficultyLevel diff, double expectedMinerals, double expectedKills)
		{
			var loadout = TestHelper.GetEmptyLoadout();
			loadout.SetFarmRoom(room);
			loadout.SetDifficulty(diff);
			var calc = new IncomeCalculator(loadout);

			Assert.That(calc.GetMineralsPerWave(), Is.EqualTo(expectedMinerals));
			Assert.That(calc.GetKillsPerWave(), Is.EqualTo(expectedKills));
		}
	}
}
