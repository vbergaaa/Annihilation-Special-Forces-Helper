using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: MasterDance

	public class BladeMaster : IUnitData
	{
		public UnitType Type => UnitType.BladeMaster;

		double IUnitData.BaseHealth => 700;

		double IUnitData.BaseHealthArmor => 12;

		double IUnitData.BaseHealthRegen => 12;

		double IUnitData.BaseShields => 1000;

		double IUnitData.BaseShieldsArmor => 12;

		double IUnitData.BaseShieldsRegen => 22;

		double IUnitData.HealthIncrement => 16;

		double IUnitData.HealthRegenIncrement => 1.3984;

		double IUnitData.ShieldIncrement => 24;

		double IUnitData.ShieldRegenIncrement => 2;

		double IUnitData.HealthArmorIncrement => 1.1;

		double IUnitData.ShieldArmorIncrement => 1.1;

		public UnitType[] SpecTypes => new[] { UnitType.WarpLord, UnitType.ShieldBattery, UnitType.LightAdept };

		public UnitType BasicType => UnitType.LightAdept;

		public IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.SplitterAdept, 3, UnitRankType.SS, 1);
				yield return new UnitRecepePiece(UnitType.BladeDancer, 7, UnitRankType.X, 1);
				yield return new UnitRecepePiece(UnitType.LightAdept, 10, UnitRankType.SSS, 1);
			}
		}

		public Evolution Evolution => Evolution.Hero;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new BladeMasterBasicWeapon();
				yield return new BladeMasterFusedAssault();
			}
		}
	}
}
