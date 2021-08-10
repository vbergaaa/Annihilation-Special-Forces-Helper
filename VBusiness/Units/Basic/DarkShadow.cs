using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Unit: DarkTemplar
	// Weapon: WarpBlades
	// Effect: WarpBlades
	public class DarkShadow : CommonUnitData
	{
		public override double BaseHealth => 10;

		public override double BaseHealthArmor => 3;

		public override double BaseHealthRegen => 5;

		public override double BaseShields => 250;

		public override double BaseShieldsArmor => 3;

		public override double BaseShieldsRegen => 5;

		public override UnitType Type => UnitType.DarkShadow;

		public override double HealthIncrement => 1;

		public override double HealthRegenIncrement => 0.1992;

		public override double ShieldIncrement => 10;

		public override double ShieldRegenIncrement => 1;

		public override double HealthArmorIncrement => 0.3;

		public override double ShieldArmorIncrement => 0.3;

		public override UnitType[] SpecTypes => new[] { UnitType.DarkShadow };

		public override UnitType BasicType => Type;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetEmptyRecipe();

		public override Evolution Evolution => Evolution.Basic;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new DarkShadowBasicWeapon();
			}
		}
	}
}
