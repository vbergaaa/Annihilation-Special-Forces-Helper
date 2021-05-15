using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Loadouts;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	/// Unit: Zealot
	/// Weapon: Psi Blades
	public class WarpLord : IUnitData
	{
		double IUnitData.BaseAttack => 11;

		double IUnitData.BaseAttackSpeed => 1.5;

		double IUnitData.AttackCount => 2;

		double IUnitData.BaseHealth => 100;

		double IUnitData.BaseHealthArmor => 2;

		double IUnitData.BaseHealthRegen => 2;

		double IUnitData.BaseShields => 150;

		double IUnitData.BaseShieldsArmor => 2;

		double IUnitData.BaseShieldsRegen => 3;

		public UnitType Type => UnitType.WarpLord;

		double IUnitData.HealthIncrement => 4;

		double IUnitData.HealthRegenIncrement => 0.1992;

		double IUnitData.ShieldIncrement => 8;

		double IUnitData.ShieldRegenIncrement => 0.5;

		double IUnitData.HealthArmorIncrement => 0.35;

		double IUnitData.ShieldArmorIncrement => 0.35;

		double IUnitData.AttackIncrement => 0.6;

		public UnitType[] SpecTypes => new[] { UnitType.WarpLord };

		public UnitType BasicType => UnitType.WarpLord;

		public IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetEmptyRecipe();

		public Evolution Evolution => Evolution.Basic;
	}
}
