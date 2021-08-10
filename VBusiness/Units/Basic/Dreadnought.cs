using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Unit: Immortal
	// Main Effect: PhaseDisruptors
	// Splash Effect: ImmortalSplashDamage

	public class Dreadnought : CommonUnitData
	{
		public override double BaseHealth => 300;

		public override double BaseHealthArmor => 6;

		public override double BaseHealthRegen => 5;

		public override double BaseShields => 450;

		public override double BaseShieldsArmor => 6;

		public override double BaseShieldsRegen => 5;

		public override UnitType Type => UnitType.Dreadnought;

		public override double HealthIncrement => 7;

		public override double HealthRegenIncrement => 0.5;

		public override double ShieldIncrement => 18;

		public override double ShieldRegenIncrement => 1.1992;

		public override double HealthArmorIncrement => 0.45;

		public override double ShieldArmorIncrement => 0.45;

		public override UnitType[] SpecTypes => new[] { UnitType.Dreadnought };

		public override UnitType BasicType => Type;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetEmptyRecipe();

		public override Evolution Evolution => Evolution.Basic;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new DreadnoughtBasicWeapon();
				yield return new DreadnoughtBasicAttackAOE();
			}
		}
	}
}
