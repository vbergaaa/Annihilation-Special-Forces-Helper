using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class SelfMitigationMod : Mod
	{
		public SelfMitigationMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 15;

		public override string BizoName => "SelfMitigation";

		public override string Name => "Self Mitigation";

		protected override void OnModLevelChanged(int diff)
		{
			base.OnModLevelChanged(diff);

			Loadout.Stats.UpdateHealth("Core", -6 * diff);
			Loadout.Stats.UpdateShields("Core", -6 * diff);
			Loadout.Stats.UpdateHealthArmor("Core", -6 * diff);
			Loadout.Stats.UpdateShieldsArmor("Core", -6 * diff);
			Loadout.Stats.UpdateAcceleration("Core", -6 * diff);
			Loadout.Stats.UpdateAttackSpeed("Core", -6 * diff);
			Loadout.Stats.Attack -= 6 * diff;
		}
	}
}
