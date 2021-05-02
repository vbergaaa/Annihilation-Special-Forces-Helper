using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class LieutenantRailgul : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.LieutenantRailgul;

		public override double Attack => 200;

		public override double AttackSpeed => 1.3;

		public override double Health => 10000;

		public override double HealthArmor => 100;

		public override double AttackIncrement => 0;

		public override double HealthIncrement => 0;

		public override double HealthArmorIncrement => 0;

		public override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath
		{
			get
			{
				VEntityFramework.ErrorReporter.ReportDebug("theres also what, 20 abbs?");
				return new[] { new EnemyQuantity(EnemyType.GreatQueen, 4) };
			}
		}
	}
}
