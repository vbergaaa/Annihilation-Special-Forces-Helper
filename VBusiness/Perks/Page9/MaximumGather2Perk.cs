using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class MaximumGather2Perk : Perk
    {
		public MaximumGather2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Gain 5% chance to gain a Kill Resource whenever a unit with max kills obtains a kill";

        public override byte Page => 9;

        public override byte Position => 4;

        public override int StartingCost => 2000;

        public override int IncrementCost => 500;

        protected override short MaxLevelCore => 10;

        protected override string PerkName => "Maximum Gather II";
    }
}
