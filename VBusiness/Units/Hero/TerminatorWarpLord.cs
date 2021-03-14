using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ZealotPurifier
	// WeaponData: TerminatorBlades

	public class TerminatorWarpLord : IUnitData
	{
		public UnitType Type => UnitType.TerminatorWarpLord;

		double IUnitData.BaseAttack =>30;

		double IUnitData.BaseAttackSpeed => 0.8;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 400;

		double IUnitData.BaseHealthArmor => 6;

		double IUnitData.BaseHealthRegen => 6;

		double IUnitData.BaseShields => 625;

		double IUnitData.BaseShieldsArmor => 6;

		double IUnitData.BaseShieldsRegen => 10;

		double IUnitData.HealthIncrement => 10;

		double IUnitData.HealthRegenIncrement => 1;

		double IUnitData.ShieldIncrement => 17;

		double IUnitData.ShieldRegenIncrement => 1.3007;

		double IUnitData.HealthArmorIncrement => 0.8;

		double IUnitData.ShieldArmorIncrement => 0.8;

		double IUnitData.AttackIncrement => 2.2;

		public UnitType[] SpecTypes => new[] { UnitType.WarpLord };
	}
}
