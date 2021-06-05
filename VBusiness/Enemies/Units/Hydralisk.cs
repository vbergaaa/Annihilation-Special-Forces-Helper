using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Hydralisk : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.Hydralisk;

		public override double Attack => 22;

		public override double AttackSpeed => 0.83;

		public override double Health => 500;

		public override double HealthArmor => 12;

		public override double AttackIncrement => 5.5;

		public override double HealthIncrement => 45;

		public override double HealthArmorIncrement => 4;

		public override int MineralBounty => 10;
		public override int KillBounty => 1;
	}
}
