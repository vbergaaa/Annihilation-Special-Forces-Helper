using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Colossus
	// WeaponData: ThermalLances
	// EffectData: ThermalLancesMU

	public class Colossus : Unit
	{
		public Colossus(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.Colossus;

		public override double BaseAttack => 20;

		public override double BaseAttackSpeed => 1.5;

		public override double BaseAttackCount => 2;

		public override double BaseHealth => 325;

		public override double BaseHealthArmor => 7;

		public override double BaseHealthRegen => 7;

		public override double BaseShields => 400;

		public override double BaseShieldArmor => 7;

		public override double BaseShieldRegen => 7;
	}
}
