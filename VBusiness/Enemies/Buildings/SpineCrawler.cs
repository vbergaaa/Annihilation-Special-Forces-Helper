using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class SpineCrawler : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.SpineCrawler;

		public override double Attack => 15;

		public override double AttackSpeed => 1;

		public override double Health => 200;

		public override double HealthArmor => 4;

		public override double AttackIncrement => 4.5;

		public override double HealthIncrement => 20;

		public override double HealthArmorIncrement => 2;
	}
}
