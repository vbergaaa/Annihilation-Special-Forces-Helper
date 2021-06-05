using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class InfestedTerran : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.InfestedTerran;

		public override double Attack => 10;

		public override double AttackSpeed => 1.2;

		public override double Health => 50;

		public override double HealthArmor => 2;

		public override double AttackIncrement => 3;

		public override double HealthIncrement => 15;

		public override double HealthArmorIncrement => 1.5;

		public override int MineralBounty => 4;
	}
}
