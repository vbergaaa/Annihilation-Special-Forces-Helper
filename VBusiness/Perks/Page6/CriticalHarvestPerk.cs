using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class CriticalHarvestPerk : Perk
    {
		public CriticalHarvestPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Gain 1% chance to gain double minerals when probes return to your nexus";

        public override byte Page => 6;

        public override byte Position => 6;

        public override int StartingCost => 200;

        public override int IncrementCost => 60;

        public override short MaxLevel => 20;

        protected override string PerkName => "Critical Harvest";
    }
}
