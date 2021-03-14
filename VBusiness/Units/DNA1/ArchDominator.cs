using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: HybridDominatorVoid
	//

	public class ArchDominator : IUnitData
	{
		public UnitType Type => UnitType.ArchDominator;

		double IUnitData.BaseAttack =>60;

		double IUnitData.BaseAttackSpeed => 1.4;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 1000;

		double IUnitData.BaseHealthArmor => 10;

		double IUnitData.BaseHealthRegen => 2.5;

		double IUnitData.BaseShields => 1000;

		double IUnitData.BaseShieldsArmor => 10;

		double IUnitData.BaseShieldsRegen => 5;

		double IUnitData.HealthIncrement => 11;

		double IUnitData.HealthRegenIncrement => 1.5;

		double IUnitData.ShieldIncrement => 11;

		double IUnitData.ShieldRegenIncrement => 3;

		double IUnitData.HealthArmorIncrement => 0.75;

		double IUnitData.ShieldArmorIncrement => 0.75;

		double IUnitData.AttackIncrement => 3.5;

		public UnitType[] SpecTypes => new[] { UnitType.Dominator };
	}
}
