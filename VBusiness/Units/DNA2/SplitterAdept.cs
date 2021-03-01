using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: SplitterAdept
	// WeaponData: SplitterGlaive
	// EffectData: SplitterDamage

	public class SplitterAdept : Unit
	{
		public SplitterAdept(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.SplitterAdept;

		public override double BaseAttack => 45;

		public override double BaseAttackSpeed => 1.2;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 200;

		public override double BaseHealthArmor => 6;

		public override double BaseHealthRegen => 5;

		public override double BaseShields => 350;

		public override double BaseShieldArmor => 6;

		public override double BaseShieldRegen => 7;
	}
}
