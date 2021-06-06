using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class UrusySoul : LowSoul
	{
		public UrusySoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Urusy;

		public override void ActivateUniqueEffect()
		{
			base.ActivateUniqueEffect();
			Loadout.IncomeManager.HasUrusy = true;
		}

		public override void DeactivateUniqueEffect()
		{
			base.DeactivateUniqueEffect();
			Loadout.IncomeManager.HasUrusy = false;
		}
	}
}
