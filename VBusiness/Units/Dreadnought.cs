using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Unit: Immortal
	// Main Effect: PhaseDisruptors
	// Splash Effect: ImmortalSplashDamage
	public class Dreadnought : Unit
	{
		public override double Attack => 25;

		public override double AttackSpeed => 2;

		public override double AttackCount => 1;

		public override double AttackRange => 6;

		// Splash Attack starts at 12 and gains .8 per level

		// has radius of 1, so 5 enemies a shot roughly. assuming max ups, splash does 92 compared to main weapon 175
		public override double AttackAOEMultiplier => 5.0 * (92.0 / 175.0);

		public override double Health => 300;

		public override double HealthArmor => 6;

		public override double HealthRegen => 5;

		public override double Shields => 450;

		public override double ShieldArmor => 6;

		public override double ShieldRegen => 5;

		public override double ShieldRegenDelay => 2;

		public override double MoveSpeed => 1.5;

		public override int Supply => 4;

		public override Evolution Evolution => Evolution.Basic;

		public override double AttackUpgradeIncrement => 1.5;

		public override double HealthUpgradeIncrement => 7;

		public override double HealthRegenUpgradeIncrement => 1;

		public override double HealthArmorUpgradeIncrement => 0.45;

		public override double ShieldsUpgradeIncrement => 18;

		public override double ShieldRegenUpgradeIncrement => 1.1992;

		public override double ShieldArmorUpgradeIncrement => 0.45;
	}
}
