using EnumsNET;
using System;
using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public abstract class EnemyUnit
	{
		public abstract EnemyType EnemyType { get; }
		public abstract double Attack { get; }
		public abstract double AttackSpeed { get; }
		public abstract double Health { get; }
		public abstract double HealthArmor { get; }
		public abstract double AttackIncrement { get; }
		public abstract double HealthIncrement { get; }
		public abstract double HealthArmorIncrement { get; }

		public static EnemyUnit New(EnemyType unitType)
		{
			var enemyName = unitType.AsString(EnumFormat.Name);
			var enemyType = System.Type.GetType($"VBusiness.Enemies.{enemyName}");

			if (enemyType == null)
			{
				ErrorReporter.ReportDebug($"Please create a class named VBusiness.Enemies.{enemyName}");
				return null;
			}

			var ret = (EnemyUnit)Activator.CreateInstance(enemyType);
			return ret;
		}

		public virtual IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => Array.Empty<EnemyQuantity>();
	}
}
