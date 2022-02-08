using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: SplitterAdept
	// WeaponData: SplitterGlaive
	// EffectData: SplitterDamage

	public class SplitterAdept : CommonUnitData
	{
		public override UnitType Type => UnitType.SplitterAdept;

		public override double BaseHealth => 200;

		public override double BaseHealthArmor => 6;

		public override double BaseHealthRegen => 5;

		public override double BaseShields => 350;

		public override double BaseShieldsArmor => 6;

		public override double BaseShieldsRegen => 7;

		public override double HealthIncrement => 9;

		public override double HealthRegenIncrement => 0.6015;

		public override double ShieldIncrement => 11;

		public override double ShieldRegenIncrement => 1;

		public override double HealthArmorIncrement => 0.7;

		public override double ShieldArmorIncrement => 0.7;

		public override UnitType[] SpecTypes => new[] { UnitType.LightAdept };

		public override UnitType BasicType => UnitType.LightAdept;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA2Recipe(UnitType.ForgedAdept);

		public override Evolution Evolution => Evolution.DNA2;

		public override IEnumerable<IWeaponData> GetWeapons(VLoadout loadout)
		{
			yield return new SplitterAdeptBasicWeapon();
		}

		public override ITemporaryBuffAbility OffensiveBuffAbility => new SplitterAdeptPrecisionTargetting();
	}
}
