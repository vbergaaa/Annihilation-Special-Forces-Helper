using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class StartingMineralsPerk : Perk
    {
		public StartingMineralsPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Gain 1000 Minerals";

        public override byte Page => 3;

        public override byte Position => 2;

        public override int StartingCost => 40;

        public override int IncrementCost => 10;

        protected override short MaxLevelCore => 20;

        protected override string PerkName => "Starting Minerals";
    }
}
