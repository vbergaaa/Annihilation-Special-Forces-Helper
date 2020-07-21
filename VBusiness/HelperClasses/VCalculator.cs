namespace VBusiness.HelperClasses
{
	public static class VCalculator
	{
		public static int Calculate(int startingCost, int incrementCost, int currentLevel, int desiredLevel)
		{
			if (currentLevel >= desiredLevel)
			{
				return 0;
			}
			return (int)((2 * startingCost + incrementCost * (desiredLevel + currentLevel - 1)) / 2f * (desiredLevel - currentLevel));
		}
	}
}
