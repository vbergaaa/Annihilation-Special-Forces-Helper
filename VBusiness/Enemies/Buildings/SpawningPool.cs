using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class SpawningPool : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.SpawningPool;

		public override double Attack => 0;

		public override double AttackSpeed => 0;

		public override double Health => 600;

		public override double HealthArmor => 8;

		public override double AttackIncrement => 0;

		public override double HealthIncrement => 40;

		public override double HealthArmorIncrement => 3.5;

		protected override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.Zergling, 20) };
	}
}
