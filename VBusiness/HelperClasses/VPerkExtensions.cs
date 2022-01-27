using VEntityFramework.Model;

namespace VBusiness.HelperClasses
{
	public static class VPerkExtensions
	{
		public static int GetRemainingCost(this VPerk perk)
		{
			return VCalculator.Calculate(perk.StartingCost, perk.IncrementCost, 0, perk.DesiredLevel);
		}

		public static int GetTotalCost(this VPerk perk)
		{
			return VCalculator.Calculate(perk.StartingCost, perk.IncrementCost, 0, perk.DesiredLevel);
		}

		public static int GetCurrentCost(this VPerk perk)
		{
			return VCalculator.Calculate(perk.StartingCost, perk.IncrementCost, 0, 0);
		}

		public static int GetCostOfNextLevels(this VPerk perk, int increase = 1)
		{
			return VCalculator.Calculate(perk.StartingCost, perk.IncrementCost, perk.DesiredLevel, perk.DesiredLevel + increase);
		}
	}
}