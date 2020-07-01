namespace VBusiness.Perks
{
    public class MasterTrainerPerk : Perk
    {
        public override string Description => "Gain 200 kills";

        public override byte Page => 3;

        public override byte Position => 3;

        public override int StartingCost => 60;

        public override int IncrementCost => 20;

        public override short MaxLevel => 10;

        protected override string name => "Master Trainer";
    }
}
