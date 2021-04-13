using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Zergling : VEnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.Zergling;

		public override double Attack => 12;

		public override double AttackSpeed => 0.7;

		public override double Health => 50;

		public override double HealthArmor => 5;

		public override double AttackIncrement => 4;

		public override double HealthIncrement => 20;

		public override double HealthArmorIncrement => 2;
	}
}
