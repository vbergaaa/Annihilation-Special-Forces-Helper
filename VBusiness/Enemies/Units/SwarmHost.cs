using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class SwarmHost : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.SwarmHost;

		public override double Attack => 60;

		public override double AttackSpeed => 2;

		public override double Health => 800;

		public override double HealthArmor => 25;

		public override double AttackIncrement => 5.5;

		public override double HealthIncrement => 75;

		public override double HealthArmorIncrement => 6.5;
	}
}
