using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Prisoner
	// WeaponData: PrisonerBlades
	// EffectData: WarpBladesDamage2

	public class Prisoner : IUnitData
	{
		public UnitType Type => UnitType.Prisoner;

		double IUnitData.BaseAttack =>15;

		double IUnitData.BaseAttackSpeed => 1.4;

		double IUnitData.AttackCount => 2;

		double IUnitData.BaseHealth => 275;

		double IUnitData.BaseHealthArmor => 4;

		double IUnitData.BaseHealthRegen => 8;

		double IUnitData.BaseShields => 450;

		double IUnitData.BaseShieldsArmor => 4;

		double IUnitData.BaseShieldsRegen => 6;

		double IUnitData.HealthIncrement => 6;

		double IUnitData.HealthRegenIncrement => 0.8515;

		double IUnitData.ShieldIncrement => 12;

		double IUnitData.ShieldRegenIncrement => 0.8984;

		double IUnitData.HealthArmorIncrement => 0.65;

		double IUnitData.ShieldArmorIncrement => 0.65;

		double IUnitData.AttackIncrement => 1.5;

		public UnitType[] SpecTypes => new[] { UnitType.WarpLord, UnitType.ShieldBattery };

		public UnitType BasicType => UnitType.WarpLord;

		public IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.DarkWarpLord, 3, UnitRankType.None, 2);
				yield return new UnitRecepePiece(UnitType.ShieldBattery, 3, UnitRankType.None, 1);
				yield return new UnitRecepePiece(UnitType.WarpLord, 1, UnitRankType.None, 5);
			}
		}

		public Evolution Evolution => Evolution.DNA1;
	}
}
