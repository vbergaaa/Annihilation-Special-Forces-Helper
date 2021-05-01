using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Pygalisk : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.Pygalisk;

		public override double Attack => 27;

		public override double AttackSpeed => 0.7;

		public override double Health => 700;

		public override double HealthArmor => 20;

		public override double AttackIncrement => 6.5;

		public override double HealthIncrement => 100;

		public override double HealthArmorIncrement => 5;
	}
}
