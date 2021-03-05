using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: StalkerShakuras
	// WeaponData: DarkDisruptor
	// EffectData: EntropyLanceSearch3
	// EffectData: ParticleDisruptors3
	// EffectDamage: ParticleDisruptorsU3

	public class DarkStriker : Unit
	{
		public DarkStriker(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.DarkStriker;

		public override double BaseAttack => 22;

		public override double BaseAttackSpeed => 1.4;

		public override double BaseAttackCount => 1; // this is technically 3, but for single target damage, it's effectively 1

		public override double BaseHealth => 160;

		public override double BaseHealthArmor => 4.5;

		public override double BaseHealthRegen => 2;

		public override double BaseShields => 200;

		public override double BaseShieldArmor => 4.5;

		public override double BaseShieldRegen => 2; // from in-game test

		protected override double HealthIncrement => 6;

		protected override double HealthRegenIncrement => 0.3515;

		protected override double ShieldIncrement => 8;

		protected override double ShieldRegenIncrement => 0.6992;

		protected override double HealthArmorIncrement => 0.5;

		protected override double ShieldArmorIncrement => 0.5;

		protected override double AttackIncrement => 1.25;
	}
}
