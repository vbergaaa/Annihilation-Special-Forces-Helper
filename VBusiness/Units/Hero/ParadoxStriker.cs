using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: StalkerPurifier
	// EffectData: MirrorEntropyLanceDamage2

	public class ParadoxStriker : CommonUnitData
	{
		public override UnitType Type => UnitType.ParadoxStriker;

		public override double BaseHealth => 320;

		public override double BaseHealthArmor => 10;

		public override double BaseHealthRegen => 3;

		public override double BaseShields => 425;

		public override double BaseShieldsArmor => 10;

		public override double BaseShieldsRegen => 5;

		public override double HealthIncrement => 12;

		public override double HealthRegenIncrement => 0.6015;

		public override double HealthArmorIncrement => 0.75;

		public override double ShieldIncrement => 15;

		public override double ShieldRegenIncrement => 0.8984;

		public override double ShieldArmorIncrement => 0.75;

		public override UnitType[] SpecTypes => new[] { UnitType.Striker };

		public override UnitType BasicType => UnitType.Striker;

		public override IEnumerable<UnitRecepePiece> Recepe { get { yield return new UnitRecepePiece(UnitType.MirrorStriker, 10, UnitRankType.None, 1); } }

		public override Evolution Evolution => Evolution.Hero;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new ParadoxStrikerBasicWeapon();
			}
		}
	}
}
