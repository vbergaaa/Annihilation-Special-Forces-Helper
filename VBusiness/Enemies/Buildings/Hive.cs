using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Hive : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.Hive;

		public override double Attack => 0;

		public override double AttackSpeed => 0;

		public override double Health => 3000; // this is a guess

		public override double HealthArmor => 40;

		public override double AttackIncrement => 0;

		public override double HealthIncrement => 150;

		public override double HealthArmorIncrement => 5;

		public override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.EmpressQueen, 2) };
	}
}
