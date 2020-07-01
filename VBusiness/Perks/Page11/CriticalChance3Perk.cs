namespace VBusiness.Perks
{
    public class CriticalChance3Perk : Perk
    {
        public override string Description => "Grants 1% chance to critical hit with any attack";

        public override byte Page => 11;

        public override byte Position => 1;

        public override int StartingCost => 1000;

        public override int IncrementCost => 200;

        public override short MaxLevel => 30;

        protected override string name => "Critical Chance III";
    }
}
