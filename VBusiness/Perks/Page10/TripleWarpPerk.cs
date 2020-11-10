using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class TripleWarpPerk : Perk
    {
		public TripleWarpPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Grants a 1% chance to warp in 2 duplicates when buying units";

        public override byte Page => 10;

        public override byte Position => 2;

        public override int StartingCost => 1500;

        public override int IncrementCost => 150;

        protected override short MaxLevelCore => 10;

        protected override string PerkName => "Triple Warp";
    }
}
