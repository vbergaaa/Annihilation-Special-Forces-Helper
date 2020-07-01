namespace VBusiness.Perks
{
    public class CriticalChancePerk : Perk
    {
        public override string Description => "Grants a 1% chance to critically hit with any attack";

        public override byte Page => 4;

        public override byte Position => 1;

        public override int StartingCost => 80;

        public override int IncrementCost => 20;

        public override short MaxLevel => 10;

        protected override string name => "Critical Chance";
	}
}
