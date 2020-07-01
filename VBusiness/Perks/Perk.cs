using VBusiness.HelperClasses;
using VModel;

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
