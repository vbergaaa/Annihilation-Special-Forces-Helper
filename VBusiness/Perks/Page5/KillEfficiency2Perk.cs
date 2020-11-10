using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class KillEfficiency2Perk : Perk
    {
		public KillEfficiency2Perk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Grants a 3% chance to gain an extra kill upon killing an enemy unit";

        public override byte Page => 5;

        public override byte Position => 1;

        public override int StartingCost => 120;

        public override int IncrementCost => 60;

        protected override short MaxLevelCore => 20;

        protected override string PerkName => "Kill Efficiency II";
    }
}
