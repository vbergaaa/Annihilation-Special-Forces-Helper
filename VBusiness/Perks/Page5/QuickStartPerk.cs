using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class QuickStartPerk : Perk
    {
		public QuickStartPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "The first unit that you buy will obtain +3 instantly (additional points also gives it to extra units";

        public override byte Page => 5;

        public override byte Position => 2;

        public override int StartingCost => 3000;

        public override int IncrementCost => 3000;

        protected override short MaxLevelCore => 3;

        protected override string PerkName => "Quick Start";
    }
}
