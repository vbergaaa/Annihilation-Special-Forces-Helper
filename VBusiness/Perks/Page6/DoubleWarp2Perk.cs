using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class DoubleWarp2Perk : Perk
    {
		public DoubleWarp2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Grants a 1% chance to warp in duplicates when buying units";

        public override byte Page => 6;

        public override byte Position => 1;

        public override int StartingCost => 200;

        public override int IncrementCost => 70;

        public override short MaxLevel => 20;

        protected override string PerkName => "Double Warp II";
    }
}
