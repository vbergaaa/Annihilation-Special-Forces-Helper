using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class EvolutionChamber : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.EvolutionChamber;

		public override double Attack => 0;

		public override double AttackSpeed => 0;

		public override double Health => 300;

		public override double HealthArmor => 6;

		public override double AttackIncrement => 0;

		public override double HealthIncrement => 25;

		public override double HealthArmorIncrement => 2;

		public override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.InfestedTerran, 20) };
	}
}
