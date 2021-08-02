using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: BladeDancer
	// WeaponData: BladeDance

	public class BladeDancer : IUnitData
	{
		public UnitType Type => UnitType.BladeDancer;

		double IUnitData.BaseHealth => 500;

		double IUnitData.BaseHealthArmor => 8;

		double IUnitData.BaseHealthRegen => 9;

		double IUnitData.BaseShields => 750;

		double IUnitData.BaseShieldsArmor => 8;

		double IUnitData.BaseShieldsRegen => 15;

		double IUnitData.HealthIncrement => 11;

		double IUnitData.HealthRegenIncrement => 1.1992;

		double IUnitData.ShieldIncrement => 18;

		double IUnitData.ShieldRegenIncrement => 1.3984;

		double IUnitData.HealthArmorIncrement => 0.9;

		double IUnitData.ShieldArmorIncrement => 0.9;

		public UnitType[] SpecTypes => new[] { UnitType.WarpLord, UnitType.LightAdept, UnitType.ShieldBattery };

		public UnitType BasicType => UnitType.LightAdept;

		public IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.StonePrisoner, 5, UnitRankType.SS, 1);
				yield return new UnitRecepePiece(UnitType.LightAdept, 3, UnitRankType.S, 5);
			}
		}

		public Evolution Evolution => Evolution.DNA2;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new BladeDancerBasicWeapon();
			}
		}
	}
}
