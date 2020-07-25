namespace VBusiness.Perks
{
	public class BalancedTrainingPerk : Perk
	{
		public override string Description => "Increase damage, attack speed, vitals, vital armor by 1%";

		public override byte Page => 8;

		public override byte Position => 3;

		public override int StartingCost => 1000;

		public override int IncrementCost => 200;

		public override short MaxLevel => 10;

		protected override string name => "Balanced Training";

		protected override System.Action<VEntityFramework.Model.VStats> GetStatsModifier(int levelDifference)
		{
			return (stats) => {
				stats.Attack += 1 * levelDifference;
				stats.AttackSpeed += 1 * levelDifference;
				stats.Health += 1 * levelDifference;
				stats.HealthArmor += 1 * levelDifference;
				stats.Shields += 1 * levelDifference;
				stats.ShieldsArmor += 1 * levelDifference;
			};
		}
	}
}
