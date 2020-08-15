using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class AlacrityPerk : Perk
    {
		public AlacrityPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Accelerate units by 1%";

        public override byte Page => 8;

        public override byte Position => 5;

        public override int StartingCost => 2000;

        public override int IncrementCost => 250;

        public override short MaxLevel => 10;

        protected override string PerkName => "Alacrity";
    }
}
