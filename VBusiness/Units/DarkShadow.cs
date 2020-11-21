using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Unit: DarkTemplar
	// Weapon: WarpBlades
	// Effect: WarpBlades
	public class DarkShadow : Unit
	{
		public override double Attack => 20;

		public override double AttackSpeed => 1;

		public override double AttackCount => 1;

		public override double AttackRange => 1;

		public override double AttackAOEMultiplier => 1;

		public override double Health => 10;

		public override double HealthArmor => 3;

		public override double HealthRegen => 5;

		public override double Shields => 250;

		public override double ShieldArmor => 3;

		public override double ShieldRegen => 5;

		public override double ShieldRegenDelay => 3;

		public override double MoveSpeed => 4;

		public override int Supply => 4;

		public override Evolution Evolution => Evolution.Basic;

		public override double AttackUpgradeIncrement => 1.5;

		public override double HealthUpgradeIncrement => 1;

		public override double HealthRegenUpgradeIncrement => 0.1992;

		public override double HealthArmorUpgradeIncrement => 0.3;

		public override double ShieldsUpgradeIncrement => 10;

		public override double ShieldRegenUpgradeIncrement => 1;

		public override double ShieldArmorUpgradeIncrement => 0.3;
	}
}
