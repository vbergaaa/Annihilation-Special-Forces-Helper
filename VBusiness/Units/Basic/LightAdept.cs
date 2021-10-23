using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Unit: Adept
	// Weapon: Adept
	// Effect: AdeptDamage
	public class LightAdept : CommonUnitData
	{
		public override double BaseHealth => 125;

		public override double BaseHealthArmor => 3;

		public override double BaseHealthRegen => 3;

		public override double BaseShields => 175;

		public override double BaseShieldsArmor => 3;

		public override double BaseShieldsRegen => 5;

		public override UnitType Type => UnitType.LightAdept;

		public override double HealthIncrement => 5;

		public override double HealthRegenIncrement => 0.3007;

		public override double ShieldIncrement => 7;

		public override double ShieldRegenIncrement => 1;

		public override double HealthArmorIncrement => 0.45;

		public override double ShieldArmorIncrement => 0.45;

		public override UnitType[] SpecTypes => new[] { UnitType.LightAdept };

		public override UnitType BasicType => Type;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetEmptyRecipe();

		public override Evolution Evolution => Evolution.Basic;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new LightAdeptBasicWeapon();
			}
		}
	}
}
