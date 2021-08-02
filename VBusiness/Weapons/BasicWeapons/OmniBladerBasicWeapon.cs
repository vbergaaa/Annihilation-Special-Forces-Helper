using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Weapons.BasicWeapons
{
	public class OmniBladerBasicWeapon : BasicAttackWeapon
	{
		public override double BaseAttack => 25;

		public override double BaseAttackPeriod => 2;

		public override double AttackCount => 52;

		public override double AttackIncrement => 2;
	}
}
