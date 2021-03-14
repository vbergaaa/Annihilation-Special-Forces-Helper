using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ZealotShakuras
	// Weapon: WarpBlades
	// Effect: WarpBladesDamage

	public class DarkWarpLord : IUnitData
	{
		public UnitType Type => UnitType.DarkWarpLord;

		double IUnitData.BaseAttack =>15;

		double IUnitData.BaseAttackSpeed => 1.2; // Doesn't match weapon data for WarpBlades, tested in game

		double IUnitData.AttackCount => 2;

		double IUnitData.BaseHealth => 150;

		double IUnitData.BaseHealthArmor => 3;

		double IUnitData.BaseHealthRegen => 3;

		double IUnitData.BaseShields => 200;

		double IUnitData.BaseShieldsArmor => 3;

		double IUnitData.BaseShieldsRegen => 5;

		double IUnitData.HealthIncrement => 5;

		double IUnitData.HealthRegenIncrement => 0.25;

		double IUnitData.ShieldIncrement => 10;

		double IUnitData.ShieldRegenIncrement => 0.8007;

		double IUnitData.HealthArmorIncrement => 0.45;

		double IUnitData.ShieldArmorIncrement => 0.45;

		double IUnitData.AttackIncrement => 0.8;

		public UnitType[] SpecTypes => new[] { UnitType.WarpLord };
	}
}
