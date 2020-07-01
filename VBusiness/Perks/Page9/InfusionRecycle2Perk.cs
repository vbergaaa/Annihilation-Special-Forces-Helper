namespace VBusiness.Perks
{
    public class InfusionRecycle2Perk : Perk
    {
        public override string Description => "Infusing a unit stores 5 kills";

        public override byte Page => 9;

        public override byte Position => 2;

        public override int StartingCost => 500;

        public override int IncrementCost => 125;

        public override short MaxLevel => 10;

        protected override string name => "Infusion Recycle II";
    }
}
