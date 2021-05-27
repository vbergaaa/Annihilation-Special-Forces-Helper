using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class QuickStartPerk : Perk
	{
		public QuickStartPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Gives 3 infusion levels to your next warp in";

		public override byte Page => 5;

		public override byte Position => 2;

		public override int StartingCost => 3000;

		public override int IncrementCost => 3000;

		protected override short MaxLevelCore => 3;

		protected override string PerkName => "Quick Start";

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);
			PerkCollection.Loadout.IncomeManager.RefreshPropertyBinding(nameof(PerkCollection.Loadout.IncomeManager.LoadoutKillCost));
			PerkCollection.Loadout.IncomeManager.RefreshPropertyBinding(nameof(PerkCollection.Loadout.IncomeManager.LoadoutMineralCost));
		}
	}
}
