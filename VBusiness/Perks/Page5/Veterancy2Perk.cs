namespace VBusiness.Perks

{
    public class Veterancy2Perk : Perk
    {
        public override string Description => "Units start with 10 kills";

        public override byte Page => 5;

        public override byte Position => 5;

        public override int StartingCost => 250;

        public override int IncrementCost => 75;

        public override short MaxLevel => 10;

        protected override string name => "Veterancy II";
    }
}
