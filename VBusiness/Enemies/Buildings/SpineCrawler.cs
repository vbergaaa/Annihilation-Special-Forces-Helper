using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class SpineCrawler : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.SpineCrawler;

		public override double Attack => 18;

		public override double AttackSpeed => 1;

		public override double Health => 235;

		public override double HealthArmor => 8;

		public override double AttackIncrement => 4.5;

		public override double HealthIncrement => 20;

		public override double HealthArmorIncrement => 2;

		protected override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.InfestedTerran, 10) };
	}
}
