﻿using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData name = HybridDominator
	// ASF Weapon name = Psi Blast (can't find in WeaponData)
	public class Dominator : Unit
	{
		public Dominator(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.Dominator;

		public override double BaseAttack => 50;

		public override double BaseAttackSpeed => 1.5;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 600;

		public override double BaseHealthArmor => 6;

		public override double BaseHealthRegen => 1;

		public override double BaseShields => 600;

		public override double BaseShieldArmor => 6;

		public override double BaseShieldRegen => 2; // wasn't in data but seems to be correct from my testing
	}
}
