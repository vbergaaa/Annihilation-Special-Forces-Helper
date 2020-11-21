using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Stalker
	// ParticleDisruptor / ParticleDisruptorU

	public class Striker : Unit
	{
		public override double Attack => 15;

		public override double AttackSpeed => 1.5;

		public override double AttackCount => 2;

		public override double AttackAOEMultiplier => 1;

		public override double Health => 125;

		public override double HealthArmor => 3;

		public override double HealthRegen => 1;

		public override double Shields => 160;

		public override double ShieldArmor => 3;

		public override double ShieldRegen => 2;

		public override double ShieldRegenDelay => 2;

		public override double MoveSpeed => 2.5;

		public override int Supply => 2;

		public override Evolution Evolution => Evolution.Basic;

		public override double AttackUpgradeIncrement => 1;

		public override double HealthUpgradeIncrement => 4;

		public override double HealthRegenUpgradeIncrement => .300700;

		public override double HealthArmorUpgradeIncrement => 0.4;

		public override double ShieldsUpgradeIncrement => 6;

		public override double ShieldRegenUpgradeIncrement => .5;

		public override double ShieldArmorUpgradeIncrement => 0.4;

		public override double AttackRange => 6;
	}
}
