namespace VBusiness.Perks
{
    public class CriticalDamage2Perk : Perk
    {
        public override string Description => "Gain 1% critical damage";

        public override byte Page => 8;

        public override byte Position => 2;

        public override int StartingCost => 500;

        public override int IncrementCost => 80;

        public override short MaxLevel => 30;

        protected override string name => "Critical Damage II";

        protected override System.Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference)
        {
            return (stats) => { stats.CriticalDamage += 1 * levelDifference; };
        }
    }
}
