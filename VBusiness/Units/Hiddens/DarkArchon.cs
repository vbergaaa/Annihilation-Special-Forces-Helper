using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkArchonR
	// WeaponData: DarkShockwave
	// EffectData: PsionicShockwaveDamage2

	public class DarkArchon : CommonUnitData
	{
		public override UnitType Type => UnitType.DarkArchon;

		public override double BaseHealth => 20;

		public override double BaseHealthArmor => 10;

		public override double BaseHealthRegen => 2;

		public override double BaseShields => 1000;

		public override double BaseShieldsArmor => 10;

		public override double BaseShieldsRegen => 6;

		public override double HealthIncrement => 2;

		public override double HealthRegenIncrement => 1;

		public override double ShieldIncrement => 33;

		public override double ShieldRegenIncrement => 1.6992;

		public override double HealthArmorIncrement => 0.95;

		public override double ShieldArmorIncrement => 0.95;

		public override UnitType[] SpecTypes => new[] { UnitType.DarkShadow, UnitType.Templar };

		public override UnitType BasicType => UnitType.DarkShadow;

		public override IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.Archon, 5, UnitRankType.XX, 1);
				yield return new UnitRecepePiece(UnitType.DarkAvenger, 3, UnitRankType.SS, 4);
			}
		}

		public override Evolution Evolution => Evolution.DNA2;

		public override IEnumerable<IWeaponData> GetWeapons(VLoadout loadout)
		{
			yield return new DarkArchonBasicWeapon();
			yield return new DarkArchonBasicAttackAOE();
			yield return new TemplarStorm();
			yield return new DarkArchonOpenFire();
		}
	}
}
