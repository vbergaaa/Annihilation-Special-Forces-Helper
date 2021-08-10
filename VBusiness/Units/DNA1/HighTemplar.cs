using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: HighArchonTemplar
	// WeaponData: HighTemplarWeapon

	public class HighTemplar : CommonUnitData
	{
		public override UnitType Type => UnitType.HighTemplar;

		public override double BaseHealth => 650;

		public override double BaseHealthArmor => 7;

		public override double BaseHealthRegen => 3;

		public override double BaseShields => 650;

		public override double BaseShieldsArmor => 7;

		public override double BaseShieldsRegen => 6;

		public override double HealthIncrement => 8;

		public override double HealthRegenIncrement => 0.6992;

		public override double ShieldIncrement => 8;

		public override double ShieldRegenIncrement => 0.6992;

		public override double HealthArmorIncrement => 0.65;

		public override double ShieldArmorIncrement => 0.65;

		public override UnitType[] SpecTypes => new[] { UnitType.Templar };

		public override UnitType BasicType => UnitType.Templar;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA1Recipe(BasicType);

		public override Evolution Evolution => Evolution.DNA1;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new TemplarBasicWeapon(); // as far as I can tell, this is the same weapon as the regular temp
			}
		}
	}
}
