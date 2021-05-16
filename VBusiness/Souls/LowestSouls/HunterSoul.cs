using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class HunterSoul : LowestSoul
	{
		public HunterSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Hunter;

		public override void ActivateUniqueEffect()
		{
			base.ActivateUniqueEffect();
			Loadout.IncomeManager.Veterancy += 30;
		}

		public override void DeactivateUniqueEffect()
		{
			base.DeactivateUniqueEffect();
			Loadout.IncomeManager.Veterancy -= 30;
		}
	}
}
