using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class TaxesMod : Mod
	{
		public TaxesMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 10;

		public override string BizoName => "Taxes";

		protected override void OnModLevelChanged(int diff)
		{
			Loadout.RefreshPropertyBinding(nameof(Loadout.RemainingPerkPoints));
			Loadout.Perks.RefreshPropertyBinding(nameof(Loadout.Perks.RemainingCost));
		}
	}
}
