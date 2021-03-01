using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class EmptyUnit : Unit
	{
		public EmptyUnit(VLoadout loadout) : base(loadout)
		{
			loadout.Units.Remove(this);
			HasChanges = false;
		}

		public override UnitType Type => UnitType.None;

		public override double BaseAttack => 0;

		public override double BaseAttackSpeed => 0;

		public override double BaseAttackCount => 0;

		public override double BaseHealth => 0;

		public override double BaseHealthArmor => 0;

		public override double BaseHealthRegen => 0;

		public override double BaseShields => 0;

		public override double BaseShieldArmor => 0;

		public override double BaseShieldRegen => 0;
	}
}
