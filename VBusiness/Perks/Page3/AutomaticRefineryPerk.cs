using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class AutomaticRefineryPerk : Perk
    {
		public AutomaticRefineryPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Create a mineral field every 10 minutes near the well (subsequent upgrades reduce time in between by 1 minute)";

        public override byte Page => 3;

        public override byte Position => 6;

        public override int StartingCost => 400;

        public override int IncrementCost => 100;

        public override short MaxLevel => 6;

        protected override string PerkName => "Automatic Refinery";
    }
}
