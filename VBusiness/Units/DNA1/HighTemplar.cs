using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: HighArchonTemplar
	// WeaponData: HighTemplarWeapon

	public class HighTemplar : Unit
	{
		public HighTemplar(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.HighTemplar;

		public override double BaseAttack => 20;

		public override double BaseAttackSpeed => 1.5;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 650;

		public override double BaseHealthArmor => 7;

		public override double BaseHealthRegen => 3;

		public override double BaseShields => 650;

		public override double BaseShieldArmor => 7;

		public override double BaseShieldRegen => 6;
	}
}
