using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Queen : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.Queen;

		public override double Attack => 25;

		public override double AttackSpeed => 0.5;

		public override double Health => 1125;

		public override double HealthArmor => 20;

		public override double AttackIncrement => 5;

		public override double HealthIncrement => 70;

		public override double HealthArmorIncrement => 2.5;

		protected override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.Abberation, 4) };
	}
}
