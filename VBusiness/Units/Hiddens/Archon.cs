using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Archon
	// WeaponData: PsionicShockwave
	// EffectData: PsionicShockwaveDamage

	public class Archon : Unit
	{
		public Archon(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.Archon;

		public override double BaseAttack => 25;

		public override double BaseAttackSpeed => 1.4;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 10;

		public override double BaseHealthArmor => 7;

		public override double BaseHealthRegen => 1;

		public override double BaseShields => 700;

		public override double BaseShieldArmor => 7;

		public override double BaseShieldRegen => 4;
	}
}
