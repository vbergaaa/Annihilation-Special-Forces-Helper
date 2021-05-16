using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class AccelleratedAdvancementSoul : HighestSoul
	{
		public AccelleratedAdvancementSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.AccelleratedAdvancement;

		public override void ActivateUniqueEffect()
		{
			base.ActivateUniqueEffect();
			Loadout.IncomeManager.HasRefundSoul = true;
		}

		public override void DeactivateUniqueEffect()
		{
			base.DeactivateUniqueEffect();
			Loadout.IncomeManager.HasRefundSoul = false;
		}
	}
}
