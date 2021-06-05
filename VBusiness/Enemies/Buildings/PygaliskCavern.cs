using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class PygaliskCavern : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.PygaliskCavern;

		public override double Attack => 0;

		public override double AttackSpeed => 0;

		public override double Health => 1500;

		public override double HealthArmor => 35;

		public override double AttackIncrement => 0;

		public override double HealthIncrement => 100;

		public override double HealthArmorIncrement => 7;

		public override int MineralBounty => 6000;

		protected override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.Pygalisk, 30) };
	}
}
