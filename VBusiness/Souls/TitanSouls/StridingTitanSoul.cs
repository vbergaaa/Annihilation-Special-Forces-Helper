using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class StridingTitanSoul : TitanSoul
	{
		public StridingTitanSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.StridingTitan;

		public override void ActivateUniqueEffect()
		{
			Loadout.Stats.Attack += 20;
			Loadout.Stats.UpdateAttackSpeed("stitan", 20);
			Loadout.Stats.UpdateHealth("stitan", 20);
			Loadout.Stats.UpdateShields("stitan", 20);
		}

		public override void DeactivateUniqueEffect()
		{
			Loadout.Stats.Attack -= 20;
			Loadout.Stats.UpdateAttackSpeed("stitan", -20);
			Loadout.Stats.UpdateShields("stitan", -20);
			Loadout.Stats.Loadout.Stats.UpdateHealth("stitan", -20);
		}
	}
}
