using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData name = Probe
	// WeaponData name = ParticleBeam

	public class Probe : CommonUnitData
	{
		public override UnitType Type => UnitType.Probe;

		public override double BaseHealth => 35;

		public override double BaseHealthArmor => 2;

		public override double BaseHealthRegen => 0.3007;

		public override double BaseShields => 50;

		public override double BaseShieldsArmor => 2;

		public override double BaseShieldsRegen => 3;

		public override double HealthIncrement => 3;

		public override double HealthRegenIncrement => 0.1992;

		public override double ShieldIncrement => 5;

		public override double ShieldRegenIncrement => 0.3007;

		public override double HealthArmorIncrement => 0.2;

		public override double ShieldArmorIncrement => 0.2;

		public override UnitType[] SpecTypes => System.Array.Empty<UnitType>();

		public override UnitType BasicType => Type;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetEmptyRecipe();

		public override Evolution Evolution => Evolution.Basic;

		public override IEnumerable<IWeaponData> GetWeapons(VLoadout loadout)
		{
			yield return new ProbeBasicWeapon();
		}
	}
}
