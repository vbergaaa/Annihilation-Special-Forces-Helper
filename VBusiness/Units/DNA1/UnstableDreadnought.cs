using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ImmortalAiur
	// WeaponData: UnstableDisruptors
	// EffectData: ImmortalSplashSet2

	public class UnstableDreadnought : CommonUnitData
	{
		public override UnitType Type => UnitType.UnstableDreadnought;

		public override double BaseHealth => 350;

		public override double BaseHealthArmor => 7;

		public override double BaseHealthRegen => 7;

		public override double BaseShields => 500;

		public override double BaseShieldsArmor => 7;

		public override double BaseShieldsRegen => 7;

		public override double HealthIncrement => 9;

		public override double HealthRegenIncrement => 0.601;

		public override double ShieldIncrement => 22;

		public override double ShieldRegenIncrement => 1.5;

		public override double HealthArmorIncrement => 0.55;

		public override double ShieldArmorIncrement => 0.55;

		public override UnitType[] SpecTypes => new[] { UnitType.Dreadnought };

		public override UnitType BasicType => UnitType.Dreadnought;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA1Recipe(BasicType);

		public override Evolution Evolution => Evolution.DNA1;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new UnstableDreadnoughtBasicWeapon();
				yield return new UnstableDreadnoughtBasicAttackAOE();
				yield return new UnstableDreadnoughtUnstableCore();
			}
		}
	}
}
