using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: StalkerShakuras
	// WeaponData: DarkDisruptor
	// EffectData: EntropyLanceSearch3
	// EffectData: ParticleDisruptors3
	// EffectDamage: ParticleDisruptorsU3

	public class DarkStriker : CommonUnitData
	{
		public override UnitType Type => UnitType.DarkStriker;

		public override double BaseHealth => 160;

		public override double BaseHealthArmor => 4.5;

		public override double BaseHealthRegen => 2;

		public override double BaseShields => 200;

		public override double BaseShieldsArmor => 4.5;

		public override double BaseShieldsRegen => 2; // from in-game test

		public override double HealthIncrement => 6;

		public override double HealthRegenIncrement => 0.3515;

		public override double ShieldIncrement => 8;

		public override double ShieldRegenIncrement => 0.6992;

		public override double HealthArmorIncrement => 0.5;

		public override double ShieldArmorIncrement => 0.5;

		public override UnitType[] SpecTypes => new[] { UnitType.Striker };

		public override UnitType BasicType => UnitType.Striker;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA1Recipe(BasicType);

		public override Evolution Evolution => Evolution.DNA1;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new DarkStrikerBasicWeapon();
			}
		}
	}
}
