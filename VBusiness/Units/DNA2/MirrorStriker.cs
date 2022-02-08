using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: MirrorStriker
	// WeaponData: MirrorDisruptor
	// EffectData: MirrorEntropyLanceDamage

	public class MirrorStriker : CommonUnitData
	{
		public override UnitType Type => UnitType.MirrorStriker;

		public override double BaseHealth => 250;

		public override double BaseHealthArmor => 7;

		public override double BaseHealthRegen => 5;

		public override double BaseShields => 325;

		public override double BaseShieldsArmor => 7;

		public override double BaseShieldsRegen => 4;

		public override double HealthIncrement => 8;

		public override double HealthRegenIncrement => 0.5;

		public override double HealthArmorIncrement => 0.6;

		public override double ShieldIncrement => 12;

		public override double ShieldRegenIncrement => 0.8984;

		public override double ShieldArmorIncrement => 0.6;

		public override UnitType[] SpecTypes => new[] { UnitType.Striker };

		public override UnitType BasicType => UnitType.Striker;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA2Recipe(UnitType.DarkStriker);

		public override Evolution Evolution => Evolution.DNA2;

		public override IEnumerable<IWeaponData> GetWeapons(VLoadout loadout)
		{
			yield return new MirrorStrikerBasicWeapon();
			yield return new MirrorStrikerGreaterMulti();
		}
	}
}
