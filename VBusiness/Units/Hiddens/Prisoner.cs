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

		protected override double BaseAttack => 15;

		protected override double BaseAttackSpeed => 1.4;

		public override double AttackCount => 2;

		protected override double BaseHealth => 275;

		protected override double BaseHealthArmor => 4;

		protected override double BaseHealthRegen => 8;

		protected override double BaseShields => 450;

		protected override double BaseShieldsArmor => 4;

		protected override double BaseShieldsRegen => 6;

		protected override double HealthIncrement => 6;

		protected override double HealthRegenIncrement => 0.8515;

		protected override double ShieldIncrement => 12;

		protected override double ShieldRegenIncrement => 0.8984;

		protected override double HealthArmorIncrement => 0.65;

		protected override double ShieldArmorIncrement => 0.65;

		protected override double AttackIncrement => 1.5;
	}
}
