using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class SergeantRamone : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.SergeantRamone;

		public override double Attack => 60;

		public override double AttackSpeed => 1;

		public override double Health => 4000;

		public override double HealthArmor => 20;

		public override double AttackIncrement => 0; // Can't see boss upgrades..

		public override double HealthIncrement => 0;

		public override double HealthArmorIncrement => 0;

		public override int MineralBounty => 10000;

		protected override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.Queen, 4) };
	}
}
