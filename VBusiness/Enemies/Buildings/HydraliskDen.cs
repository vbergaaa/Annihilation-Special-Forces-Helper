using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class HydraliskDen : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.HydraliskDen;

		public override double Attack => 0;

		public override double AttackSpeed => 0;

		public override double Health => 1000;

		public override double HealthArmor => 20;

		public override double AttackIncrement => 0;

		public override double HealthIncrement => 70;

		public override double HealthArmorIncrement => 5.5;

		public override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.Hydralisk, 20) };
	}
}
