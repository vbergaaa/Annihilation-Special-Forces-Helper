using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ZealotAiur
	// WeaponData: SolariteReaper
	
	public class BerserkerWarpLord : IUnitData
	{
		public UnitType Type => UnitType.BerserkerWarpLord;

		double IUnitData.BaseAttack =>16;

		double IUnitData.BaseAttackSpeed => 1;

		double IUnitData.AttackCount => 2;

		double IUnitData.BaseHealth => 225;

		double IUnitData.BaseHealthArmor => 5;

		double IUnitData.BaseHealthRegen => 4;

		double IUnitData.BaseShields => 320;

		double IUnitData.BaseShieldsArmor => 5;

		double IUnitData.BaseShieldsRegen => 4;

		double IUnitData.HealthIncrement => 7;

		double IUnitData.HealthRegenIncrement => 0.3984;

		double IUnitData.ShieldIncrement => 13;

		double IUnitData.ShieldRegenIncrement => 1;

		double IUnitData.HealthArmorIncrement => 0.6;

		double IUnitData.ShieldArmorIncrement => 0.6;

		double IUnitData.AttackIncrement => 1.2;

		public UnitType[] SpecTypes => new[] { UnitType.WarpLord };
	}
}
