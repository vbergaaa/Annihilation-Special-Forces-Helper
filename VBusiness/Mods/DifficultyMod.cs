using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class DifficultyMod : Mod
	{
		public DifficultyMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 0;

		public override string BizoName => "Difficulty";

		protected override void OnModLevelChanged(int diff)
		{
			base.OnModLevelChanged(diff);

			Loadout.Stats.RefreshPropertyBinding(nameof(Loadout.Stats.Damage));
			Loadout.Stats.RefreshPropertyBinding(nameof(Loadout.Stats.Toughness));

			// why is these methods in unit config? TODO: move them
			((UnitConfiguration)Loadout.UnitConfiguration).UpdateTormentReduction(Loadout.UnitConfiguration.Difficulty.TormentReduction * 0.1 * diff);
			((UnitConfiguration)Loadout.UnitConfiguration).UpdateCritReduction(Loadout.UnitConfiguration.Difficulty.CritReduction * 0.1 * diff);
		}
	}
}
