using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Unit: HighTemplar
	// Weapon effect: HighTemplarWeaponDamage
	// Ability effect: PsiStormDamage && PsiStormDamageInitial

	public class Templar : Unit
	{
		public override double Attack => 20;

		public override double AttackSpeed => 1;

		public override double AttackCount => 1;

		public override double AttackRange => 7;

		// PSI Storm Damage starts at 70 (10 per tick * 7 ticks) and gains 7.7 per level (1.1 per tick * 7 ticks) - makes sense
		// At level 100 deals __ compared to main weapon ____
		// Units standing in a storm? I'm guessing 10?
		// Cooldown is 8;
		// hits 7? times - would depend on atkspeed ups
		// This is far too complex to work out
		public override double AttackAOEMultiplier => 0;

		public override double Health => 400;

		public override double HealthArmor => 5;

		public override double HealthRegen => 2;

		public override double Shields => 400;

		public override double ShieldArmor => 5;

		public override double ShieldRegen => 3;

		public override double ShieldRegenDelay => 2;

		public override double MoveSpeed => 3;

		public override int Supply => 5;

		public override Evolution Evolution => Evolution.Basic;

		public override double AttackUpgradeIncrement => 1;

		public override double HealthUpgradeIncrement => 6;

		public override double HealthRegenUpgradeIncrement => 0.5;

		public override double HealthArmorUpgradeIncrement => 0.55;

		public override double ShieldsUpgradeIncrement => 6;

		public override double ShieldRegenUpgradeIncrement => 0.5;

		public override double ShieldArmorUpgradeIncrement => 0.55;
	}
}
