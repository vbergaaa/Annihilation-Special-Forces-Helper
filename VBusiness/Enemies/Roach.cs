using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Roach : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.Roach;

		public override double Attack => 16;

		public override double AttackSpeed => 1.2;

		public override double Health => 100;

		public override double HealthArmor => 5;

		public override double AttackIncrement => 4.5;

		public override double HealthIncrement => 35;

		public override double HealthArmorIncrement => 2;
	}
}
