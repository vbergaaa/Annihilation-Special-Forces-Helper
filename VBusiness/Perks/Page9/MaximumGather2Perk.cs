namespace VBusiness.Perks
{
    public class MaximumGather2Perk : Perk
    {
        public override string Description => "Gain 5% chance to gain a Kill Resource whenever a unit with max kills obtains a kill";

        public override byte Page => 9;

        public override byte Position => 4;

        public override int StartingCost => 2000;

        public override int IncrementCost => 500;

        public override short MaxLevel => 10;

        protected override string name => "Maximum Gather II";
    }
}
