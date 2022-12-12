using System.Collections.Generic;
using System.Linq;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData name = HybridDominator
	// ASF Weapon name = Psi Blast (can't find in WeaponData)
	public class Dominator : CommonUnitData
	{
		public override UnitType Type => UnitType.Dominator;

		public override double BaseHealth => 600;

		public override double BaseHealthArmor => 6;

		public override double BaseHealthRegen => 1;

		public override double BaseShields => 600;

		public override double BaseShieldsArmor => 6;

		public override double BaseShieldsRegen => 2; // wasn't in data but seems to be correct from my testing

		public override double HealthIncrement => 8;

		public override double HealthRegenIncrement => 1;

		public override double ShieldIncrement => 8;

		public override double ShieldRegenIncrement => 2.0;

		public override double HealthArmorIncrement => 0.6;

		public override double ShieldArmorIncrement => 0.6;

		public override UnitType[] SpecTypes => new[] { UnitType.Dominator };

		public override UnitType BasicType => Type;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetEmptyRecipe();

		public override Evolution Evolution => Evolution.Basic;

		public override IEnumerable<IWeaponData> GetWeapons(VLoadout loadout)
		{	
			if (loadout.ActiveSoulTypes.Contains(SoulType.Domination))
			{
				yield return new DominatorUpgradedBasicWeapon();
				yield return new DominatorUpgradedMultipliedDiscord();
			}
			else
			{
				yield return new DominatorBasicWeapon();
				yield return new DominatorMultipliedDiscord();
			}
		}
	}
}
