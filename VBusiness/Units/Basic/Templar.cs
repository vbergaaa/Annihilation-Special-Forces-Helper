using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Unit: HighTemplar
	// Weapon effect: HighTemplarWeaponDamage
	// Ability effect: PsiStormDamage && PsiStormDamageInitial

	public class Templar : IUnitData
	{
		double IUnitData.BaseAttack => 20;

		double IUnitData.BaseAttackSpeed => 1;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 400;

		double IUnitData.BaseHealthArmor => 5;

		double IUnitData.BaseHealthRegen => 2;

		double IUnitData.BaseShields => 400;

		double IUnitData.BaseShieldsArmor => 5;

		double IUnitData.BaseShieldsRegen => 3;

		public UnitType Type => UnitType.Templar;

		double IUnitData.HealthIncrement => 6;

		double IUnitData.HealthRegenIncrement => 0.5;

		double IUnitData.ShieldIncrement => 6;

		double IUnitData.ShieldRegenIncrement => 0.5;

		double IUnitData.HealthArmorIncrement => 0.55;

		double IUnitData.ShieldArmorIncrement => 0.55;

		double IUnitData.AttackIncrement => 1;

		public UnitType[] SpecTypes => new[] { UnitType.Templar };
	}
}
