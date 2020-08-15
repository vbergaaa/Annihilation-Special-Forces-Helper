using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class MiningExpertisePerk : Perk
    {
		public MiningExpertisePerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Probes gain one kill every time they mine";

        public override byte Page => 7;

        public override byte Position => 2;

        public override int StartingCost => 5000;

        public override int IncrementCost => 1500;

        public override short MaxLevel => 4;

        protected override string PerkName => "Mining Expertise";
    }
}
