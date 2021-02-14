using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class MineralJackpot3Perk : Perk
	{
		public MineralJackpot3Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Grants a 0.2% chance to gain 100 minerals on each kill";

		public override byte Page => 10;

		public override byte Position => 5;

		public override int StartingCost => 1000;

		public override int IncrementCost => 100;

		protected override short MaxLevelCore => 30;

		protected override string PerkName => "Mineral Jackpot III";
	}
}
