using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class EmptyUnit : IUnitData
	{
		public UnitType Type => UnitType.None;

		double IUnitData.BaseAttack =>0;

		double IUnitData.BaseAttackSpeed => 0;

		double IUnitData.AttackCount => 0;

		double IUnitData.BaseHealth => 0;

		double IUnitData.BaseHealthArmor => 0;

		double IUnitData.BaseHealthRegen => 0;

		double IUnitData.BaseShields => 0;

		double IUnitData.BaseShieldsArmor => 0;

		double IUnitData.BaseShieldsRegen => 0;

		double IUnitData.HealthIncrement => 0;

		double IUnitData.HealthRegenIncrement => 0;

		double IUnitData.ShieldIncrement => 0;

		double IUnitData.ShieldRegenIncrement => 0;

		double IUnitData.HealthArmorIncrement => 0;

		double IUnitData.ShieldArmorIncrement => 0;

		double IUnitData.AttackIncrement => 0;

		public UnitType[] SpecTypes => new UnitType[0];
	}
}
