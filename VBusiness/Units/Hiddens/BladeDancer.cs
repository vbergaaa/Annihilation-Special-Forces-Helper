using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: BladeDancer
	// WeaponData: BladeDance

	public class BladeDancer : CommonUnitData
	{
		public override UnitType Type => UnitType.BladeDancer;

		public override double BaseHealth => 500;

		public override double BaseHealthArmor => 8;

		public override double BaseHealthRegen => 9;

		public override double BaseShields => 750;

		public override double BaseShieldsArmor => 8;

		public override double BaseShieldsRegen => 15;

		public override double HealthIncrement => 11;

		public override double HealthRegenIncrement => 1.1992;

		public override double ShieldIncrement => 18;

		public override double ShieldRegenIncrement => 1.3984;

		public override double HealthArmorIncrement => 0.9;

		public override double ShieldArmorIncrement => 0.9;

		public override UnitType[] SpecTypes => new[] { UnitType.WarpLord, UnitType.LightAdept, UnitType.ShieldBattery };

		public override UnitType BasicType => UnitType.LightAdept;

		public override IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.StonePrisoner, 5, UnitRankType.SS, 1);
				yield return new UnitRecepePiece(UnitType.LightAdept, 3, UnitRankType.S, 5);
			}
		}

		public override Evolution Evolution => Evolution.DNA2;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new BladeDancerBasicWeapon();
				yield return new BladeDancerCombinatedAssault();
			}
		}
	}
}
