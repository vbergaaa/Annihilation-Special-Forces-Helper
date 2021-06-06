using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class GreedSoul : MidSoul
	{
		public GreedSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Greed;

		public override int MinMinerals => 3000;

		public override int MaxMinerals => 4000;

		public override void ActivateUniqueEffect()
		{
			base.ActivateUniqueEffect();
			Loadout.IncomeManager.HasGreed = true;
		}

		public override void DeactivateUniqueEffect()
		{
			base.DeactivateUniqueEffect();
			Loadout.IncomeManager.HasGreed = false;
		}
	}
}
