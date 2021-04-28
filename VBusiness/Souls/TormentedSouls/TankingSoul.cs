using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class TankingSoul : TormentedSoul
	{
		public TankingSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Tanking;

		public override void ActivateUniqueEffect()
		{
			Loadout.Stats.AdditiveArmor += 3;
			Loadout.Stats.UpdateDamageReduction("Core", 5);
		}

		public override void DeactivateUniqueEffect()
		{
			Loadout.Stats.AdditiveArmor -= 3;
			Loadout.Stats.UpdateDamageReduction("Core", -5);
		}
	}
}
