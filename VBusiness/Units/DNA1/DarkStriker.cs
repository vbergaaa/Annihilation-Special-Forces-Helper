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

	public class DarkStriker : IUnitData
	{
		public UnitType Type => UnitType.DarkStriker;

		double IUnitData.BaseAttack =>22;

		double IUnitData.BaseAttackSpeed => 1.4;

		double IUnitData.AttackCount => 1; // this is technically 3, but for single target damage, it's effectively 1

		double IUnitData.BaseHealth => 160;

		double IUnitData.BaseHealthArmor => 4.5;

		double IUnitData.BaseHealthRegen => 2;

		double IUnitData.BaseShields => 200;

		double IUnitData.BaseShieldsArmor => 4.5;

		double IUnitData.BaseShieldsRegen => 2; // from in-game test

		double IUnitData.HealthIncrement => 6;

		double IUnitData.HealthRegenIncrement => 0.3515;

		double IUnitData.ShieldIncrement => 8;

		double IUnitData.ShieldRegenIncrement => 0.6992;

		double IUnitData.HealthArmorIncrement => 0.5;

		double IUnitData.ShieldArmorIncrement => 0.5;

		double IUnitData.AttackIncrement => 1.25;

		public UnitType[] SpecTypes => new[] { UnitType.Striker };
	}
}
