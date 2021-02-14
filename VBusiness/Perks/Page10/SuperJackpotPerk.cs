using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class SuperJackpotPerk : Perk
	{
		public SuperJackpotPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increase Mineral Jackpot reward by +10 Minerals and +1 Kill Resource";

		public override byte Page => 10;

		public override byte Position => 4;

		public override int StartingCost => 2000;

		public override int IncrementCost => 250;

		protected override short MaxLevelCore => 10;

		protected override string PerkName => "Super Jackpot";
	}
}
