using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class CriticalCollectionPerk : Perk
    {
		public CriticalCollectionPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Gain a 1% chance to gain 2 kill resource when probes return to your nexus";

        public override byte Page => 6;

        public override byte Position => 5;

        public override int StartingCost => 300;

        public override int IncrementCost => 60;

        public override short MaxLevel => 20;

        protected override string PerkName => "Critical Harvest";
    }
}
