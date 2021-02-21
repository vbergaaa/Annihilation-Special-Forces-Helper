using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class AutomaticRefinery2Perk : Perk
    {
		public AutomaticRefinery2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Reduce Auto Refinery cooldown by 20 seconds";

        public override byte Page => 10;

        public override byte Position => 6;

        public override int StartingCost => 4000;

        public override int IncrementCost => 1000;

        protected override short MaxLevelCore => 10;

        protected override string PerkName => "Automatic Refinery II";
    }
}
