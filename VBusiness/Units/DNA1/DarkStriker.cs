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

		protected override double BaseAttack => 22;

		protected override double BaseAttackSpeed => 1.4;

		public override double AttackCount => 1; // this is technically 3, but for single target damage, it's effectively 1

		protected override double BaseHealth => 160;

		protected override double BaseHealthArmor => 4.5;

		protected override double BaseHealthRegen => 2;

		protected override double BaseShields => 200;

		protected override double BaseShieldsArmor => 4.5;

		protected override double BaseShieldsRegen => 2; // from in-game test

		protected override double HealthIncrement => 6;

		protected override double HealthRegenIncrement => 0.3515;

		protected override double ShieldIncrement => 8;

		protected override double ShieldRegenIncrement => 0.6992;

		protected override double HealthArmorIncrement => 0.5;

		protected override double ShieldArmorIncrement => 0.5;

		protected override double AttackIncrement => 1.25;
	}
}
