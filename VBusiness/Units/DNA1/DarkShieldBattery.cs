using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	//UnitData: Monitor
	//EffectData: HealingBeam2

	public class DarkShieldBattery : IUnitData
	{
		public UnitType Type => UnitType.DarkShieldBattery;

		double IUnitData.BaseAttack =>-7;

		double IUnitData.BaseAttackSpeed => 1.4;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 75;

		double IUnitData.BaseHealthArmor => 3;

		double IUnitData.BaseHealthRegen => 3;

		double IUnitData.BaseShields => 150;

		double IUnitData.BaseShieldsArmor => 3;

		double IUnitData.BaseShieldsRegen => 7;

		double IUnitData.HealthIncrement => 6;

		double IUnitData.HealthRegenIncrement => 0.3007;

		double IUnitData.ShieldIncrement => 9;

		double IUnitData.ShieldRegenIncrement => 1;

		double IUnitData.HealthArmorIncrement => 0.45;

		double IUnitData.ShieldArmorIncrement => 0.45;

		double IUnitData.AttackIncrement => -0.35;

		public UnitType[] SpecTypes => new[] { UnitType.ShieldBattery };

		public UnitType BasicType => UnitType.ShieldBattery;

		public IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA1Recipe(BasicType);

		public Evolution Evolution => Evolution.DNA1;
	}
}
