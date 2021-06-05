using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class SporeCannon : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.SporeCannon;

		public override double Attack => 35;

		public override double AttackSpeed => 1.2; // might be wrong

		public override double Health => 750;

		public override double HealthArmor => 10;

		public override double AttackIncrement => 7;

		public override double HealthIncrement => 50;

		public override double HealthArmorIncrement => 5;

		public override int MineralBounty => 1200;
		public override int KillBounty => 100;

		protected override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.Hydralisk, 10) };
	}
}
