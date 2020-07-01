namespace VBusiness.Perks
{
    public class ExtraSupplyPerk : Perk
    {
        public override string Description => "Increases supply limit by 1";

        public override byte Page => 3;

        public override byte Position => 4;

        public override int StartingCost => 200;

        public override int IncrementCost => 50;

        public override short MaxLevel => 10;

        protected override string name => "Extra Supply";
    }
}
