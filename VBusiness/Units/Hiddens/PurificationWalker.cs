using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class PurificationWalker : IUnitData
	{
		// UnitData: ColossusPurifier
		// WeaponData: ColossusPurifierThermalLances
		// EffectData: ColossusPurifierThermalLancesDamage

		public UnitType Type => UnitType.PurificationWalker;

		double IUnitData.BaseAttack =>30;

		double IUnitData.BaseAttackSpeed => 1.4;

		double IUnitData.AttackCount => 2;

		double IUnitData.BaseHealth => 600;

		double IUnitData.BaseHealthArmor => 8;

		double IUnitData.BaseHealthRegen => 5;

		double IUnitData.BaseShields => 850;

		double IUnitData.BaseShieldsArmor => 8;

		double IUnitData.BaseShieldsRegen => 5;

		double IUnitData.HealthIncrement => 12;

		double IUnitData.HealthRegenIncrement => 1;

		double IUnitData.ShieldIncrement => 18;

		double IUnitData.ShieldRegenIncrement => 1.5;

		double IUnitData.HealthArmorIncrement => 1.1;

		double IUnitData.ShieldArmorIncrement => 1.1;

		double IUnitData.AttackIncrement => 2.5;

		public UnitType[] SpecTypes => new[] { UnitType.Striker, UnitType.Dreadnought };

		public UnitType BasicType => UnitType.Dragoon;

		public IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.Disruptor, 3, UnitRankType.SS, 1);
				yield return new UnitRecepePiece(UnitType.Colossus, 7, UnitRankType.X, 1);
				yield return new UnitRecepePiece(UnitType.WrathWalker, 3, UnitRankType.SS, 1);
			}
		}

		public Evolution Evolution => Evolution.Hero;
	}
}
