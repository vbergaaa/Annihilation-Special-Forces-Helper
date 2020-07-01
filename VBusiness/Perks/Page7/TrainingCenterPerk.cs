namespace VBusiness.Perks
{
    public class TrainingCenterPerk : Perk
    {
        public override string Description => "After 1h game time, if you have (11 - L) or more units with +5 you will generate 4 kills per second, and 4 extra kills per second for every other unit with +5, capping at 11 units";

        public override byte Page => 7;

        public override byte Position => 3;

        public override int StartingCost => 5000;

        public override int IncrementCost => 1000;

        public override short MaxLevel => 6;

        protected override string name => "Training Centre";
    }
}
