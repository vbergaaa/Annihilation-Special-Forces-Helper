using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class PromotionSoul : HighSoul
	{
		public PromotionSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Promotion;

		public override void ActivateUniqueEffect()
		{
			base.ActivateUniqueEffect();
			Loadout.IncomeManager.RankRevision += 15;
		}

		public override void DeactivateUniqueEffect()
		{
			base.ActivateUniqueEffect();
			Loadout.IncomeManager.RankRevision -= 15;
		}
	}
}
