using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Archon
	// WeaponData: PsionicShockwave
	// EffectData: PsionicShockwaveDamage

	public class Archon : IUnitData
	{
		public UnitType Type => UnitType.Archon;

		double IUnitData.BaseAttack =>25;

		double IUnitData.BaseAttackSpeed => 1.4;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 10;

		double IUnitData.BaseHealthArmor => 7;

		double IUnitData.BaseHealthRegen => 1;

		double IUnitData.BaseShields => 700;

		double IUnitData.BaseShieldsArmor => 7;

		double IUnitData.BaseShieldsRegen => 4;

		double IUnitData.HealthIncrement => 1;

		double IUnitData.HealthRegenIncrement => 0.1992;

		double IUnitData.ShieldIncrement => 27;

		double IUnitData.ShieldRegenIncrement => 1.3007;

		double IUnitData.HealthArmorIncrement => 0.7;

		double IUnitData.ShieldArmorIncrement => 0.7;

		double IUnitData.AttackIncrement => 1.3;

		public UnitType[] SpecTypes => new[] { UnitType.DarkShadow, UnitType.Templar };

		public UnitType BasicType => UnitType.DarkShadow;

		public IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.Templar, 1, UnitRankType.SSS, 1);
				yield return new UnitRecepePiece(UnitType.DarkShadow, 3, UnitRankType.SS, 4);
			}
		}

		public Evolution Evolution => Evolution.DNA1;
	}
}
