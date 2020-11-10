using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class ExtraSupplyPerk : Perk
    {
		public ExtraSupplyPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Increases supply limit by 1";

        public override byte Page => 3;

        public override byte Position => 4;

        public override int StartingCost => 200;

        public override int IncrementCost => 50;

        protected override short MaxLevelCore => 10;

        protected override string PerkName => "Extra Supply";
    }
}
