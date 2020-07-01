namespace VBusiness.Perks
{
    public class CriticalDamagePerk : Perk
    {
        public override string Description => "Gain 1% Critical Damage";

        public override byte Page => 4;

        public override byte Position => 2;

        public override int StartingCost => 60;

        public override int IncrementCost => 20;

        public override short MaxLevel => 15;

        protected override string name => "Critical Damage";
    }
}
