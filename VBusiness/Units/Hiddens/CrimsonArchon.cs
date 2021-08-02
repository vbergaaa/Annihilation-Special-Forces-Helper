using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkArchon
	// WeaponData: DarkArchonWeapon
	// EffectData: DarkArchonWeaponDamage

	public class CrimsonArchon : IUnitData
	{
		public UnitType Type => UnitType.CrimsonArchon;

		double IUnitData.BaseHealth => 30;

		double IUnitData.BaseHealthArmor => 12;

		double IUnitData.BaseHealthRegen => 3;

		double IUnitData.BaseShields => 1250;

		double IUnitData.BaseShieldsArmor => 12;

		double IUnitData.BaseShieldsRegen => 8;

		double IUnitData.HealthIncrement => 3.5;

		double IUnitData.HealthRegenIncrement => 0.4492;

		double IUnitData.ShieldIncrement => 37;

		double IUnitData.ShieldRegenIncrement => 2.3007;

		double IUnitData.HealthArmorIncrement => 1.1;

		double IUnitData.ShieldArmorIncrement => 1.1;

		public UnitType[] SpecTypes => new[] { UnitType.DarkShadow, UnitType.Templar, UnitType.ShieldBattery };

		public UnitType BasicType => UnitType.DarkShadow;

		public IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.Ascendant, 10, UnitRankType.X, 1);
				yield return new UnitRecepePiece(UnitType.BloodAvenger, 5, UnitRankType.X, 1);
				yield return new UnitRecepePiece(UnitType.DarkArchon, 10, UnitRankType.SXD, 1);
			}
		}

		public Evolution Evolution => Evolution.Hero;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new CrimsonArchonBasicWeapon();
			}
		}
	}
}
