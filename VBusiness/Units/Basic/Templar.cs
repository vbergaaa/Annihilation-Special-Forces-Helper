using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Unit: HighTemplar
	// Weapon effect: HighTemplarWeaponDamage
	// Ability effect: PsiStormDamage && PsiStormDamageInitial

	public class Templar : IUnitData
	{
		double IUnitData.BaseHealth => 400;

		double IUnitData.BaseHealthArmor => 5;

		double IUnitData.BaseHealthRegen => 2;

		double IUnitData.BaseShields => 400;

		double IUnitData.BaseShieldsArmor => 5;

		double IUnitData.BaseShieldsRegen => 3;

		public UnitType Type => UnitType.Templar;

		double IUnitData.HealthIncrement => 6;

		double IUnitData.HealthRegenIncrement => 0.5;

		double IUnitData.ShieldIncrement => 6;

		double IUnitData.ShieldRegenIncrement => 0.5;

		double IUnitData.HealthArmorIncrement => 0.55;

		double IUnitData.ShieldArmorIncrement => 0.55;

		public UnitType[] SpecTypes => new[] { UnitType.Templar };

		public UnitType BasicType => Type;

		public IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetEmptyRecipe();

		public Evolution Evolution => Evolution.Basic;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new TemplarBasicWeapon();
			}
		}
	}
}
