using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class FastLearnerPerk : Perk
	{
		public FastLearnerPerk(VPerkCollection collection) : base(collection)
		{
		}

		public override string Description => "Grants all players a 1% chance to gain an extra Rank Point when a spawner dies";

		public override byte Page => 7;

		public override byte Position => 6;

		public override int StartingCost => 1000;

		public override int IncrementCost => 750;

		protected override short MaxLevelCore => 25;

		protected override string PerkName => "Fast Learner";
	}
}
