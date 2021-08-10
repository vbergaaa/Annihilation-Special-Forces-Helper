﻿using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public static class WeaponHelper
	{

		public static double GetAttackPeriodWithAdeptAnnihilationTransfer(VLoadout loadout, double originalAttackPeriod, int cooldown, int aoeTargets, int attacksInDuration)
		{
			// this method incorporates attacks from annihilation transfer into the base adept attack speed
			// each transfer sends out 5 attacks
			// each attack can hit 4 units with aoe
			// therefore the light adept gets 20 additional attacks in the duration of the transfer cooldown
			// cd: 16
			var transferCoolDown = cooldown / (loadout.Stats.CooldownSpeed / 100);
			var additionalAttacksPerSecond = attacksInDuration * aoeTargets / transferCoolDown;

			var originalAttackPerSecond = 1 / originalAttackPeriod;
			var newAttacksPerSecond = originalAttackPerSecond + additionalAttacksPerSecond;
			return 1 / newAttacksPerSecond;
		}
	}
}
