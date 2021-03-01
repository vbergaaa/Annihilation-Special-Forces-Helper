using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkTemplarTaldarim
	// WeaponData: DarkTemplarTaldarmin
	// EffectData: BAScytheDamage

	public class BloodAvenger : Unit
	{
		public BloodAvenger(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.BloodAvenger;

		public override double BaseAttack => 40;

		public override double BaseAttackSpeed => 0.8;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 22;

		public override double BaseHealthArmor => 5;

		public override double BaseHealthRegen => 7;

		public override double BaseShields => 475;

		public override double BaseShieldArmor => 5;

		public override double BaseShieldRegen => 7;
	}
}
