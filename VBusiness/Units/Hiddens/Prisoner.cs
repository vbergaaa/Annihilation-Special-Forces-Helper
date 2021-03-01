using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Prisoner
	// WeaponData: PrisonerBlades
	// EffectData: WarpBladesDamage2

	public class Prisoner : Unit
	{
		public Prisoner(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.Prisoner;

		public override double BaseAttack => 15;

		public override double BaseAttackSpeed => 1.4;

		public override double BaseAttackCount => 2;

		public override double BaseHealth => 275;

		public override double BaseHealthArmor => 4;

		public override double BaseHealthRegen => 8;

		public override double BaseShields => 450;

		public override double BaseShieldArmor => 4;

		public override double BaseShieldRegen => 6;
	}
}
