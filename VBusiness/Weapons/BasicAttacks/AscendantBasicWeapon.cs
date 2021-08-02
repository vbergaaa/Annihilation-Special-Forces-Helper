﻿namespace VBusiness.Weapons
{
	public class AscendentBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 25;

		public override double BaseAttackPeriod => 1.4;

		public override double AttackIncrement => 2;
	}
}
