using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public abstract class Bruta : EnemyUnit
	{

		public override double Attack => 50;

		public override double AttackSpeed => 0.6;

		public override double Health => 2500;

		public override double HealthArmor => 25;

		public override double AttackIncrement => 5;

		public override double HealthIncrement => 150;

		public override double HealthArmorIncrement => 6;

		public override int MineralBounty => 4000;
		public override int KillBounty => 500;
	}
}
