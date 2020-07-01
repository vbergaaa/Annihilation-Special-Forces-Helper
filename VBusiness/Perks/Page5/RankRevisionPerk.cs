namespace VBusiness.Perks
{
    public class RankRevisionPerk : Perk
    {
        public override string Description => "Increases chance of successfully ranking up by 5% of the current chance";

        public override byte Page => 5;

        public override byte Position => 6;

        public override int StartingCost => 1000;

        public override int IncrementCost => 500;

        public override short MaxLevel => 5;

        protected override string name => "Rank Revision";
    }
}
