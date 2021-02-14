using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class ExpertMinerPerk : Perk
    {
		public ExpertMinerPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "+1 Mining Speed\r\n+1 Mining Amount";

        public override byte Page => 6;

        public override byte Position => 3;

        public override int StartingCost => 300;

        public override int IncrementCost => 75;

        protected override short MaxLevelCore => 10;

        protected override string PerkName => "Expert Miner";
    }
}
