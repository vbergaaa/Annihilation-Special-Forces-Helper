using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkArchonR
	// WeaponData: DarkShockwave
	// EffectData: PsionicShockwaveDamage2

	public class DarkArchon : Unit
	{
		public DarkArchon(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.DarkArchon;

		public override double BaseAttack => 30;

		public override double BaseAttackSpeed => 1.4;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 20;

		public override double BaseHealthArmor => 10;

		public override double BaseHealthRegen => 2;

		public override double BaseShields => 1000;

		public override double BaseShieldArmor => 10;

		public override double BaseShieldRegen => 6;
	}
}
