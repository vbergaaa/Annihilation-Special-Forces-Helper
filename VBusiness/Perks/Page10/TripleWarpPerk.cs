namespace VBusiness.Perks
{
    public class TripleWarpPerk : Perk
    {
        public override string Description => "Grants a 1% chance to warp in 2 duplicates when buying units";

        public override byte Page => 10;

        public override byte Position => 2;

        public override int StartingCost => 1500;

        public override int IncrementCost => 150;

        public override short MaxLevel => 10;

        protected override string name => "Triple Warp";
    }
}
