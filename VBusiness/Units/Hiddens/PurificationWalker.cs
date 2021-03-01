using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class PurificationWalker : Unit
	{
		// UnitData: ColossusPurifier
		// WeaponData: ColossusPurifierThermalLances
		// EffectData: ColossusPurifierThermalLancesDamage

		public PurificationWalker(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.PurificationWalker;

		public override double BaseAttack => 30;

		public override double BaseAttackSpeed => 1.4;

		public override double BaseAttackCount => 2;

		public override double BaseHealth => 600;

		public override double BaseHealthArmor => 8;

		public override double BaseHealthRegen => 5;

		public override double BaseShields => 850;

		public override double BaseShieldArmor => 8;

		public override double BaseShieldRegen => 5;
	}
}
