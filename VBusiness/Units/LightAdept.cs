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
		public LightAdept(VLoadout loadout) : base(loadout)
		{
		}

		public override double BaseAttack => 25;

		public override double BaseAttackSpeed => 1.4;

		public override double BaseAttackCount => 1;

		public override double BaseAttackRange => 5;

		public override double BaseHealth => 125;

		public override double BaseHealthArmor => 3;

		public override double BaseHealthRegen => 3;

		public override double BaseShields => 175;

		public override double BaseShieldArmor => 3;

		public override double BaseShieldRegen => 5;

		public override double BaseShieldRegenDelay => 2;

		public override UnitType Type => UnitType.LightAdept;
	}
}
