using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class MonarchQueen : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.MonarchQueen;

		public override double Attack => 70;

		public override double AttackSpeed => 0.35;

		public override double Health => 5500;

		public override double HealthArmor => 65;

		public override double AttackIncrement => 11;

		public override double HealthIncrement => 300;

		public override double HealthArmorIncrement => 8;

		public override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.EmpressQueen, 4) };
	}
}
