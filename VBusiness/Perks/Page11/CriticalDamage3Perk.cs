namespace VBusiness.Perks
{
	public class CriticalDamage3Perk : Perk
	{
		public override string Description => "Gain 1% critical damage";

		public override byte Page => 11;

		public override byte Position => 2;

		public override int StartingCost => 750;

		public override int IncrementCost => 160;

		public override short MaxLevel => 45;

		protected override string name => "Critical Damage III";

		protected override System.Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference)
		{
			return (stats) => { stats.CriticalDamage += 1 * levelDifference; };
		}
	}
}
