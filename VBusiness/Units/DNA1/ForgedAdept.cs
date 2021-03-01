using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ForgedAdept
	// WeaponData: DarkPurifierGlaive
	// EffectData: DarkAdeptDamage

	public class ForgedAdept : Unit
	{
		public ForgedAdept(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.ForgedAdept;

		public override double BaseAttack => 35;

		public override double BaseAttackSpeed => 1.3;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 160;

		public override double BaseHealthArmor => 4.5;

		public override double BaseHealthRegen => 4;

		public override double BaseShields => 250;

		public override double BaseShieldArmor => 4.5;

		public override double BaseShieldRegen => 6;
	}
}
