using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ZealotShakuras
	// Weapon: WarpBlades
	// Effect: WarpBladesDamage

	public class DarkWarpLord : CommonUnitData
	{
		public override UnitType Type => UnitType.DarkWarpLord;

		public override double BaseHealth => 150;

		public override double BaseHealthArmor => 3;

		public override double BaseHealthRegen => 3;

		public override double BaseShields => 200;

		public override double BaseShieldsArmor => 3;

		public override double BaseShieldsRegen => 5;

		public override double HealthIncrement => 5;

		public override double HealthRegenIncrement => 0.25;

		public override double ShieldIncrement => 10;

		public override double ShieldRegenIncrement => 0.8007;

		public override double HealthArmorIncrement => 0.45;

		public override double ShieldArmorIncrement => 0.45;

		public override UnitType[] SpecTypes => new[] { UnitType.WarpLord };

		public override UnitType BasicType => UnitType.WarpLord;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA1Recipe(BasicType);

		public override Evolution Evolution => Evolution.DNA1;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new DarkWarpLordBasicWeapon();
				yield return new DarkWarpLordBasicAtkAOE();
				yield return new DarkWarpLordDarkWarpAnnihilation();
			}
		}
	}
}
