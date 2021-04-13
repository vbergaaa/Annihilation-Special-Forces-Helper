using System;
using System.Collections.Generic;
using System.Text;

namespace VEntityFramework.Model
{
	public abstract class VEnemyUnit
	{
		public abstract EnemyType EnemyType { get; }
		public abstract double Attack { get; }
		public abstract double AttackSpeed { get; }
		public abstract double Health { get; }
		public abstract double HealthArmor { get; }
		public abstract double AttackIncrement { get; }
		public abstract double HealthIncrement { get; }
		public abstract double HealthArmorIncrement { get; }
	}
}
