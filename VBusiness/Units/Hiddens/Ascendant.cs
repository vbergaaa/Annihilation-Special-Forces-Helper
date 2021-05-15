using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: HighTemplarTaldarmin
	// WeaponData: AscendantWeapon
	// EffectData: AscendantWeaponDamage

	public class Ascendant : IUnitData
	{
		public UnitType Type => UnitType.Ascendant;

		double IUnitData.BaseAttack =>25;

		double IUnitData.BaseAttackSpeed => 1.4;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 500;

		double IUnitData.BaseHealthArmor => 10;

		double IUnitData.BaseHealthRegen => 2;

		double IUnitData.BaseShields => 1000;

		double IUnitData.BaseShieldsArmor => 10;

		double IUnitData.BaseShieldsRegen => 10;

		double IUnitData.HealthIncrement => 10;

		double IUnitData.HealthRegenIncrement => 0.3007;

		double IUnitData.ShieldIncrement => 20;

		double IUnitData.ShieldRegenIncrement => 1;

		double IUnitData.HealthArmorIncrement => 0.9;

		double IUnitData.ShieldArmorIncrement => 0.9;

		double IUnitData.AttackIncrement => 2;

		public UnitType[] SpecTypes => new[] { UnitType.DarkShadow, UnitType.Templar, UnitType.ShieldBattery };

		public UnitType BasicType => UnitType.Templar;

		public IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.Archon, 7, UnitRankType.X, 1);
				yield return new UnitRecepePiece(UnitType.HighTemplar, 5, UnitRankType.SS, 2);
				yield return new UnitRecepePiece(UnitType.DarkShieldBattery, 3, UnitRankType.SS, 2);
			}
		}

		public Evolution Evolution => Evolution.DNA2;
	}
}
