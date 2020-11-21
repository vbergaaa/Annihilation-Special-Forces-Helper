using System;
using System.Collections.Generic;
using System.Text;

namespace VEntityFramework.Model
{
	public abstract class VUnit
	{
		#region Properties

		public abstract double Attack { get; }
		public abstract double AttackSpeed { get; }
		public abstract double AttackCount { get; }
		public abstract double AttackRange { get; }
		public abstract double AttackAOEMultiplier { get; }
		public abstract double Health { get; }
		public abstract double HealthArmor { get; }
		public abstract double HealthRegen { get; }
		public abstract double Shields { get; }
		public abstract double ShieldArmor { get; }
		public abstract double ShieldRegen { get; }
		public abstract double ShieldRegenDelay { get; }
		public abstract double MoveSpeed { get; }
		public abstract int Supply { get; }
		public abstract Evolution Evolution { get; }
		public abstract double AttackUpgradeIncrement { get; }
		public abstract double AttackSpeedUpgradeIncrement { get; }
		public abstract double HealthUpgradeIncrement { get; }
		public abstract double HealthRegenUpgradeIncrement { get; }
		public abstract double HealthArmorUpgradeIncrement { get; }
		public abstract double ShieldsUpgradeIncrement { get; }
		public abstract double ShieldRegenUpgradeIncrement { get; }
		public abstract double ShieldArmorUpgradeIncrement { get; }
		public abstract double MaxedAttack { get; }
		public abstract double MaxedAttackSpeed { get; }
		public abstract double MaxedHealth { get; }
		public abstract double MaxedHealthArmor { get; }
		public abstract double MaxedShields { get; }
		public abstract double MaxedShieldArmor { get; }

		#endregion
	}

	public enum Evolution
	{
		Basic,
		DNA1,
		DNA2,
		Hero,
		SuperHero
	}
}
