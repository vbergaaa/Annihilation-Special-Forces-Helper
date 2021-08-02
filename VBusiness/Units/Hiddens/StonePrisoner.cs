using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: StoneZealot
	// EffectData: EyeBeamsGround (NOT StoneZealot)

	public class StonePrisoner : IUnitData
	{
		public UnitType Type => UnitType.StonePrisoner;

		double IUnitData.BaseHealth => 600;

		double IUnitData.BaseHealthArmor => 6;

		double IUnitData.BaseHealthRegen => 10;

		double IUnitData.BaseShields => 0;

		double IUnitData.BaseShieldsArmor => 0;

		double IUnitData.BaseShieldsRegen => 0;

		double IUnitData.HealthIncrement => 12;

		double IUnitData.HealthRegenIncrement => 1.1015;

		double IUnitData.ShieldIncrement => 0;

		double IUnitData.ShieldRegenIncrement => 0;

		double IUnitData.HealthArmorIncrement => 0.7;

		double IUnitData.ShieldArmorIncrement => 0;

		public UnitType[] SpecTypes => new[] { UnitType.WarpLord, UnitType.ShieldBattery };

		public UnitType BasicType => UnitType.WarpLord;

		public IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.BerserkerWarpLord, 5, UnitRankType.S, 1);
				yield return new UnitRecepePiece(UnitType.Prisoner, 5, UnitRankType.S, 1);
			}
		}

		public Evolution Evolution => Evolution.DNA2;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new StonePrisonerBasicWeapon();
			}
		}
	}
}
