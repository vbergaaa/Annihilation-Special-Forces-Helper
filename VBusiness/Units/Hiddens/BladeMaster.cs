using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: MasterDance

	public class BladeMaster : Unit
	{
		public BladeMaster(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.BladeMaster;

		public override double BaseAttack => 15;

		public override double BaseAttackSpeed => 2.3;

		public override double BaseAttackCount => 20;

		public override double BaseHealth => 700;

		public override double BaseHealthArmor => 12;

		public override double BaseHealthRegen => 12;

		public override double BaseShields => 1000;

		public override double BaseShieldArmor => 12;

		public override double BaseShieldRegen => 22;
	}
}
