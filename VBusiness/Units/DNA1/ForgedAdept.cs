using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ForgedAdept
	// WeaponData: DarkPurifierGlaive
	// EffectData: DarkAdeptDamage

	public class ForgedAdept : IUnitData
	{
		public UnitType Type => UnitType.ForgedAdept;

		double IUnitData.BaseAttack =>35;

		double IUnitData.BaseAttackSpeed => 1.3;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 160;

		double IUnitData.BaseHealthArmor => 4.5;

		double IUnitData.BaseHealthRegen => 4;

		double IUnitData.BaseShields => 250;

		double IUnitData.BaseShieldsArmor => 4.5;

		double IUnitData.BaseShieldsRegen => 6;

		double IUnitData.HealthIncrement => 7;

		double IUnitData.HealthRegenIncrement => 0.5;

		double IUnitData.ShieldIncrement => 9;

		double IUnitData.ShieldRegenIncrement => 1;

		double IUnitData.HealthArmorIncrement => 0.6;

		double IUnitData.ShieldArmorIncrement => 0.6;

		double IUnitData.AttackIncrement => 1.6;

		public UnitType[] SpecTypes => new[] { UnitType.LightAdept };
	}
}
