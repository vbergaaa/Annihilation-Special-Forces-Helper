using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: StalkerPurifier
	// EffectData: MirrorEntropyLanceDamage2

	public class ParadoxStriker : IUnitData
	{
		public UnitType Type => UnitType.ParadoxStriker;

		double IUnitData.BaseHealth => 320;

		double IUnitData.BaseHealthArmor => 10;

		double IUnitData.BaseHealthRegen => 3;

		double IUnitData.BaseShields => 425;

		double IUnitData.BaseShieldsArmor => 10;

		double IUnitData.BaseShieldsRegen => 5;

		double IUnitData.HealthIncrement => 12;

		double IUnitData.HealthRegenIncrement => 0.6015;

		double IUnitData.HealthArmorIncrement => 0.75;

		double IUnitData.ShieldIncrement => 15;

		double IUnitData.ShieldRegenIncrement => 0.8984;

		double IUnitData.ShieldArmorIncrement => 0.75;

		public UnitType[] SpecTypes => new[] { UnitType.Striker };

		public UnitType BasicType => UnitType.Striker;

		public IEnumerable<UnitRecepePiece> Recepe { get { yield return new UnitRecepePiece(UnitType.MirrorStriker, 10, UnitRankType.None, 1); } }

		public Evolution Evolution => Evolution.Hero;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new ParadoxStrikerBasicWeapon();
			}
		}
	}
}
