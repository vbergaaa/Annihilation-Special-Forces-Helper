using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Reaver
	// EffectData: ScarabExplodeTargetDamage

	public class Reaver : CommonUnitData
	{
		public override UnitType Type => UnitType.Reaver;

		public override double BaseHealth => 250;

		public override double BaseHealthArmor => 6;

		public override double BaseHealthRegen => 5;

		public override double BaseShields => 325;

		public override double BaseShieldsArmor => 6;

		public override double BaseShieldsRegen => 5;

		public override double HealthIncrement => 5;

		public override double HealthRegenIncrement => 0.3007;

		public override double ShieldIncrement => 10;

		public override double ShieldRegenIncrement => 0.8007;

		public override double HealthArmorIncrement => 0.6;

		public override double ShieldArmorIncrement => 0.6;

		public override UnitType[] SpecTypes => new[] { UnitType.Striker, UnitType.Dreadnought };

		public override UnitType BasicType => UnitType.Dragoon;

		public override IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.Dragoon, 3, UnitRankType.A, 1);
				yield return new UnitRecepePiece(UnitType.Dreadnought, 0, UnitRankType.None, 3);
			}
		}

		public override Evolution Evolution => Evolution.DNA1;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new ReaverBasicWeapon();
				yield return new ReaverBasicAttackAOE();
			}
		}
	}
}
