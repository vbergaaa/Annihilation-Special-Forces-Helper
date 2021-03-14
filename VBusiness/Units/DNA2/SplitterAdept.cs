using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: SplitterAdept
	// WeaponData: SplitterGlaive
	// EffectData: SplitterDamage

	public class SplitterAdept : IUnitData
	{
		public UnitType Type => UnitType.SplitterAdept;

		double IUnitData.BaseAttack =>45;

		double IUnitData.BaseAttackSpeed => 1.2;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 200;

		double IUnitData.BaseHealthArmor => 6;

		double IUnitData.BaseHealthRegen => 5;

		double IUnitData.BaseShields => 350;

		double IUnitData.BaseShieldsArmor => 6;

		double IUnitData.BaseShieldsRegen => 7;

		double IUnitData.HealthIncrement => 9;

		double IUnitData.HealthRegenIncrement => 0.6015;

		double IUnitData.ShieldIncrement => 11;

		double IUnitData.ShieldRegenIncrement => 1;

		double IUnitData.HealthArmorIncrement => 0.7;

		double IUnitData.ShieldArmorIncrement => 0.7;

		double IUnitData.AttackIncrement => 1.8;

		public UnitType[] SpecTypes => new[] { UnitType.LightAdept };
	}
}
