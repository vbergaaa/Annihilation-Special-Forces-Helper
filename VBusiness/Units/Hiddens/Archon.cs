using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Archon
	// WeaponData: PsionicShockwave
	// EffectData: PsionicShockwaveDamage

	public class Archon : CommonUnitData
	{
		public override UnitType Type => UnitType.Archon;

		public override double BaseHealth => 10;

		public override double BaseHealthArmor => 7;

		public override double BaseHealthRegen => 1;

		public override double BaseShields => 700;

		public override double BaseShieldsArmor => 7;

		public override double BaseShieldsRegen => 4;

		public override double HealthIncrement => 1;

		public override double HealthRegenIncrement => 0.1992;

		public override double ShieldIncrement => 27;

		public override double ShieldRegenIncrement => 1.3007;

		public override double HealthArmorIncrement => 0.7;

		public override double ShieldArmorIncrement => 0.7;

		public override UnitType[] SpecTypes => new[] { UnitType.DarkShadow, UnitType.Templar };

		public override UnitType BasicType => UnitType.DarkShadow;

		public override IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.Templar, 1, UnitRankType.SSS, 1);
				yield return new UnitRecepePiece(UnitType.DarkShadow, 3, UnitRankType.SS, 4);
			}
		}

		public override Evolution Evolution => Evolution.DNA1;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new ArchonBasicWeapon();
				yield return new ArchonBasicAttackAOE();
			}
		}
	}
}
