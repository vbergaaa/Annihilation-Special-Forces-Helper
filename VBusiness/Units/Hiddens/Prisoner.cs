using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Prisoner
	// WeaponData: PrisonerBlades
	// EffectData: WarpBladesDamage2

	public class Prisoner : Unit
	{
		public Prisoner(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.Prisoner;

		public override double BaseAttack => 15;

		public override double BaseAttackSpeed => 1.4;

		public override double BaseAttackCount => 2;

		public override double BaseHealth => 275;

		public override double BaseHealthArmor => 4;

		public override double BaseHealthRegen => 8;

		public override double BaseShields => 450;

		public override double BaseShieldArmor => 4;

		public override double BaseShieldRegen => 6;

		protected override double HealthIncrement => 6;

		protected override double HealthRegenIncrement => 0.8515;

		protected override double ShieldIncrement => 12;

		protected override double ShieldRegenIncrement => 0.8984;

		protected override double HealthArmorIncrement => 0.65;

		protected override double ShieldArmorIncrement => 0.65;

		protected override double AttackIncrement => 1.5;
	}
}
