using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	//UnitData = DarkProbe
	//WeaponData = DarkParticleBeam
	public class DarkProbe : IUnitData
	{
		public UnitType Type => UnitType.DarkProbe;

		double IUnitData.BaseAttack =>12;

		double IUnitData.BaseAttackSpeed => 1.3;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 50;

		double IUnitData.BaseHealthArmor => 4;

		double IUnitData.BaseHealthRegen => 0;

		double IUnitData.BaseShields => 100;

		double IUnitData.BaseShieldsArmor => 4;

		double IUnitData.BaseShieldsRegen => 5;

		double IUnitData.HealthIncrement => 5;

		double IUnitData.HealthRegenIncrement => 0.3007;

		double IUnitData.ShieldIncrement => 8;

		double IUnitData.ShieldRegenIncrement => 0.5;

		double IUnitData.HealthArmorIncrement => 0.3;

		double IUnitData.ShieldArmorIncrement => 0.3;

		double IUnitData.AttackIncrement => 0.8;

		public UnitType[] SpecTypes => new UnitType[0];
	}
}
