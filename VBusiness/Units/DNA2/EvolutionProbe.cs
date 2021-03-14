using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class EvolutionProbe : IUnitData
	{
		// UnitData: EvolutionProbe
		// WeaponData: EvolutionParticleBeam
		// EffectData: DarkParticleBeam2

		public UnitType Type => UnitType.EvolutionProbe;

		double IUnitData.BaseAttack =>22;

		double IUnitData.BaseAttackSpeed => 1;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 100;

		double IUnitData.BaseHealthArmor => 6;

		double IUnitData.BaseHealthRegen => 0;

		double IUnitData.BaseShields => 200;

		double IUnitData.BaseShieldsArmor => 6;

		double IUnitData.BaseShieldsRegen => 5;

		double IUnitData.HealthIncrement => 10;

		double IUnitData.HealthRegenIncrement => 0.6015;

		double IUnitData.ShieldIncrement => 16;

		double IUnitData.ShieldRegenIncrement => 1;

		double IUnitData.HealthArmorIncrement => 0.6;

		double IUnitData.ShieldArmorIncrement => 0.6;

		double IUnitData.AttackIncrement => 1.2;

		public UnitType[] SpecTypes => new UnitType[0];
	}
}
