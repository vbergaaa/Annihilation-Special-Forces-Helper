using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class GlassCannonMod : Mod
	{
		public GlassCannonMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 10;

		public override string BizoName => "GlassCannon";

		public override string Name => "Glass Cannon";

		protected override void OnModLevelChanged(int diff)
		{
			base.OnModLevelChanged(diff);

			Loadout.Stats.UpdateDamageReduction("Core", -2 * diff);
			Loadout.Stats.UpdateHealthArmor("Core", -4 * diff);
			Loadout.Stats.UpdateShieldsArmor("Core", -4 * diff);

			Loadout.Stats.RefreshAllBindings();
		}
	}
}
