using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: BladeDancer
	// WeaponData: BladeDance

	public class BladeDancer : Unit
	{
		public BladeDancer(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.BladeDancer;

		public override double BaseAttack => 10;

		public override double BaseAttackSpeed => 2.5;

		public override double BaseAttackCount => 10;

		public override double BaseHealth => 500;

		public override double BaseHealthArmor => 8;

		public override double BaseHealthRegen => 9;

		public override double BaseShields => 750;

		public override double BaseShieldArmor => 8;

		public override double BaseShieldRegen => 15;

		protected override double HealthIncrement => 11;

		protected override double HealthRegenIncrement => 1.1992;

		protected override double ShieldIncrement => 18;

		protected override double ShieldRegenIncrement => 1.3984;

		protected override double HealthArmorIncrement => 0.9;

		protected override double ShieldArmorIncrement => 0.9;

		protected override double AttackIncrement => 1;
	}
}
