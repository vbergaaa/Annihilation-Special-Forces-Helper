using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class AutomaticRefineryPerk : Perk
    {
		public AutomaticRefineryPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Create a mineral field every (11 - L) minutes";

        public override byte Page => 3;

        public override byte Position => 6;

        public override int StartingCost => 400;

        public override int IncrementCost => 100;

        protected override short MaxLevelCore => 6;

        protected override string PerkName => "Automatic Refinery";
    }
}
