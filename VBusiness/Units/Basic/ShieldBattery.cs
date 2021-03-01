using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData name = Sentry
	// ASF weapon name = Healing Beam?

	public class ShieldBattery : Unit
	{
		public ShieldBattery(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.ShieldBattery;

		public override double BaseAttack => -8;

		public override double BaseAttackSpeed => 1.5;

		public override double BaseAttackCount => 0;

		public override double BaseHealth => 50;

		public override double BaseHealthArmor => 2;

		public override double BaseHealthRegen => 2;

		public override double BaseShields => 100;

		public override double BaseShieldArmor => 2;

		public override double BaseShieldRegen => 5;
	}
}
