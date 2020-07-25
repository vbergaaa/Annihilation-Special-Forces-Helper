namespace VBusiness.Perks
{
	public class SuperRushPerk : Perk
	{
		public override string Description => "Increases Adrenaline Rush bonus by 10%";

		public override byte Page => 11;

		public override byte Position => 4;

		public override int StartingCost => 2000;

		public override int IncrementCost => 300;

		public override short MaxLevel => 10;

		protected override string name => "Super Rush";

		protected override System.Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference)
		{
			return (stats) => {
				stats.Attack += 1 * levelDifference;
				stats.AttackSpeed += 1 * levelDifference;
				stats.CriticalChance += 0.5 * levelDifference;
			};
		}
	}
}
