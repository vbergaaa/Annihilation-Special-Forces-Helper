namespace VBusiness.Perks
{
    public class AutomaticRefinery2Perk : Perk
    {
        public override string Description => "Create a mineral field every 10 minutes near the well (subsequent upgrades reduce time in between by 20 seconds)";

        public override byte Page => 10;

        public override byte Position => 6;

        public override int StartingCost => 4000;

        public override int IncrementCost => 1000;

        public override short MaxLevel => 10;

        protected override string name => "Automatic Refinery II";
    }
}
