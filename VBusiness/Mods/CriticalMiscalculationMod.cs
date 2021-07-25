using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class CriticalMiscalculationMod : Mod
	{
		public CriticalMiscalculationMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 12;

		public override string BizoName => "CriticalMiscalculation";

		public override string Name => "Crit. Miscalculation";

		protected override void OnModLevelChanged(int diff)
		{
			base.OnModLevelChanged(diff);

			Loadout.Stats.CriticalChance -= 5 * diff;
			Loadout.Stats.CriticalDamage -= 10 * diff;

			Loadout.Stats.RefreshAllBindings();
		}
	}
}
