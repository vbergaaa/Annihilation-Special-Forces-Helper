using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Spire : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.Spire;

		public override double Attack => 0;

		public override double AttackSpeed => 0;

		public override double Health => 1500;

		public override double HealthArmor => 25;

		public override double AttackIncrement => 0;

		public override double HealthIncrement => 6;

		public override double HealthArmorIncrement => 70;
	}
}
