using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Reaver
	// EffectData: ScarabExplodeTargetDamage

	public class Reaver : IUnitData
	{
		public UnitType Type => UnitType.Reaver;

		double IUnitData.BaseAttack =>25;

		double IUnitData.BaseAttackSpeed => 2;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 250;

		double IUnitData.BaseHealthArmor => 6;

		double IUnitData.BaseHealthRegen => 5;

		double IUnitData.BaseShields => 325;

		double IUnitData.BaseShieldsArmor => 6;

		double IUnitData.BaseShieldsRegen => 5;

		double IUnitData.HealthIncrement => 5;

		double IUnitData.HealthRegenIncrement => 0.3007;

		double IUnitData.ShieldIncrement => 10;

		double IUnitData.ShieldRegenIncrement => 0.8007;

		double IUnitData.HealthArmorIncrement => 0.6;

		double IUnitData.ShieldArmorIncrement => 0.6;

		double IUnitData.AttackIncrement => 2;

		public UnitType[] SpecTypes => new[] { UnitType.Striker, UnitType.Dreadnought };
	}
}
