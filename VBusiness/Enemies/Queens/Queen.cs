using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Queen : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.Queen;

		public override double Attack => 20;

		public override double AttackSpeed => 0.5;

		public override double Health => 1000;

		public override double HealthArmor => 15;

		public override double AttackIncrement => 5;

		public override double HealthIncrement => 70;

		public override double HealthArmorIncrement => 2.5;
	}
}
