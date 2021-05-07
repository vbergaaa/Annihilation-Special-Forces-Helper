using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class SwarmHost : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.SwarmHost;

		public override double Attack => 60;

		public override double AttackSpeed => 2;

		public override double Health => 800;

		public override double HealthArmor => 25;

		public override double AttackIncrement => 5.5;

		public override double HealthIncrement => 75;

		public override double HealthArmorIncrement => 6.5;

		protected override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.Pygalisk, 10) }; // This was with tier up, but I'm pretty sure tier up shouldn't affect this
	}
}
