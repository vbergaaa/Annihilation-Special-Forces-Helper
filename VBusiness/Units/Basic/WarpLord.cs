using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	/// Unit: Zealot
	/// Weapon: Psi Blades
	public class WarpLord : CommonUnitData
	{

		public override double BaseHealth => 100;

		public override double BaseHealthArmor => 2;

		public override double BaseHealthRegen => 2;

		public override double BaseShields => 150;

		public override double BaseShieldsArmor => 2;

		public override double BaseShieldsRegen => 3;

		public override UnitType Type => UnitType.WarpLord;

		public override double HealthIncrement => 4;

		public override double HealthRegenIncrement => 0.1992;

		public override double ShieldIncrement => 8;

		public override double ShieldRegenIncrement => 0.5;

		public override double HealthArmorIncrement => 0.35;

		public override double ShieldArmorIncrement => 0.35;

		public override UnitType[] SpecTypes => new[] { UnitType.WarpLord };

		public override UnitType BasicType => UnitType.WarpLord;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetEmptyRecipe();

		public override Evolution Evolution => Evolution.Basic;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new WarpLordBasicWeapon();
			}
		}
	}
}
