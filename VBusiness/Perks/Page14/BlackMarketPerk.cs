using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class BlackMarketPerk : Perk
	{
		public BlackMarketPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Allows buying of dna1 units by holding shift with greatly increased cost";

		public override byte Page => 14;

		public override byte Position => 6;

		public override int StartingCost => 300000;

		public override int IncrementCost => 0;

		protected override string PerkName => "Black Market";

		protected override short MaxLevelCore => 1;

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);
			PerkCollection.Loadout.IncomeManager.RefreshPropertyBinding(nameof(PerkCollection.Loadout.IncomeManager.UnitKillCost));
			PerkCollection.Loadout.IncomeManager.RefreshPropertyBinding(nameof(PerkCollection.Loadout.IncomeManager.UnitMineralCost));
		}
	}
}
