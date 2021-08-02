using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	//UnitData = DarkProbe
	//WeaponData = DarkParticleBeam
	public class DarkProbe : IUnitData
	{
		public UnitType Type => UnitType.DarkProbe;

		double IUnitData.BaseHealth => 50;

		double IUnitData.BaseHealthArmor => 4;

		double IUnitData.BaseHealthRegen => 0;

		double IUnitData.BaseShields => 100;

		double IUnitData.BaseShieldsArmor => 4;

		double IUnitData.BaseShieldsRegen => 5;

		double IUnitData.HealthIncrement => 5;

		double IUnitData.HealthRegenIncrement => 0.3007;

		double IUnitData.ShieldIncrement => 8;

		double IUnitData.ShieldRegenIncrement => 0.5;

		double IUnitData.HealthArmorIncrement => 0.3;

		double IUnitData.ShieldArmorIncrement => 0.3;

		public UnitType[] SpecTypes => new UnitType[0];

		public UnitType BasicType => UnitType.Probe;

		public IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA1Recipe(BasicType);

		public Evolution Evolution => Evolution.DNA1;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new DarkProbeBasicWeapon();
			}
		}
	}
}
