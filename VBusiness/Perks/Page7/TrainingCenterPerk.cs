using VEntityFramework.Model;

namespace VBusiness.Perks
{
    public class TrainingCenterPerk : Perk
    {
		public TrainingCenterPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "After 1h game time, if you have (11 - L) or more units with +5 you will generate 4 kills per second, and 4 extra kills per second for every other unit with +5, capping at 11 units";

        public override byte Page => 7;

        public override byte Position => 3;

        public override int StartingCost => 5000;

        public override int IncrementCost => 1000;

        protected override short MaxLevelCore => 6;

        protected override string PerkName => "Training Centre";
    }
}
