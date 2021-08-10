using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkTemplarAiur
	// WeaponData: AvengerWeapon

	public class DarkAvenger : CommonUnitData
	{
		public override UnitType Type => UnitType.DarkAvenger;

		public override double BaseHealth => 15;

		public override double BaseHealthArmor => 4;

		public override double BaseHealthRegen => 6;

		public override double BaseShields => 325;

		public override double BaseShieldsArmor => 4;

		public override double BaseShieldsRegen => 6;

		public override double HealthIncrement => 1.5;

		public override double HealthRegenIncrement => 0.3984;

		public override double ShieldIncrement => 13;

		public override double ShieldRegenIncrement => 1.5;

		public override double HealthArmorIncrement => 0.4;

		public override double ShieldArmorIncrement => 0.4;

		public override UnitType[] SpecTypes => new[] { UnitType.DarkShadow };

		public override UnitType BasicType => UnitType.DarkShadow;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA1Recipe(BasicType);

		public override Evolution Evolution => Evolution.DNA1;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new DarkAvengerBasicWeapon();
			}
		}
	}
}
