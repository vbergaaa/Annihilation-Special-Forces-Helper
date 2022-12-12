using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkArchon
	// WeaponData: DarkArchonWeapon
	// EffectData: DarkArchonWeaponDamage

	public class CrimsonArchon : CommonUnitData
	{
		public override UnitType Type => UnitType.CrimsonArchon;

		public override double BaseHealth => 30;

		public override double BaseHealthArmor => 12;

		public override double BaseHealthRegen => 3;

		public override double BaseShields => 1250;

		public override double BaseShieldsArmor => 12;

		public override double BaseShieldsRegen => 8;

		public override double HealthIncrement => 3.5;

		public override double HealthRegenIncrement => 0.4492;

		public override double ShieldIncrement => 37;

		public override double ShieldRegenIncrement => 2.3007;

		public override double HealthArmorIncrement => 1.1;

		public override double ShieldArmorIncrement => 1.1;

		public override UnitType[] SpecTypes => new[] { UnitType.DarkShadow, UnitType.Templar, UnitType.ShieldBattery };

		public override UnitType BasicType => UnitType.DarkShadow;

		public override IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.Ascendant, 10, UnitRankType.X, 1);
				yield return new UnitRecepePiece(UnitType.BloodAvenger, 5, UnitRankType.X, 1);
				yield return new UnitRecepePiece(UnitType.DarkArchon, 10, UnitRankType.SXD, 1);
			}
		}

		public override Evolution Evolution => Evolution.Hero;

		public override IEnumerable<IWeaponData> GetWeapons(VLoadout loadout)
		{
			yield return new CrimsonArchonBasicWeapon();
			yield return new CrimsonArchonBasicAttackAOE();
			yield return new HighTemplarStorm();
			yield return new CrimsonArchonOpenFire();
		}
	}
}
