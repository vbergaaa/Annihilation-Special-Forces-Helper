using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkTemplarTaldarim
	// WeaponData: DarkTemplarTaldarmin
	// EffectData: BAScytheDamage

	public class BloodAvenger : IUnitData
	{
		public UnitType Type => UnitType.BloodAvenger;

		double IUnitData.BaseHealth => 22;

		double IUnitData.BaseHealthArmor => 5;

		double IUnitData.BaseHealthRegen => 7;

		double IUnitData.BaseShields => 475;

		double IUnitData.BaseShieldsArmor => 5;

		double IUnitData.BaseShieldsRegen => 7;

		double IUnitData.HealthIncrement => 2;

		double IUnitData.HealthRegenIncrement => 0.5;

		double IUnitData.ShieldIncrement => 15;

		double IUnitData.ShieldRegenIncrement => 2;

		double IUnitData.HealthArmorIncrement => 0.6;

		double IUnitData.ShieldArmorIncrement => 0.6;

		public UnitType[] SpecTypes => new[] { UnitType.DarkShadow };

		public UnitType BasicType => UnitType.DarkShadow;

		public IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA2Recipe(UnitType.DarkAvenger);

		public Evolution Evolution => Evolution.DNA2;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new BloodAvengerBasicWeapon();
			}
		}
	}
}
