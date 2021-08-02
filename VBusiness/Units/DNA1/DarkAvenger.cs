﻿using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkTemplarAiur
	// WeaponData: AvengerWeapon

	public class DarkAvenger : IUnitData
	{
		public UnitType Type => UnitType.DarkAvenger;

		double IUnitData.BaseHealth => 15;

		double IUnitData.BaseHealthArmor => 4;

		double IUnitData.BaseHealthRegen => 6;

		double IUnitData.BaseShields => 325;

		double IUnitData.BaseShieldsArmor => 4;

		double IUnitData.BaseShieldsRegen => 6;

		double IUnitData.HealthIncrement => 1.5;

		double IUnitData.HealthRegenIncrement => 0.3984;

		double IUnitData.ShieldIncrement => 13;

		double IUnitData.ShieldRegenIncrement => 1.5;

		double IUnitData.HealthArmorIncrement => 0.4;

		double IUnitData.ShieldArmorIncrement => 0.4;

		public UnitType[] SpecTypes => new[] { UnitType.DarkShadow };

		public UnitType BasicType => UnitType.DarkShadow;

		public IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA1Recipe(BasicType);

		public Evolution Evolution => Evolution.DNA1;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new DarkAvengerBasicWeapon();
			}
		}
	}
}
