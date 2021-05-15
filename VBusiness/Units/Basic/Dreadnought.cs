using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Unit: Immortal
	// Main Effect: PhaseDisruptors
	// Splash Effect: ImmortalSplashDamage

	public class Dreadnought : IUnitData
	{
		double IUnitData.BaseAttack => 25;

		double IUnitData.BaseAttackSpeed => 2;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 300;

		double IUnitData.BaseHealthArmor => 6;

		double IUnitData.BaseHealthRegen => 5;

		double IUnitData.BaseShields => 450;

		double IUnitData.BaseShieldsArmor => 6;

		double IUnitData.BaseShieldsRegen => 5;

		public UnitType Type => UnitType.Dreadnought;

		double IUnitData.HealthIncrement => 7;

		double IUnitData.HealthRegenIncrement => 0.5;

		double IUnitData.ShieldIncrement => 18;

		double IUnitData.ShieldRegenIncrement => 1.1992;

		double IUnitData.HealthArmorIncrement => 0.45;

		double IUnitData.ShieldArmorIncrement => 0.45;

		double IUnitData.AttackIncrement => 1.5;

		public UnitType[] SpecTypes => new[] { UnitType.Dreadnought };

		public UnitType BasicType => Type;

		public IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetEmptyRecipe();

		public Evolution Evolution => Evolution.Basic;
	}
}
