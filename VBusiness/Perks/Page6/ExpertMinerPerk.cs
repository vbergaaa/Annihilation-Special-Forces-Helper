using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class ExpertMinerPerk : Perk
    {
		public ExpertMinerPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Gain 1 mining speed and 1 mining amount upgrade";

        public override byte Page => 6;

        public override byte Position => 3;

        public override int StartingCost => 300;

        public override int IncrementCost => 75;

        protected override short MaxLevelCore => 10;

        protected override string PerkName => "Expert Miner";
    }
}
