using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class BuildingRecyclePerk : Perk
    {
		public BuildingRecyclePerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Gain 15% extra bounty from building per point";

        public override byte Page => 6;

        public override byte Position => 2;

        public override int StartingCost => 350;

        public override int IncrementCost => 150;

        protected override short MaxLevelCore => 10;

        protected override string PerkName => "Building Recycle";
    }
}
