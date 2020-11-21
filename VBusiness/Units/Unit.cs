﻿using System;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public abstract class Unit : VUnit
	{
		public override double AttackSpeedUpgradeIncrement => 0.96;
		public override double MaxedAttack => Attack + 100 * AttackUpgradeIncrement;
		public override double MaxedAttackSpeed => AttackSpeed + Math.Pow(AttackSpeedUpgradeIncrement, 15);
		public override double MaxedHealth => Health + 100 * HealthUpgradeIncrement;
		public override double MaxedHealthArmor => HealthArmor + 100 * HealthArmorUpgradeIncrement;
		public override double MaxedShields => Shields + 100 * ShieldsUpgradeIncrement;
		public override double MaxedShieldArmor => ShieldArmor + 100 * ShieldArmorUpgradeIncrement;
	}
}
