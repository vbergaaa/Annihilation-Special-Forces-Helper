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

		protected override double BaseAttack => -5;

		protected override double BaseAttackSpeed => 1.5;

		public override double AttackCount => 0;

		protected override double BaseHealth => 50;

		protected override double BaseHealthArmor => 2;

		protected override double BaseHealthRegen => 2;

		protected override double BaseShields => 100;

		protected override double BaseShieldsArmor => 2;

		protected override double BaseShieldsRegen => 5;

		protected override double HealthIncrement => 4;

		protected override double HealthRegenIncrement => 0.1992;

		protected override double ShieldIncrement => 6;

		protected override double ShieldRegenIncrement => 0.8007;

		protected override double HealthArmorIncrement => 0.3;

		protected override double ShieldArmorIncrement => 0.3;

		protected override double AttackIncrement => -0.25;
	}
}
