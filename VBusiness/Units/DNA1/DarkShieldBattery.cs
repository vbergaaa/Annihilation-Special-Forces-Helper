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

		public override double BaseAttack => -7;

		public override double BaseAttackSpeed => 1.4;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 75;

		public override double BaseHealthArmor => 3;

		public override double BaseHealthRegen => 3;

		public override double BaseShields => 150;

		public override double BaseShieldArmor => 3;

		public override double BaseShieldRegen => 7;

		protected override double HealthIncrement => 6;

		protected override double HealthRegenIncrement => 0.3007;

		protected override double ShieldIncrement => 9;

		protected override double ShieldRegenIncrement => 1;

		protected override double HealthArmorIncrement => 0.45;

		protected override double ShieldArmorIncrement => 0.45;

		protected override double AttackIncrement => -0.35;
	}
}
