using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Hatchery : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.Hatchery;

		public override double Attack => 0;

		public override double AttackSpeed => 0;

		public override double Health => 625;

		public override double HealthArmor => 10;

		public override double AttackIncrement => 0;

		public override double HealthIncrement => 50;

		public override double HealthArmorIncrement => 2;
	}
}
