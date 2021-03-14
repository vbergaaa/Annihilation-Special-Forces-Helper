using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData name = HybridDominator
	// ASF Weapon name = Psi Blast (can't find in WeaponData)
	public class Dominator : IUnitData
	{
		public UnitType Type => UnitType.Dominator;

		double IUnitData.BaseAttack => 50;

		double IUnitData.BaseAttackSpeed => 1.5;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 600;

		double IUnitData.BaseHealthArmor => 6;

		double IUnitData.BaseHealthRegen => 1;

		double IUnitData.BaseShields => 600;

		double IUnitData.BaseShieldsArmor => 6;

		double IUnitData.BaseShieldsRegen => 2; // wasn't in data but seems to be correct from my testing

		double IUnitData.HealthIncrement => 8;

		double IUnitData.HealthRegenIncrement => 1;

		double IUnitData.ShieldIncrement => 8;

		double IUnitData.ShieldRegenIncrement => 2.0;

		double IUnitData.HealthArmorIncrement => 0.6;

		double IUnitData.ShieldArmorIncrement => 0.6;

		double IUnitData.AttackIncrement => 2.5;

		public UnitType[] SpecTypes => new[] { UnitType.Dominator };
	}
}
