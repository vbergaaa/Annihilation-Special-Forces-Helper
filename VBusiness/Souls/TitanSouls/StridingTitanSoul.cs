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
			Loadout.Stats.UpdateHealth("Core", 20);
			Loadout.Stats.UpdateShields("Core", 20);
			VEntityFramework.ErrorReporter.ReportDebug("Check how this works for health and shields.");
			VEntityFramework.ErrorReporter.ReportDebug("Check how this works for acceleration");
		}

		public override void DeactivateUniqueEffect()
		{
			Loadout.Stats.Attack -= 20;
			Loadout.Stats.UpdateAttackSpeed("stitan", -20);
			Loadout.Stats.UpdateShields("Core", -20);
			Loadout.Stats.UpdateHealth("Core", -20);
		}
	}
}
