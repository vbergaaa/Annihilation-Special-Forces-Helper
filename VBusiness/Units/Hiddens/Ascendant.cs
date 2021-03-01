using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: HighTemplarTaldarmin
	// WeaponData: AscendantWeapon
	// EffectData: AscendantWeaponDamage

	public class Ascendant : Unit
	{
		public Ascendant(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.Ascendant;

		public override double BaseAttack => 25;

		public override double BaseAttackSpeed => 1.4;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 500;

		public override double BaseHealthArmor => 10;

		public override double BaseHealthRegen => 2;

		public override double BaseShields => 1000;

		public override double BaseShieldArmor => 10;

		public override double BaseShieldRegen => 10;
	}
}
