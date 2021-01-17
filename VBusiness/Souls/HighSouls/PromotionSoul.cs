using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class PromotionSoul : HighSoul
	{
		public PromotionSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Promotion;
	}
}
