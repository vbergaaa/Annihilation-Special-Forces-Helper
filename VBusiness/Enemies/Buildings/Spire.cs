using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Spire : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.Spire;

		public override double Attack => 0;

		public override double AttackSpeed => 0;

		public override double Health => 1500;

		public override double HealthArmor => 25;

		public override double AttackIncrement => 0;

		public override double HealthIncrement => 70;

		public override double HealthArmorIncrement => 6;

		protected override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.GiantAbberation, 10) };
	}
}
