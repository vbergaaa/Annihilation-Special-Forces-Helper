using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData name = Sentry
	// ASF weapon name = Healing Beam?

	public class ShieldBattery : CommonUnitData
	{
		public override UnitType Type => UnitType.ShieldBattery;

		public override double BaseHealth => 50;

		public override double BaseHealthArmor => 2;

		public override double BaseHealthRegen => 2;

		public override double BaseShields => 100;

		public override double BaseShieldsArmor => 2;

		public override double BaseShieldsRegen => 5;

		public override double HealthIncrement => 4;

		public override double HealthRegenIncrement => 0.1992;

		public override double ShieldIncrement => 6;

		public override double ShieldRegenIncrement => 0.8007;

		public override double HealthArmorIncrement => 0.3;

		public override double ShieldArmorIncrement => 0.3;

		public override UnitType[] SpecTypes => new[] { UnitType.ShieldBattery };

		public override UnitType BasicType => Type;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetEmptyRecipe();

		public override Evolution Evolution => Evolution.Basic;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new ShieldBatteryBasicWeapon();
				yield return new ShieldBatteryDestablisingShield();
			}
		}
	}
}
