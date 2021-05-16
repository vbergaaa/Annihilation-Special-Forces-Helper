using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class VeterancySoul : LowerSoul
	{
		public VeterancySoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Veterancy;

		public override void ActivateUniqueEffect()
		{
			base.ActivateUniqueEffect();
			Loadout.IncomeManager.Veterancy += 50;
		}

		public override void DeactivateUniqueEffect()
		{
			base.DeactivateUniqueEffect();
			Loadout.IncomeManager.Veterancy -= 50;
		}
	}
}
