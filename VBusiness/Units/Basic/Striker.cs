using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Stalker
	// ParticleDisruptor / ParticleDisruptorU

	public class Striker : IUnitData
	{
		double IUnitData.BaseHealth => 125;

		double IUnitData.BaseHealthArmor => 3;

		double IUnitData.BaseHealthRegen => 1;

		double IUnitData.BaseShields => 160;

		double IUnitData.BaseShieldsArmor => 3;

		double IUnitData.BaseShieldsRegen => 2;

		public UnitType Type => UnitType.Striker;

		double IUnitData.HealthIncrement => 4;

		double IUnitData.HealthRegenIncrement => 0.3007;

		double IUnitData.ShieldIncrement => 6;

		double IUnitData.ShieldRegenIncrement => 0.5;

		double IUnitData.HealthArmorIncrement => 0.4;

		double IUnitData.ShieldArmorIncrement => 0.4;

		public UnitType[] SpecTypes => new[] { UnitType.Striker };

		public UnitType BasicType => Type;

		public IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetEmptyRecipe();

		public Evolution Evolution => Evolution.Basic;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new StrikerBasicWeapon();
			}
		}
	}
}
