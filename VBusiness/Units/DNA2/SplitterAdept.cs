using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: SplitterAdept
	// WeaponData: SplitterGlaive
	// EffectData: SplitterDamage

	public class SplitterAdept : Unit
	{
		public SplitterAdept(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.SplitterAdept;

		protected override double BaseAttack => 45;

		protected override double BaseAttackSpeed => 1.2;

		public override double AttackCount => 1;

		protected override double BaseHealth => 200;

		protected override double BaseHealthArmor => 6;

		protected override double BaseHealthRegen => 5;

		protected override double BaseShields => 350;

		protected override double BaseShieldsArmor => 6;

		protected override double BaseShieldsRegen => 7;

		protected override double HealthIncrement => 9;

		protected override double HealthRegenIncrement => 0.6015;

		protected override double ShieldIncrement => 11;

		protected override double ShieldRegenIncrement => 1;

		protected override double HealthArmorIncrement => 0.7;

		protected override double ShieldArmorIncrement => 0.7;

		protected override double AttackIncrement => 1.8;
	}
}
