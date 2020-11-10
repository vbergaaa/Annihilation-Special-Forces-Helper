using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class CriticalDamage2Perk : Perk
    {
		public CriticalDamage2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Gain 1% critical damage";

        public override byte Page => 8;

        public override byte Position => 2;

        public override int StartingCost => 500;

        public override int IncrementCost => 80;

        protected override short MaxLevelCore => 30;

        protected override string PerkName => "Critical Damage II";

        protected override void OnLevelChanged(int difference)
        {
            PerkCollection.Loadout.Stats.CriticalDamage += 1 * difference;
        }
    }
}
