using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ImmortalShakuras
	// WeaponData: AnnihilatorParticleDisruptors
	// EffectData: AnnihilatorParticleDisruptors

	public class AnnihilationDreadnought : IUnitData
	{
		public UnitType Type => UnitType.AnnihilationDreadnought;

		double IUnitData.BaseAttack =>40;

		double IUnitData.BaseAttackSpeed => 1.4;

		double IUnitData.AttackCount => 1;

		double IUnitData.BaseHealth => 425;

		double IUnitData.BaseHealthArmor => 8;

		double IUnitData.BaseHealthRegen => 8;

		double IUnitData.BaseShields => 600;

		double IUnitData.BaseShieldsArmor => 8;

		double IUnitData.BaseShieldsRegen => 8;

		double IUnitData.HealthIncrement => 11.8; // should be 11, but looks like a bug in the game code making health regen apply as health increment

		double IUnitData.HealthRegenIncrement => 0; // should be 0.8;

		double IUnitData.ShieldIncrement => 25;

		double IUnitData.ShieldRegenIncrement => 2;

		double IUnitData.HealthArmorIncrement => 0.7;

		double IUnitData.ShieldArmorIncrement => 0.7;

		double IUnitData.AttackIncrement => 2.5;

		public UnitType[] SpecTypes => new[] { UnitType.Dreadnought };

		public UnitType BasicType => UnitType.Dreadnought;

		public IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA2Recipe(UnitType.UnstableDreadnought);

		public Evolution Evolution => Evolution.DNA2;
	}
}
