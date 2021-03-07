using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	//UnitData: Monitor
	//EffectData: HealingBeam2

	public class DarkShieldBattery : Unit
	{
		public DarkShieldBattery(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.DarkShieldBattery;

		protected override double BaseAttack => -7;

		protected override double BaseAttackSpeed => 1.4;

		public override double AttackCount => 1;

		protected override double BaseHealth => 75;

		protected override double BaseHealthArmor => 3;

		protected override double BaseHealthRegen => 3;

		protected override double BaseShields => 150;

		protected override double BaseShieldsArmor => 3;

		protected override double BaseShieldsRegen => 7;

		protected override double HealthIncrement => 6;

		protected override double HealthRegenIncrement => 0.3007;

		protected override double ShieldIncrement => 9;

		protected override double ShieldRegenIncrement => 1;

		protected override double HealthArmorIncrement => 0.45;

		protected override double ShieldArmorIncrement => 0.45;

		protected override double AttackIncrement => -0.35;
	}
}
