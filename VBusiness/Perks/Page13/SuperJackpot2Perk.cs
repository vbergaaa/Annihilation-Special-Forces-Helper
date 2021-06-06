using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class SuperJackpot2Perk : Perk
	{
		public SuperJackpot2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increase Mineral Jackpot Reward by +10 Minerals and +1 Kill Resource";

		public override byte Page => 13;

		public override byte Position => 3;

		public override int StartingCost => 6000;

		public override int IncrementCost => 2000;

		protected override string PerkName => "Super Jackpot II";

		protected override short MaxLevelCore => 20;

		protected override void OnLevelChanged(int difference)
		{
			base.OnLevelChanged(difference);

			PerkCollection.Loadout.IncomeManager.SuperJackpot += difference;
		}
	}
}
