using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Reaver
	// EffectData: ScarabExplodeTargetDamage

	public class Reaver : IUnitData
	{
		public UnitType Type => UnitType.Reaver;

		double IUnitData.BaseHealth => 250;

		double IUnitData.BaseHealthArmor => 6;

		double IUnitData.BaseHealthRegen => 5;

		double IUnitData.BaseShields => 325;

		double IUnitData.BaseShieldsArmor => 6;

		double IUnitData.BaseShieldsRegen => 5;

		double IUnitData.HealthIncrement => 5;

		double IUnitData.HealthRegenIncrement => 0.3007;

		double IUnitData.ShieldIncrement => 10;

		double IUnitData.ShieldRegenIncrement => 0.8007;

		double IUnitData.HealthArmorIncrement => 0.6;

		double IUnitData.ShieldArmorIncrement => 0.6;

		public UnitType[] SpecTypes => new[] { UnitType.Striker, UnitType.Dreadnought };

		public UnitType BasicType => UnitType.Dragoon;

		public IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.Dragoon, 3, UnitRankType.A, 1);
				yield return new UnitRecepePiece(UnitType.Dreadnought, 0, UnitRankType.None, 3);
			}
		}

		public Evolution Evolution => Evolution.DNA1;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new ReaverBasicWeapon();
			}
		}
	}
}
