﻿using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData name = Sentry
	// ASF weapon name = Healing Beam?

	public class ShieldBattery : IUnitData
	{
		public UnitType Type => UnitType.ShieldBattery;

		double IUnitData.BaseHealth => 50;

		double IUnitData.BaseHealthArmor => 2;

		double IUnitData.BaseHealthRegen => 2;

		double IUnitData.BaseShields => 100;

		double IUnitData.BaseShieldsArmor => 2;

		double IUnitData.BaseShieldsRegen => 5;

		double IUnitData.HealthIncrement => 4;

		double IUnitData.HealthRegenIncrement => 0.1992;

		double IUnitData.ShieldIncrement => 6;

		double IUnitData.ShieldRegenIncrement => 0.8007;

		double IUnitData.HealthArmorIncrement => 0.3;

		double IUnitData.ShieldArmorIncrement => 0.3;

		public UnitType[] SpecTypes => new[] { UnitType.ShieldBattery };

		public UnitType BasicType => Type;

		public IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetEmptyRecipe();

		public Evolution Evolution => Evolution.Basic;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new ShieldBatteryBasicWeapon();
			}
		}
	}
}
