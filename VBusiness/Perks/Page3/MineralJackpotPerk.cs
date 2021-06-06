using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class MineralJackpotPerk : Perk
	{
		public MineralJackpotPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Grants a 0.2% chance to gain 100 minerals on each kill";

		public override byte Page => 3;

		public override byte Position => 5;

		public override int StartingCost => 150;

		public override int IncrementCost => 30;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Mineral Jackpot";

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);

			PerkCollection.Loadout.IncomeManager.MineralJackpot += difference;
		}
	}
}
