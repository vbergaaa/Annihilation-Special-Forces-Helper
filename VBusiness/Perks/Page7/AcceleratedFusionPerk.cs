using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class AcceleratedFusionPerk : Perk
    {
		public AcceleratedFusionPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Reduce infusion and evolution time by 5%";

        public override byte Page => 7;

        public override byte Position => 4;

        public override int StartingCost => 500;

        public override int IncrementCost => 200;

        protected override short MaxLevelCore => 15;

        protected override string PerkName => "Accelerated Fusion";
    }
}
