using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class MineralJackpot2Perk : Perk
    {
		public MineralJackpot2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Grants a 0.2% chance to gain 100 minerals on each kill";

        public override byte Page => 6;

        public override byte Position => 4;

        public override int StartingCost => 300;

        public override int IncrementCost => 70;

        protected override short MaxLevelCore => 20;

        protected override string PerkName => "Mineral Jackpot II";
    }
}
