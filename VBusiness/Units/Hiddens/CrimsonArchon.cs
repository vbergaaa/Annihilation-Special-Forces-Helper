using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkArchon
	// WeaponData: DarkArchonWeapon
	// EffectData: DarkArchonWeaponDamage

	public class CrimsonArchon : Unit
	{
		public CrimsonArchon(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.CrimsonArchon;

		public override double BaseAttack => 50;

		public override double BaseAttackSpeed => 1.3;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 30;

		public override double BaseHealthArmor => 12;

		public override double BaseHealthRegen => 3;

		public override double BaseShields => 1250;

		public override double BaseShieldArmor => 12;

		public override double BaseShieldRegen => 8;
	}
}
