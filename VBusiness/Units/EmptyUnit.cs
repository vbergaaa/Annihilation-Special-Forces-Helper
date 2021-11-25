using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class EmptyUnit : CommonUnitData
	{
		public override UnitType Type => UnitType.None;

		public override double BaseHealth => 0;

		public override double BaseHealthArmor => 0;

		public override double BaseHealthRegen => 0;

		public override double BaseShields => 0;

		public override double BaseShieldsArmor => 0;

		public override double BaseShieldsRegen => 0;

		public override double HealthIncrement => 0;

		public override double HealthRegenIncrement => 0;

		public override double ShieldIncrement => 0;

		public override double ShieldRegenIncrement => 0;

		public override double HealthArmorIncrement => 0;

		public override double ShieldArmorIncrement => 0;

		public override UnitType[] SpecTypes => System.Array.Empty<UnitType>();

		public override UnitType BasicType => UnitType.None;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetEmptyRecipe();

		public override Evolution Evolution => Evolution.Basic;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new EmptyWeapon();
			}
		}
	}
}
