using VModel;

namespace VBusiness.HelperClasses
{
	public static class VPerkExtensions
	{
		public static int GetCost(this VPerk perk)
		{
			return VCalculator.Calculate(perk.StartingCost, perk.IncrementCost, perk.CurrentLevel, perk.DesiredLevel);
		}
	}
}

#region Test
#if DEBUG

namespace VBusiness.HelperClasses.Testing
{
	using NUnit.Framework;
	using VBusiness.Perks;

	[TestFixture]
	class VPerkExtensionsTest
	{
		[Test]
		[TestCase(0, 10, 550)]
		[TestCase(0, 5, 150)]
		[TestCase(5, 10, 400)]
		[TestCase(10, 10, 0)]
		[TestCase(10, 12, 0)]
		[TestCase(0, 0, 0)]
		[TestCase(10, 5, 0)]
		public void TestGetCost(short currentLevel, short desiredLevel, int expected)
		{
			var perk = new AttackPerk
			{
				CurrentLevel = currentLevel,
				DesiredLevel = desiredLevel,
			};

			var result = perk.GetCost();

			Assert.AreEqual(expected, result);
		}
	}
}

#endif
#endregion
