using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData name = Probe
	// WeaponData name = ParticleBeam

	public class Probe : IUnitData
	{
		public UnitType Type => UnitType.Probe;

		double IUnitData.BaseAttack => 5;

		double IUnitData.BaseAttackSpeed => 1.5;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 35;

		double IUnitData.BaseHealthArmor => 2;

		double IUnitData.BaseHealthRegen => 0.3007;

		double IUnitData.BaseShields => 50;

		double IUnitData.BaseShieldsArmor => 2;

		double IUnitData.BaseShieldsRegen => 3;

		double IUnitData.HealthIncrement => 3;

		double IUnitData.HealthRegenIncrement => 0.1992;

		double IUnitData.ShieldIncrement => 5;

		double IUnitData.ShieldRegenIncrement => 0.3007;

		double IUnitData.HealthArmorIncrement => 0.2;

		double IUnitData.ShieldArmorIncrement => 0.2;

		double IUnitData.AttackIncrement => 0.5;

		public UnitType[] SpecTypes => new UnitType[0];

		public UnitType BasicType => Type;

		public IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetEmptyRecipe();

		public Evolution Evolution => Evolution.Basic;
	}
}
