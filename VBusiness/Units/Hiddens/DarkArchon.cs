using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkArchonR
	// WeaponData: DarkShockwave
	// EffectData: PsionicShockwaveDamage2

	public class DarkArchon : IUnitData
	{
		public UnitType Type => UnitType.DarkArchon;

		double IUnitData.BaseAttack =>30;

		double IUnitData.BaseAttackSpeed => 1.4;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 20;

		double IUnitData.BaseHealthArmor => 10;

		double IUnitData.BaseHealthRegen => 2;

		double IUnitData.BaseShields => 1000;

		double IUnitData.BaseShieldsArmor => 10;

		double IUnitData.BaseShieldsRegen => 6;

		double IUnitData.HealthIncrement => 2;

		double IUnitData.HealthRegenIncrement => 1;

		double IUnitData.ShieldIncrement => 33;

		double IUnitData.ShieldRegenIncrement => 1.6992;

		double IUnitData.HealthArmorIncrement => 0.95;

		double IUnitData.ShieldArmorIncrement => 0.95;

		double IUnitData.AttackIncrement => 2.5;

		public UnitType[] SpecTypes => new[] { UnitType.DarkShadow, UnitType.Templar };

		public UnitType BasicType => UnitType.DarkShadow;

		public IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.Archon, 5, UnitRankType.XX, 1);
				yield return new UnitRecepePiece(UnitType.DarkAvenger, 3, UnitRankType.SS, 4);
			}
		}

		public Evolution Evolution => Evolution.DNA2;
	}
}
