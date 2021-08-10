using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	//UnitData: Monitor
	//EffectData: HealingBeam2

	public class DarkShieldBattery : CommonUnitData
	{
		public override UnitType Type => UnitType.DarkShieldBattery;

		public override double BaseHealth => 75;

		public override double BaseHealthArmor => 3;

		public override double BaseHealthRegen => 3;

		public override double BaseShields => 150;

		public override double BaseShieldsArmor => 3;

		public override double BaseShieldsRegen => 7;

		public override double HealthIncrement => 6;

		public override double HealthRegenIncrement => 0.3007;

		public override double ShieldIncrement => 9;

		public override double ShieldRegenIncrement => 1;

		public override double HealthArmorIncrement => 0.45;

		public override double ShieldArmorIncrement => 0.45;

		public override UnitType[] SpecTypes => new[] { UnitType.ShieldBattery };

		public override UnitType BasicType => UnitType.ShieldBattery;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA1Recipe(BasicType);

		public override Evolution Evolution => Evolution.DNA1;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new DarkShieldBatteryBasicWeapon();
			}
		}
	}
}
