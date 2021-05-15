using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: HighArchonTemplar
	// WeaponData: HighTemplarWeapon

	public class HighTemplar : IUnitData
	{
		public UnitType Type => UnitType.HighTemplar;

		double IUnitData.BaseAttack =>20;

		double IUnitData.BaseAttackSpeed => 1.5;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 650;

		double IUnitData.BaseHealthArmor => 7;

		double IUnitData.BaseHealthRegen => 3;

		double IUnitData.BaseShields => 650;

		double IUnitData.BaseShieldsArmor => 7;

		double IUnitData.BaseShieldsRegen => 6;

		double IUnitData.HealthIncrement => 8;

		double IUnitData.HealthRegenIncrement => 0.6992;

		double IUnitData.ShieldIncrement => 8;

		double IUnitData.ShieldRegenIncrement => 0.6992;

		double IUnitData.HealthArmorIncrement => 0.65;

		double IUnitData.ShieldArmorIncrement => 0.65;

		double IUnitData.AttackIncrement => 1;

		public UnitType[] SpecTypes => new[] { UnitType.Templar };

		public UnitType BasicType => UnitType.Templar;

		public IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA1Recipe(BasicType);

		public Evolution Evolution => Evolution.DNA1;
	}
}
