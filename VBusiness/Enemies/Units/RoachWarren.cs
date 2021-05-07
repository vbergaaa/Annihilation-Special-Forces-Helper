using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class RoachWarren : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.RoachWarren;

		public override double Attack => 0;

		public override double AttackSpeed => 0;

		public override double Health => 800; // Extrapolated guess

		public override double HealthArmor => 15;

		public override double AttackIncrement => 0;

		public override double HealthIncrement => 60;

		public override double HealthArmorIncrement => 5;

		protected override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.Roach, 20) };
	}
}
