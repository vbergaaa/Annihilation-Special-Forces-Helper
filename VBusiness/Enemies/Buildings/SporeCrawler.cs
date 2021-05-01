using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class SporeCrawler : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.SporeCrawler;

		public override double Attack => 22;

		public override double AttackSpeed => 1; // might be wrong

		public override double Health => 500;

		public override double HealthArmor => 10;

		public override double AttackIncrement => 4;

		public override double HealthIncrement => 35;

		public override double HealthArmorIncrement => 3.5;
	}
}
