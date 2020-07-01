using VModel;

namespace VBusiness.Perks
{
	public class SuperJackpotPerk : Perk
	{
		public override string Description => "Increase mineral jackpot reward by 10 minerals and 1 kill";

		public override byte Page => 10;

		public override byte Position => 4;

		public override int StartingCost => 2000;

		public override int IncrementCost => 250;

		public override short MaxLevel => 10;

		protected override string name => "Super Jackpot";
	}
}
