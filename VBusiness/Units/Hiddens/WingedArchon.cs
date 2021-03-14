using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkArchon
	// WeaponData: WingedTorrent
	// EffectData: WingedArchonWeaponDamage

	public class WingedArchon : IUnitData
	{
		public UnitType Type => UnitType.WingedArchon;

		double IUnitData.BaseAttack =>65;

		double IUnitData.BaseAttackSpeed => 1.1;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 60;

		double IUnitData.BaseHealthArmor => 15;

		double IUnitData.BaseHealthRegen => 4;

		double IUnitData.BaseShields => 1600;

		double IUnitData.BaseShieldsArmor => 15;

		double IUnitData.BaseShieldsRegen => 10;

		double IUnitData.HealthIncrement => 15;

		double IUnitData.HealthRegenIncrement => 1.8007;

		double IUnitData.ShieldIncrement => 40;

		double IUnitData.ShieldRegenIncrement => 3;

		double IUnitData.HealthArmorIncrement => 1.3;

		double IUnitData.ShieldArmorIncrement => 1.3;

		double IUnitData.AttackIncrement => 4.2;

		public UnitType[] SpecTypes => new[] { UnitType.DarkShadow, UnitType.Templar, UnitType.ShieldBattery, UnitType.WarpLord };
	}
}
