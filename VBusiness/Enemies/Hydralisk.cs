using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Hydralisk : EnemyUnit
	{
		public override EnemyType EnemyType => EnemyType.Hydralisk;

		public override double Attack => 22;

		public override double AttackSpeed
		{
			get
			{
				ErrorReporter.ReportDebug("You need to set this actually, this was a guess");
				return 1;
			}
		}

		public override double Health => 500;

		public override double HealthArmor => 12;

		public override double AttackIncrement => 5.5;

		public override double HealthIncrement => 45;

		public override double HealthArmorIncrement => 4;
	}
}
