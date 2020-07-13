
using VEntityFramework;

namespace VBusiness.Perks
{
    public class AttackSpeedPerk : Perk
    {
        protected override string name => "Attack Speed";

        public override string Description => "Increase Attack Speed of all your units by 2%";

        public override byte Page => 1;

        public override byte Position => 2;

        public override int StartingCost => 15;

        public override int IncrementCost => 13;

        public override short MaxLevel => 10;
    }
}
