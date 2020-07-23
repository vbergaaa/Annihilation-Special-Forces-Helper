using VEntityFramework.Model;

namespace VBusiness.HelperClasses
{
	public static class VPerkExtensions
	{
		public static int GetRemainingCost(this VPerk perk)
		{
			return VCalculator.Calculate(perk.StartingCost, perk.IncrementCost, perk.CurrentLevel, perk.DesiredLevel);
		}

		public static int GetTotalCost(this VPerk perk)
		{
			return VCalculator.Calculate(perk.StartingCost, perk.IncrementCost, 0, perk.DesiredLevel);
		}

		public static int GetCurrentCost(this VPerk perk)
		{
			return VCalculator.Calculate(perk.StartingCost, perk.IncrementCost, 0, perk.CurrentLevel);
		}
	}
}