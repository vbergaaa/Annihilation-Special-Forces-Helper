using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Colossus
	// WeaponData: ThermalLances
	// EffectData: ThermalLancesMU

	public class Colossus : IUnitData
	{
		public UnitType Type => UnitType.Colossus;

		double IUnitData.BaseAttack =>20;

		double IUnitData.BaseAttackSpeed => 1.5;

		double IUnitData.AttackCount => 2;

		double IUnitData.BaseHealth => 325;

		double IUnitData.BaseHealthArmor => 7;

		double IUnitData.BaseHealthRegen => 7;

		double IUnitData.BaseShields => 400;

		double IUnitData.BaseShieldsArmor => 7;

		double IUnitData.BaseShieldsRegen => 7;

		double IUnitData.HealthIncrement => 7;

		double IUnitData.HealthRegenIncrement => 0.5;

		double IUnitData.ShieldIncrement => 12;

		double IUnitData.ShieldRegenIncrement => 1;

		double IUnitData.HealthArmorIncrement => 0.7;

		double IUnitData.ShieldArmorIncrement => 0.7;

		double IUnitData.AttackIncrement => 2.2;

		public UnitType[] SpecTypes => new[] { UnitType.Striker, UnitType.Dreadnought };

		public UnitType BasicType => UnitType.Dragoon;

		public IEnumerable<UnitRecepePiece> Recepe { get { yield return new UnitRecepePiece(UnitType.Reaver, 3, UnitRankType.S, 2); } }

		public Evolution Evolution => Evolution.DNA2;
	}
}
