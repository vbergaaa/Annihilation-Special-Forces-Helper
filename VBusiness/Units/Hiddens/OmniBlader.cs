using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class OmniBlader : IUnitData
	{
		// UnitData: OmniBlader
		// WeaponData: OmniDance
		// EffectData: OmniDanceDamage

		public UnitType Type => UnitType.OmniBlader;

		double IUnitData.BaseAttack =>25;

		double IUnitData.BaseAttackSpeed => 2;

		double IUnitData.AttackCount => 52;

		double IUnitData.BaseHealth => 1000;

		double IUnitData.BaseHealthArmor => 16;

		double IUnitData.BaseHealthRegen => 15;

		double IUnitData.BaseShields => 1500;

		double IUnitData.BaseShieldsArmor => 16;

		double IUnitData.BaseShieldsRegen => 30;

		double IUnitData.HealthIncrement => 23;

		double IUnitData.HealthRegenIncrement => 1.8007;

		double IUnitData.ShieldIncrement => 32;

		double IUnitData.ShieldRegenIncrement => 2.5;

		double IUnitData.HealthArmorIncrement => 1.4;

		double IUnitData.ShieldArmorIncrement => 1.4;

		double IUnitData.AttackIncrement => 20;

		public UnitType[] SpecTypes => new[] { UnitType.WarpLord, UnitType.ShieldBattery, UnitType.LightAdept };

		public UnitType BasicType => UnitType.LightAdept;

		public IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.BladeMaster, 7, UnitRankType.SSZ, 1);
				yield return new UnitRecepePiece(UnitType.BladeDancer, 3, UnitRankType.XX, 2);
				yield return new UnitRecepePiece(UnitType.ForgedAdept, 10, UnitRankType.XX, 2);
			}
		}

		public Evolution Evolution => Evolution.SuperHero;
	}
}
