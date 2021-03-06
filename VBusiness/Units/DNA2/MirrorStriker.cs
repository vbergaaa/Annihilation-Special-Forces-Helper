﻿using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: MirrorStriker
	// WeaponData: MirrorDisruptor
	// EffectData: MirrorEntropyLanceDamage

	public class MirrorStriker : IUnitData
	{
		public UnitType Type => UnitType.MirrorStriker;

		double IUnitData.AttackCount => 1; // Multishot = 5, Greater Multishot = 11?

		double IUnitData.BaseAttack => 28;

		double IUnitData.BaseAttackSpeed => 1.3;

		double IUnitData.BaseHealth => 250;

		double IUnitData.BaseHealthArmor => 7;

		double IUnitData.BaseHealthRegen => 5;

		double IUnitData.BaseShields => 325;

		double IUnitData.BaseShieldsArmor => 7;

		double IUnitData.BaseShieldsRegen => 4;

		double IUnitData.AttackIncrement => 1.6;

		double IUnitData.HealthIncrement => 8;

		double IUnitData.HealthRegenIncrement => 0.5;

		double IUnitData.HealthArmorIncrement => 0.6;

		double IUnitData.ShieldIncrement => 12;

		double IUnitData.ShieldRegenIncrement => 0.8984;
		
		double IUnitData.ShieldArmorIncrement => 0.6;

		public UnitType[] SpecTypes => new[] { UnitType.Striker };

		public UnitType BasicType => UnitType.Striker;

		public IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA2Recipe(UnitType.DarkStriker);

		public Evolution Evolution => Evolution.DNA2;
	}
}
