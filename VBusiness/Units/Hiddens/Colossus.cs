using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Colossus
	// WeaponData: ThermalLances
	// EffectData: ThermalLancesMU

	public class Colossus : CommonUnitData
	{
		public override UnitType Type => UnitType.Colossus;

		public override double BaseHealth => 325;

		public override double BaseHealthArmor => 7;

		public override double BaseHealthRegen => 7;

		public override double BaseShields => 400;

		public override double BaseShieldsArmor => 7;

		public override double BaseShieldsRegen => 7;

		public override double HealthIncrement => 7;

		public override double HealthRegenIncrement => 0.5;

		public override double ShieldIncrement => 12;

		public override double ShieldRegenIncrement => 1;

		public override double HealthArmorIncrement => 0.7;

		public override double ShieldArmorIncrement => 0.7;

		public override UnitType[] SpecTypes => new[] { UnitType.Striker, UnitType.Dreadnought };

		public override UnitType BasicType => UnitType.Dragoon;

		public override IEnumerable<UnitRecepePiece> Recepe { get { yield return new UnitRecepePiece(UnitType.Reaver, 3, UnitRankType.S, 2); } }

		public override Evolution Evolution => Evolution.DNA2;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new ColossusBasicWeapon();
			}
		}
	}
}
