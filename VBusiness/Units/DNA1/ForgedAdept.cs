using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ForgedAdept
	// WeaponData: DarkPurifierGlaive
	// EffectData: DarkAdeptDamage

	public class ForgedAdept : CommonUnitData
	{
		public override UnitType Type => UnitType.ForgedAdept;

		public override double BaseHealth => 160;

		public override double BaseHealthArmor => 4.5;

		public override double BaseHealthRegen => 4;

		public override double BaseShields => 250;

		public override double BaseShieldsArmor => 4.5;

		public override double BaseShieldsRegen => 6;

		public override double HealthIncrement => 7;

		public override double HealthRegenIncrement => 0.5;

		public override double ShieldIncrement => 9;

		public override double ShieldRegenIncrement => 1;

		public override double HealthArmorIncrement => 0.6;

		public override double ShieldArmorIncrement => 0.6;

		public override UnitType[] SpecTypes => new[] { UnitType.LightAdept };

		public override UnitType BasicType => UnitType.LightAdept;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA1Recipe(BasicType);

		public override Evolution Evolution => Evolution.DNA1;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new ForgedAdeptBasicWeapon();
			}
		}
	}
}
