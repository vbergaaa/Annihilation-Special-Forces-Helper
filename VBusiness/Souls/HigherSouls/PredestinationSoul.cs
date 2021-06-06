using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class PredestinationSoul : HigherSoul
	{
		public PredestinationSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Predestination;

		public override void ActivateUniqueEffect()
		{
			base.ActivateUniqueEffect();
			Loadout.IncomeManager.HasRSS = true;
		}

		public override void DeactivateUniqueEffect()
		{
			base.DeactivateUniqueEffect();
			Loadout.IncomeManager.HasRSS = false;
		}
	}
}
