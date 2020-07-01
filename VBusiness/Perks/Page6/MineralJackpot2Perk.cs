namespace VBusiness.Perks
{
    public class MineralJackpot2Perk : Perk
    {
        public override string Description => "Gain a 0.2% chance to gain 100 minerals on each kill";

        public override byte Page => 6;

        public override byte Position => 4;

        public override int StartingCost => 300;

        public override int IncrementCost => 70;

        public override short MaxLevel => 20;

        protected override string name => "Mineral Jackpot II";
    }
}
