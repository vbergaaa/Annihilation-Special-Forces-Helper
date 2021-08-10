using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: HighTemplarTaldarmin
	// WeaponData: AscendantWeapon
	// EffectData: AscendantWeaponDamage

	public class Ascendant : CommonUnitData
	{
		public override UnitType Type => UnitType.Ascendant;

		public override double BaseHealth => 500;

		public override double BaseHealthArmor => 10;

		public override double BaseHealthRegen => 2;

		public override double BaseShields => 1000;

		public override double BaseShieldsArmor => 10;

		public override double BaseShieldsRegen => 10;

		public override double HealthIncrement => 10;

		public override double HealthRegenIncrement => 0.3007;

		public override double ShieldIncrement => 20;

		public override double ShieldRegenIncrement => 1;

		public override double HealthArmorIncrement => 0.9;

		public override double ShieldArmorIncrement => 0.9;

		public override UnitType[] SpecTypes => new[] { UnitType.DarkShadow, UnitType.Templar, UnitType.ShieldBattery };

		public override UnitType BasicType => UnitType.Templar;

		public override IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.Archon, 7, UnitRankType.X, 1);
				yield return new UnitRecepePiece(UnitType.HighTemplar, 5, UnitRankType.SS, 2);
				yield return new UnitRecepePiece(UnitType.DarkShieldBattery, 3, UnitRankType.SS, 2);
			}
		}

		public override Evolution Evolution => Evolution.DNA2;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new AscendentBasicWeapon();
			}
		}
	}
}
