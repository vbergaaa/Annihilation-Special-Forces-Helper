using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkTemplarTaldarim
	// WeaponData: DarkTemplarTaldarmin
	// EffectData: BAScytheDamage

	public class BloodAvenger : CommonUnitData
	{
		public override UnitType Type => UnitType.BloodAvenger;

		public override double BaseHealth => 22;

		public override double BaseHealthArmor => 5;

		public override double BaseHealthRegen => 7;

		public override double BaseShields => 475;

		public override double BaseShieldsArmor => 5;

		public override double BaseShieldsRegen => 7;

		public override double HealthIncrement => 2;

		public override double HealthRegenIncrement => 0.5;

		public override double ShieldIncrement => 15;

		public override double ShieldRegenIncrement => 2;

		public override double HealthArmorIncrement => 0.6;

		public override double ShieldArmorIncrement => 0.6;

		public override UnitType[] SpecTypes => new[] { UnitType.DarkShadow };

		public override UnitType BasicType => UnitType.DarkShadow;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA2Recipe(UnitType.DarkAvenger);

		public override Evolution Evolution => Evolution.DNA2;

		public override IEnumerable<IWeaponData> GetWeapons(VLoadout loadout)
		{
			yield return new BloodAvengerBasicWeapon();
			yield return new BloodAvengerBloodHarvest();
		}
	}
}
