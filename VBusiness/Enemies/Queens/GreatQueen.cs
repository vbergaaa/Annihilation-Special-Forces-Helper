using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class GreatQueen : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.GreatQueen;

		public override double Attack => 30;

		public override double AttackSpeed => 0.45;

		public override double Health => 2000;

		public override double HealthArmor => 30;

		public override double AttackIncrement => 6;

		public override double HealthIncrement => 100;

		public override double HealthArmorIncrement => 4;
	}
}
