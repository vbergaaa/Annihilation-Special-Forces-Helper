namespace VBusiness.Perks
{
	public class FastLearnerPerk : Perk
	{
		public override string Description => "Grants all players a 1% chance to gain an extra RP when a spawner dies";

		public override byte Page => 7;

		public override byte Position => 6;

		public override int StartingCost => 1000;

		public override int IncrementCost => 750;

		public override short MaxLevel => 25;

		protected override string name => "Fast Learner";
	}
}
