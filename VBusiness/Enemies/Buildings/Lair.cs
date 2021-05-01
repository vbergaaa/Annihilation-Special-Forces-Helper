using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Lair : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.Lair;

		public override double Attack => 0;

		public override double AttackSpeed => 0;

		public override double Health => 1500;

		public override double HealthArmor => 25;

		public override double AttackIncrement => 0;

		public override double HealthIncrement => 100;

		public override double HealthArmorIncrement => 3.5;
	}
}
