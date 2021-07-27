using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class TierMod : Mod
	{
		public TierMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 15;

		public override string BizoName => "Tier";

		protected override void OnModLevelChanged(int diff)
		{
			base.OnModLevelChanged(diff);

			Loadout.Stats.RefreshPropertyBinding(nameof(Loadout.Stats.Damage));
			Loadout.Stats.RefreshPropertyBinding(nameof(Loadout.Stats.Toughness));
			Loadout.IncomeManager.RefreshPropertyBinding(nameof(Loadout.IncomeManager.KillsPerMinute));
			Loadout.IncomeManager.RefreshPropertyBinding(nameof(Loadout.IncomeManager.MineralsPerMinute));
		}
	}
}
