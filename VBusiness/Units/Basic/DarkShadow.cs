using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Unit: DarkTemplar
	// Weapon: WarpBlades
	// Effect: WarpBlades
	public class DarkShadow : IUnitData
	{
		double IUnitData.BaseAttack => 20;

		double IUnitData.BaseAttackSpeed => 1;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 10;

		double IUnitData.BaseHealthArmor => 3;

		double IUnitData.BaseHealthRegen => 5;

		double IUnitData.BaseShields => 250;

		double IUnitData.BaseShieldsArmor => 3;

		double IUnitData.BaseShieldsRegen => 5;

		public UnitType Type => UnitType.DarkShadow;

		double IUnitData.HealthIncrement => 1;

		double IUnitData.HealthRegenIncrement => 0.1992;

		double IUnitData.ShieldIncrement => 10;

		double IUnitData.ShieldRegenIncrement => 1;

		double IUnitData.HealthArmorIncrement => 0.3;

		double IUnitData.ShieldArmorIncrement => 0.3;

		double IUnitData.AttackIncrement => 1.5;

		public UnitType[] SpecTypes => new[] { UnitType.DarkShadow };

		public UnitType BasicType => Type;

		public IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetEmptyRecipe();

		public Evolution Evolution => Evolution.Basic;
	}
}
