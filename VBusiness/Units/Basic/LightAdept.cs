using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Unit: Adept
	// Weapon: Adept
	// Effect: AdeptDamage
	public class LightAdept : IUnitData
	{
		double IUnitData.BaseHealth => 125;

		double IUnitData.BaseHealthArmor => 3;

		double IUnitData.BaseHealthRegen => 3;

		double IUnitData.BaseShields => 175;

		double IUnitData.BaseShieldsArmor => 3;

		double IUnitData.BaseShieldsRegen => 5;

		public UnitType Type => UnitType.LightAdept;

		double IUnitData.HealthIncrement => 5;

		double IUnitData.HealthRegenIncrement => 0.3007;

		double IUnitData.ShieldIncrement => 7;

		double IUnitData.ShieldRegenIncrement => 1;

		double IUnitData.HealthArmorIncrement => 0.45;

		double IUnitData.ShieldArmorIncrement => 0.45;

		public UnitType[] SpecTypes => new[] { UnitType.LightAdept };

		public UnitType BasicType => Type;

		public IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetEmptyRecipe();

		public Evolution Evolution => Evolution.Basic;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new LightAdeptBasicWeapon();
			}
		}
	}
}
