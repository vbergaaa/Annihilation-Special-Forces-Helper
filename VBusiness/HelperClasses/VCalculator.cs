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
