namespace VBusiness.Perks
{
	public class DamageReductionPerk : Perk
	{
		public override string Description => "Reduce damage taken by your units by 1% (additive with itself)";

		public override byte Page => 4;

		public override byte Position => 6;

		public override int StartingCost => 150;

		public override int IncrementCost => 50;

		public override short MaxLevel => 10;

		protected override string name => "Damage Reduction";

		protected override System.Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference)
		{
			return (stats) => { stats.DamageReduction += 1 * levelDifference; };
		}
	}
}
