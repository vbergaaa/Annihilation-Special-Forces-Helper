namespace VBusiness.HelperClasses
{
	public static class VCalculator
	{
		public static int Calculate(int startingCost, int incrementCost, int currentLevel, int maxLevel)
		{
			if (currentLevel >= maxLevel)
			{
				return 0;
			}
			var a = maxLevel - currentLevel - 1f;
			var b = a / 2;
			var c = startingCost + incrementCost * b;
			var d = c * (maxLevel - currentLevel);

			return (int)((startingCost + incrementCost * (maxLevel - currentLevel - 1f) / 2) * (maxLevel - currentLevel));
		}
	}
}

#region Testing
#if DEBUG

namespace VModel.HelperClasses.Testing
{
	using NUnit.Framework;
	using VBusiness.HelperClasses;

	[TestFixture]
	public class IncrementCalculatorTest
	{
		[Test]
		[TestCase(1, 0, 0, 1, 1)]
		[TestCase(1, 1, 0, 3, 6)]
		[TestCase(10, 15, 0, 10, 775)]
		[TestCase(10, 15, 5, 10, 575)]
		[TestCase(10, 15, 10, 10, 0)]
		[TestCase(10, 15, 10, 10, 0)]
		[TestCase(10, 15, 10, 5, 0)]
		public void TestCalculate(int startingCost, int incrementCost, int currentLevel, int maxLevel, int expectedValue)
		{
			var result = VCalculator.Calculate(startingCost, incrementCost, currentLevel, maxLevel);
			Assert.AreEqual(expectedValue, result);
		}
	}
}

#endif
#endregion
