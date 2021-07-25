using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class RankReversionMod : Mod
	{
		public RankReversionMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 10;

		public override string BizoName => "RankReversion";

		public override string Name => "Rank Reversion";

		protected override void OnModLevelChanged(int diff)
		{
			base.OnModLevelChanged(diff);

			Loadout.IncomeManager.RankRevision -= 5 * diff;
			Loadout.IncomeManager.RefreshPropertyBinding(nameof(Loadout.IncomeManager.UnitKillCost));
			Loadout.IncomeManager.RefreshPropertyBinding(nameof(Loadout.IncomeManager.LoadoutKillCost));
		}
	}
}
