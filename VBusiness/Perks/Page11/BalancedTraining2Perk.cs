namespace VBusiness.Perks
{
	public class BalancedTraining2Perk : Perk
	{
		public override string Description => "Increase damage, attack speed, vitals, vital armor by 1%";

		public override byte Page => 11;

		public override byte Position => 3;

		public override int StartingCost => 2500;

		public override int IncrementCost => 500;

		public override short MaxLevel => 20;

		protected override string name => "Balanced Training II";

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
