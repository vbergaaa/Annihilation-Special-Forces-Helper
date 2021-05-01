using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class GiantAbberation : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.GiantAbberation;

		public override double Attack => 20;

		public override double AttackSpeed => 2;

		public override double Health => 250;

		public override double HealthArmor => 10;

		public override double AttackIncrement => 4;

		public override double HealthIncrement => 30;

		public override double HealthArmorIncrement => 3.5;
	}
}
