using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Stalker
	// ParticleDisruptor / ParticleDisruptorU

	public class Striker : CommonUnitData
	{
		public override double BaseHealth => 125;

		public override double BaseHealthArmor => 3;

		public override double BaseHealthRegen => 1;

		public override double BaseShields => 160;

		public override double BaseShieldsArmor => 3;

		public override double BaseShieldsRegen => 2;

		public override UnitType Type => UnitType.Striker;

		public override double HealthIncrement => 4;

		public override double HealthRegenIncrement => 0.3007;

		public override double ShieldIncrement => 6;

		public override double ShieldRegenIncrement => 0.5;

		public override double HealthArmorIncrement => 0.4;

		public override double ShieldArmorIncrement => 0.4;

		public override UnitType[] SpecTypes => new[] { UnitType.Striker };

		public override UnitType BasicType => Type;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetEmptyRecipe();

		public override Evolution Evolution => Evolution.Basic;

		public override IEnumerable<IWeaponData> GetWeapons(VLoadout loadout)
		{
			yield return new StrikerBasicWeapon();
			yield return new StrikerGreaterMulti();
		}
	}
}
