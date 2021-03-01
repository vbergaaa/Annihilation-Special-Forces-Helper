using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Unit: DarkTemplar
	// Weapon: WarpBlades
	// Effect: WarpBlades
	public class DarkShadow : Unit
	{
		public DarkShadow(VLoadout loadout) : base(loadout)
		{
		}

		public override double BaseAttack => 20;

		public override double BaseAttackSpeed => 1;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 10;

		public override double BaseHealthArmor => 3;

		public override double BaseHealthRegen => 5;

		public override double BaseShields => 250;

		public override double BaseShieldArmor => 3;

		public override double BaseShieldRegen => 5;

		public override UnitType Type => UnitType.DarkShadow;
	}
}
