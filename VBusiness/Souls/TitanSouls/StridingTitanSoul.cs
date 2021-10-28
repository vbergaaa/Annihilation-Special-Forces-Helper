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
			Loadout.Stats.UpdateHealth("Core", 20);
			Loadout.Stats.UpdateShields("Core", 20);
			Loadout.Stats.UpdateAcceleration("stitan", 20); // this also updates attack speed, haven't fully tested this.
		}

		public override void DeactivateUniqueEffect()
		{
			Loadout.Stats.Attack -= 20;
			Loadout.Stats.UpdateShields("Core", -20);
			Loadout.Stats.UpdateHealth("Core", -20);
			Loadout.Stats.UpdateAcceleration("stitan", -20);
		}
	}
}
