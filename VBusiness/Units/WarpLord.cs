using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	/// Unit: Zealot
	/// Weapon: Psi Blades
	public class WarpLord : Unit
	{
		public override double Attack => 11;

		public override double AttackSpeed => 1.5;

		public override double AttackCount => 2;

		public override double AttackAOEMultiplier => 1;

		public override double Health => 100;

		public override double HealthArmor => 2;

		public override double HealthRegen => 2;

		public override double Shields => 150;

		public override double ShieldArmor => 2;

		public override double ShieldRegen => 3;

		public override double ShieldRegenDelay => 1;

		public override double MoveSpeed => 3.5;

		public override int Supply => 2;

		public override Evolution Evolution => Evolution.Basic;

		public override double AttackUpgradeIncrement => 0.6;

		public override double HealthUpgradeIncrement => 4;

		public override double HealthArmorUpgradeIncrement => 0.35;

		public override double ShieldsUpgradeIncrement => 8;

		public override double ShieldArmorUpgradeIncrement => 0.35;

		public override double HealthRegenUpgradeIncrement => 0.1992;

		public override double ShieldRegenUpgradeIncrement => 0.5;

		public override double AttackRange => 1;
	}
}
