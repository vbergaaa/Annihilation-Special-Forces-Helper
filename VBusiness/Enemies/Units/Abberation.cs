﻿using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Abberation : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.Abberation;

		public override double Attack => 12;

		public override double AttackSpeed => 1;

		public override double Health => 100;

		public override double HealthArmor => 3;

		public override double AttackIncrement => 3;

		public override double HealthIncrement => 20;

		public override double HealthArmorIncrement => 3;

		public override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.InfestedTerran, 5) };
	}
}
