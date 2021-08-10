using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ZealotAiur
	// WeaponData: SolariteReaper

	public class BerserkerWarpLord : IUnitData
	{
		public UnitType Type => UnitType.BerserkerWarpLord;

		double IUnitData.BaseHealth => 225;

		double IUnitData.BaseHealthArmor => 5;

		double IUnitData.BaseHealthRegen => 4;

		double IUnitData.BaseShields => 320;

		double IUnitData.BaseShieldsArmor => 5;

		double IUnitData.BaseShieldsRegen => 4;

		double IUnitData.HealthIncrement => 7;

		double IUnitData.HealthRegenIncrement => 0.3984;

		double IUnitData.ShieldIncrement => 13;

		double IUnitData.ShieldRegenIncrement => 1;

		double IUnitData.HealthArmorIncrement => 0.6;

		double IUnitData.ShieldArmorIncrement => 0.6;

		public UnitType[] SpecTypes => new[] { UnitType.WarpLord };

		public UnitType BasicType => UnitType.WarpLord;

		public IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA2Recipe(UnitType.DarkWarpLord);

		public Evolution Evolution => Evolution.DNA2;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new BerserkerWarpLordBasicWeapon();
				yield return new BerserkerWarpLordBasicAttackAOE();
			}
		}
	}
}
