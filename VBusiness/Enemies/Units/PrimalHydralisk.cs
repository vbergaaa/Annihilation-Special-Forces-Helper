using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class PrimalHydralisk : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.PrimalHydralisk;

		public override double Attack => 30;

		public override double AttackSpeed => 0.8;

		public override double Health => 650;

		public override double HealthArmor => 15;

		public override double AttackIncrement => 7.5;

		public override double HealthIncrement => 75;

		public override double HealthArmorIncrement => 6;
	}
}
