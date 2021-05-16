using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class ScavengerSoul : LowSoul
	{
		public ScavengerSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Scavenger;

		public override void ActivateUniqueEffect()
		{
			base.ActivateUniqueEffect();
			Loadout.IncomeManager.InfuseRecycle += 10;
		}

		public override void DeactivateUniqueEffect()
		{
			base.ActivateUniqueEffect();
			Loadout.IncomeManager.InfuseRecycle -= 10;
		}
	}
}
