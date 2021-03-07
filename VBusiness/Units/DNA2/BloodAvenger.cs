using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkTemplarTaldarim
	// WeaponData: DarkTemplarTaldarmin
	// EffectData: BAScytheDamage

	public class BloodAvenger : Unit
	{
		public BloodAvenger(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.BloodAvenger;

		protected override double BaseAttack => 40;

		protected override double BaseAttackSpeed => 0.8;

		public override double AttackCount => 1;

		protected override double BaseHealth => 22;

		protected override double BaseHealthArmor => 5;

		protected override double BaseHealthRegen => 7;

		protected override double BaseShields => 475;

		protected override double BaseShieldsArmor => 5;

		protected override double BaseShieldsRegen => 7;

		protected override double HealthIncrement => 2;

		protected override double HealthRegenIncrement => 0.5;

		protected override double ShieldIncrement => 15;

		protected override double ShieldRegenIncrement => 2;

		protected override double HealthArmorIncrement => 0.6;

		protected override double ShieldArmorIncrement => 0.6;

		protected override double AttackIncrement => 2.5;
	}
}
