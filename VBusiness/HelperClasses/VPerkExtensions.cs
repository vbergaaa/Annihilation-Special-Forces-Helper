using VEntityFramework.Model;

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