using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Infestor : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.Infestor;

		public override double Attack => 36;

		public override double AttackSpeed => 2;

		public override double Health => 400;

		public override double HealthArmor => 15;

		public override double AttackIncrement => 5;

		public override double HealthIncrement => 50;

		public override double HealthArmorIncrement => 5;

		public override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.Hydralisk, 5) };
	}
}
