using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public abstract class Perk : VPerk
	{
		public Perk() { }

		public override int Cost
		{
			get => this.GetCost();
		}
	}
}
