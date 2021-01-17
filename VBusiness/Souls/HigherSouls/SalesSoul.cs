using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class SalesSoul : HigherSoul
	{
		public SalesSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Sales;
	}
}
