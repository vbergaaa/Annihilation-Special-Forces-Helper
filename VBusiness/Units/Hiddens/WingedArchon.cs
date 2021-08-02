using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkArchon
	// WeaponData: WingedTorrent
	// EffectData: WingedArchonWeaponDamage

	public class WingedArchon : IUnitData
	{
		public UnitType Type => UnitType.WingedArchon;

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

		public UnitType[] SpecTypes => new[] { UnitType.DarkShadow, UnitType.Templar, UnitType.ShieldBattery, UnitType.WarpLord };

		public UnitType BasicType => UnitType.DarkShadow;

		public IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.CrimsonArchon, 10, UnitRankType.XDZ, 1);
				yield return new UnitRecepePiece(UnitType.StonePrisoner, 7, UnitRankType.X, 1);
				yield return new UnitRecepePiece(UnitType.DarkArchon, 6, UnitRankType.XD, 2);
			}
		}

		public Evolution Evolution => Evolution.SuperHero;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new WingedArchonBasicWeapon();
			}
		}
	}
}
