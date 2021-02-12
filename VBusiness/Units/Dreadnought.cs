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
		public Dreadnought(VLoadout loadout) : base(loadout)
		{
		}

		public override double BaseAttack => 25;

		public override double BaseAttackSpeed => 2;

		public override double BaseAttackCount => 1;

		public override double BaseAttackRange => 6;

		public override double BaseHealth => 300;

		public override double BaseHealthArmor => 6;

		public override double BaseHealthRegen => 5;

		public override double BaseShields => 450;

		public override double BaseShieldArmor => 6;

		public override double BaseShieldRegen => 5;

		public override double BaseShieldRegenDelay => 2;
	}
}
