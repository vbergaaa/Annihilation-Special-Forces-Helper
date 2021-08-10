﻿using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ZealotPurifier
	// WeaponData: TerminatorBlades

	public class TerminatorWarpLord : IUnitData
	{
		public UnitType Type => UnitType.TerminatorWarpLord;

		double IUnitData.BaseHealth => 400;

		double IUnitData.BaseHealthArmor => 6;

		double IUnitData.BaseHealthRegen => 6;

		double IUnitData.BaseShields => 625;

		double IUnitData.BaseShieldsArmor => 6;

		double IUnitData.BaseShieldsRegen => 10;

		double IUnitData.HealthIncrement => 10;

		double IUnitData.HealthRegenIncrement => 1;

		double IUnitData.ShieldIncrement => 17;

		double IUnitData.ShieldRegenIncrement => 1.3007;

		double IUnitData.HealthArmorIncrement => 0.8;

		double IUnitData.ShieldArmorIncrement => 0.8;

		public UnitType[] SpecTypes => new[] { UnitType.WarpLord };

		public UnitType BasicType => UnitType.WarpLord;

		public IEnumerable<UnitRecepePiece> Recepe { get { yield return new UnitRecepePiece(UnitType.BerserkerWarpLord, 10, UnitRankType.None, 1); } }

		public Evolution Evolution => Evolution.Hero;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new TerminatorWarpLordBasicWeapon();
				yield return new TerminatorWarpLordBasicAtkAOE();
			}
		}
	}
}
