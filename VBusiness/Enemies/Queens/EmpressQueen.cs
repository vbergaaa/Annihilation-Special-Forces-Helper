using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class EmpressQueen : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.EmpressQueen;

		public override double Attack => 50;

		public override double AttackSpeed => 0.4;

		public override double Health => 4000;

		public override double HealthArmor => 50;

		public override double AttackIncrement => 8;

		public override double HealthIncrement => 200;

		public override double HealthArmorIncrement => 6;

		public override int MineralBounty => 3000;

		protected override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.GreatQueen, 4) };
	}
}
