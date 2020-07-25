namespace VBusiness.Perks
{
	public class RedCritsPerk : Perk
	{
		public override string Description => "Your critical hits have a 50% chance to deal double damage";

		public override byte Page => 8;

		public override byte Position => 6;

		public override int StartingCost => 25000;

		public override int IncrementCost => 0;

		public override short MaxLevel => 1;

		protected override string name => "Red Crits";

		protected override System.Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference)
		{
			return (stats) => { stats.HasRedCrits = levelDifference > 0 ? true : false; };
		}
	}
}
