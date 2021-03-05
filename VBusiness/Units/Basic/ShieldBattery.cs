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

		public override double BaseAttack => -5;

		public override double BaseAttackSpeed => 1.5;

		public override double BaseAttackCount => 0;

		public override double BaseHealth => 50;

		public override double BaseHealthArmor => 2;

		public override double BaseHealthRegen => 2;

		public override double BaseShields => 100;

		public override double BaseShieldArmor => 2;

		public override double BaseShieldRegen => 5;

		protected override double HealthIncrement => 4;

		protected override double HealthRegenIncrement => 0.1992;

		protected override double ShieldIncrement => 6;

		protected override double ShieldRegenIncrement => 0.8007;

		protected override double HealthArmorIncrement => 0.3;

		protected override double ShieldArmorIncrement => 0.3;

		protected override double AttackIncrement => -0.25;
	}
}
