using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class OmniBlader : CommonUnitData
	{
		// UnitData: OmniBlader
		// WeaponData: OmniDance
		// EffectData: OmniDanceDamage

		public override UnitType Type => UnitType.OmniBlader;

		public override double BaseHealth => 1000;

		public override double BaseHealthArmor => 16;

		public override double BaseHealthRegen => 15;

		public override double BaseShields => 1500;

		public override double BaseShieldsArmor => 16;

		public override double BaseShieldsRegen => 30;

		public override double HealthIncrement => 23;

		public override double HealthRegenIncrement => 1.8007;

		public override double ShieldIncrement => 32;

		public override double ShieldRegenIncrement => 2.5;

		public override double HealthArmorIncrement => 1.4;

		public override double ShieldArmorIncrement => 1.4;

		public override UnitType[] SpecTypes => new[] { UnitType.WarpLord, UnitType.ShieldBattery, UnitType.LightAdept };

		public override UnitType BasicType => UnitType.LightAdept;

		public override IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.BladeMaster, 7, UnitRankType.SSZ, 1);
				yield return new UnitRecepePiece(UnitType.BladeDancer, 3, UnitRankType.XX, 2);
				yield return new UnitRecepePiece(UnitType.ForgedAdept, 10, UnitRankType.XX, 2);
			}
		}

		public override Evolution Evolution => Evolution.SuperHero;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new OmniBladerBasicWeapon();
				yield return new OmniBladerUnboundAssault();
			}
		}
	}
}
