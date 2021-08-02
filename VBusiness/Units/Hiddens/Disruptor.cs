using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitType: Disruptor
	// WeaponData: DisruptorBlast
	// EffectData: DisruptorWeaponDamage2

	public class Disruptor : IUnitData
	{
		public UnitType Type => UnitType.Disruptor;

		double IUnitData.BaseHealth => 500;

		double IUnitData.BaseHealthArmor => 7;

		double IUnitData.BaseHealthRegen => 3;

		double IUnitData.BaseShields => 650;

		double IUnitData.BaseShieldsArmor => 7;

		double IUnitData.BaseShieldsRegen => 10;

		double IUnitData.HealthIncrement => 9;

		double IUnitData.HealthRegenIncrement => 0.6992;

		double IUnitData.ShieldIncrement => 22;

		double IUnitData.ShieldRegenIncrement => 1.5;

		double IUnitData.HealthArmorIncrement => 0.7;

		double IUnitData.ShieldArmorIncrement => 0.7;

		public UnitType[] SpecTypes => new[] { UnitType.Striker, UnitType.Dreadnought };

		public UnitType BasicType => UnitType.Dreadnought;

		public IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.UnstableDreadnought, 3, UnitRankType.SS, 1);
				yield return new UnitRecepePiece(UnitType.Reaver, 3, UnitRankType.S, 1);
				yield return new UnitRecepePiece(UnitType.Striker, 1, UnitRankType.S, 5);
			}
		}

		public Evolution Evolution => Evolution.DNA1;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new DisruptorBasicWeapon();
			}
		}
	}
}
