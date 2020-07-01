namespace VBusiness.Perks
{
    public class StartingMineralsPerk : Perk
    {
        public override string Description => "Gain 1000 Minerals";

        public override byte Page => 3;

        public override byte Position => 2;

        public override int StartingCost => 40;

        public override int IncrementCost => 10;

        public override short MaxLevel => 20;

        protected override string name => "Starting Minerals";
    }
}
