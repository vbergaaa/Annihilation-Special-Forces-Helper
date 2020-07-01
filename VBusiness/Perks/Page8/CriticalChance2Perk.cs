namespace VBusiness.Perks
{
    public class CriticalChance2Perk : Perk
    {
        public override string Description => "Grants 1% chance to critical hit with any attack";

        public override byte Page => 8;

        public override byte Position => 1;

        public override int StartingCost => 600;

        public override int IncrementCost => 100;

        public override short MaxLevel => 20;

        protected override string name => "Critical Chance II";
    }
}
