using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ImmortalAiur
	// WeaponData: UnstableDisruptors
	// EffectData: ImmortalSplashSet2

	public class UnstableDreadnought : IUnitData
	{
		public UnitType Type => UnitType.UnstableDreadnought;

		double IUnitData.BaseHealth => 350;

		double IUnitData.BaseHealthArmor => 7;

		double IUnitData.BaseHealthRegen => 7;

		double IUnitData.BaseShields => 500;

		double IUnitData.BaseShieldsArmor => 7;

		double IUnitData.BaseShieldsRegen => 7;

		double IUnitData.HealthIncrement => 9;

		double IUnitData.HealthRegenIncrement => 0.601;

		double IUnitData.ShieldIncrement => 22;

		double IUnitData.ShieldRegenIncrement => 1.5;

		double IUnitData.HealthArmorIncrement => 0.55;

		double IUnitData.ShieldArmorIncrement => 0.55;

		public UnitType[] SpecTypes => new[] { UnitType.Dreadnought };

		public UnitType BasicType => UnitType.Dreadnought;

		public IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA1Recipe(BasicType);

		public Evolution Evolution => Evolution.DNA1;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new UnstableDreadnoughtBasicWeapon();
			}
		}
	}
}
