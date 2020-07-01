namespace VBusiness.Perks
{
    public class BalancedTrainingPerk : Perk
    {
        public override string Description => "Increase damage, attack speed, vitals, vital armor by 2%";

        public override byte Page => 8;

        public override byte Position => 3;

        public override int StartingCost => 1000;

        public override int IncrementCost => 200;

        public override short MaxLevel => 10;

        protected override string name => "Balanced Training";
    }
}
