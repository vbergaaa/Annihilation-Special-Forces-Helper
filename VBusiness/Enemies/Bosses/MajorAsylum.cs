using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class MajorAsylum : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.MajorAsylum;

		public override double Attack => 500;

		public override double AttackSpeed => 0.6;

		public override double Health => 30000;

		public override double HealthArmor => 200;

		public override double AttackIncrement => 0;

		public override double HealthIncrement => 0;

		public override double HealthArmorIncrement => 0;

		protected override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.EmpressQueen, 20) };
	}
}
