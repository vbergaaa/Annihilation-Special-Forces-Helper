using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Dragoon
	// WeaponData: Dragoon
	// EffectData: DragoonDamage

	public class Dragoon : Unit
	{
		public Dragoon(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.Dragoon;

		public override double BaseAttack => 15;

		public override double BaseAttackSpeed => 1.3;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 250;

		public override double BaseHealthArmor => 6;

		public override double BaseHealthRegen => 5;

		public override double BaseShields => 325;

		public override double BaseShieldArmor => 6;

		public override double BaseShieldRegen => 5;
	}
}
