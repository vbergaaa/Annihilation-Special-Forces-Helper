namespace VBusiness.Perks
{
    public class MineralJackpotPerk : Perk
    {
        public override string Description => "Gain a 0.2% chance to gain 100 minerals on each kill";

        public override byte Page => 3;

        public override byte Position => 5;

        public override int StartingCost => 150;

        public override int IncrementCost => 30;

        public override short MaxLevel => 10;

        protected override string name => "Mineral Jackpot";
    }
}
