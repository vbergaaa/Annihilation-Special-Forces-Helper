using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Hatchery : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.Hatchery;

		public override double Attack => 0;

		public override double AttackSpeed => 0;

		public override double Health => 700;

		public override double HealthArmor => 13;

		public override double AttackIncrement => 0;

		public override double HealthIncrement => 50;

		public override double HealthArmorIncrement => 2;

		protected override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.Queen, 2) };
	}
}
