using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ColossusTaldarim
	// WeaponData: ColossusTaldarimChargedBeam
	// EffectData: ColossusTaldarminDamage

	public class WrathWalker : IUnitData
	{
		public UnitType Type => UnitType.WrathWalker;

		double IUnitData.BaseAttack =>35;

		double IUnitData.BaseAttackSpeed => 1.2;

		double IUnitData.AttackCount => 1; // 3, but on 3 separate targets

		double IUnitData.BaseHealth => 325;

		double IUnitData.BaseHealthArmor => 7;

		double IUnitData.BaseHealthRegen => 7;

		double IUnitData.BaseShields => 400;

		double IUnitData.BaseShieldsArmor => 7;

		double IUnitData.BaseShieldsRegen => 7;

		double IUnitData.HealthIncrement => 7;

		double IUnitData.HealthRegenIncrement => 0.5;

		double IUnitData.ShieldIncrement => 12;

		double IUnitData.ShieldRegenIncrement => 1;

		double IUnitData.HealthArmorIncrement => 0.7;

		double IUnitData.ShieldArmorIncrement => 0.7;

		double IUnitData.AttackIncrement => 2;

		public UnitType[] SpecTypes => new[] { UnitType.Striker, UnitType.Dreadnought };
	}
}
