using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Unit: HighTemplar
	// Weapon effect: HighTemplarWeaponDamage
	// Ability effect: PsiStormDamage && PsiStormDamageInitial

	public class Templar : CommonUnitData
	{
		public override double BaseHealth => 400;

		public override double BaseHealthArmor => 5;

		public override double BaseHealthRegen => 2;

		public override double BaseShields => 400;

		public override double BaseShieldsArmor => 5;

		public override double BaseShieldsRegen => 3;

		public override UnitType Type => UnitType.Templar;

		public override double HealthIncrement => 6;

		public override double HealthRegenIncrement => 0.5;

		public override double ShieldIncrement => 6;

		public override double ShieldRegenIncrement => 0.5;

		public override double HealthArmorIncrement => 0.55;

		public override double ShieldArmorIncrement => 0.55;

		public override UnitType[] SpecTypes => new[] { UnitType.Templar };

		public override UnitType BasicType => Type;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetEmptyRecipe();

		public override Evolution Evolution => Evolution.Basic;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new TemplarBasicWeapon();
			}
		}
	}
}
