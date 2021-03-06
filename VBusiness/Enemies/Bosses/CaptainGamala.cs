﻿using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class CaptainGamala : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.CaptainGamala;

		public override double Attack => 300;

		public override double AttackSpeed => 0.5;

		public override double Health => 30000;

		public override double HealthArmor => 250;

		public override double AttackIncrement => 0;

		public override double HealthIncrement => 0;

		public override double HealthArmorIncrement => 0;

		public override int MineralBounty => 40000;
		public override int KillBounty => 2000;

		protected override IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => new[] { new EnemyQuantity(EnemyType.GreatQueen, 10) };
	}
}
