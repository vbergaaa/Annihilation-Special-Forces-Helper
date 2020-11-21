using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Unit: Adept
	// Weapon: Adept
	// Effect: AdeptDamage
	public class LightAdept : Unit
	{
		public override double Attack => 25;

		public override double AttackSpeed => 1.4;

		public override double AttackCount => 1;

		public override double AttackRange => 5;

		public override double AttackAOEMultiplier => 1;

		public override double Health => 125;

		public override double HealthArmor => 3;

		public override double HealthRegen => 3;

		public override double Shields => 175;

		public override double ShieldArmor => 3;

		public override double ShieldRegen => 5;

		public override double ShieldRegenDelay => 2;

		public override double MoveSpeed => 3;

		public override int Supply => 2;

		public override Evolution Evolution => Evolution.Basic;

		public override double AttackUpgradeIncrement => 1.25;

		public override double HealthUpgradeIncrement => 5;

		public override double HealthRegenUpgradeIncrement => 0.3984;

		public override double HealthArmorUpgradeIncrement => 0.45;

		public override double ShieldsUpgradeIncrement => 7;

		public override double ShieldRegenUpgradeIncrement => 1;

		public override double ShieldArmorUpgradeIncrement => 0.45;
	}
}
