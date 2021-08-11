using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkArchon
	// WeaponData: WingedTorrent
	// EffectData: WingedArchonWeaponDamage

	public class WingedArchon : CommonUnitData
	{
		public override UnitType Type => UnitType.WingedArchon;

		public override double BaseHealth => 60;

		public override double BaseHealthArmor => 15;

		public override double BaseHealthRegen => 4;

		public override double BaseShields => 1600;

		public override double BaseShieldsArmor => 15;

		public override double BaseShieldsRegen => 10;

		public override double HealthIncrement => 15;

		public override double HealthRegenIncrement => 1.8007;

		public override double ShieldIncrement => 40;

		public override double ShieldRegenIncrement => 3;

		public override double HealthArmorIncrement => 1.3;

		public override double ShieldArmorIncrement => 1.3;

		public override UnitType[] SpecTypes => new[] { UnitType.DarkShadow, UnitType.Templar, UnitType.ShieldBattery, UnitType.WarpLord };

		public override UnitType BasicType => UnitType.DarkShadow;

		public override IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.CrimsonArchon, 10, UnitRankType.XDZ, 1);
				yield return new UnitRecepePiece(UnitType.StonePrisoner, 7, UnitRankType.X, 1);
				yield return new UnitRecepePiece(UnitType.DarkArchon, 6, UnitRankType.XD, 2);
			}
		}

		public override Evolution Evolution => Evolution.SuperHero;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new WingedArchonBasicWeapon();
				yield return new WingedArchonBasicAttackAOE();
				yield return new WingedArchonWingedStorm();
			}
		}
	}
}
