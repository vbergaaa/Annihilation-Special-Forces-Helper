namespace VBusiness.Perks
{
    public class BaseDoubleWarpPerk : Perk
    {
        public override string Description => "Grants a 1% chance to warp in duplicates when buying units";

        public override byte Page => 3;

        public override byte Position => 1;

        public override int StartingCost => 70;

        public override int IncrementCost => 30;

        public override short MaxLevel => 10;

        protected override string name => "Double Warp";
    }
}
