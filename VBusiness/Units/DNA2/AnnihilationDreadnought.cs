using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ImmortalShakuras
	// WeaponData: AnnihilatorParticleDisruptors
	// EffectData: AnnihilatorParticleDisruptors

	public class AnnihilationDreadnought : CommonUnitData
	{
		public override UnitType Type => UnitType.AnnihilationDreadnought;

		public override double BaseHealth => 425;

		public override double BaseHealthArmor => 8;

		public override double BaseHealthRegen => 8;

		public override double BaseShields => 600;

		public override double BaseShieldsArmor => 8;

		public override double BaseShieldsRegen => 8;

		public override double HealthIncrement => 11.8; // should be 11, but looks like a bug in the game code making health regen apply as health increment

		public override double HealthRegenIncrement => 0; // should be 0.8;

		public override double ShieldIncrement => 25;

		public override double ShieldRegenIncrement => 2;

		public override double HealthArmorIncrement => 0.7;

		public override double ShieldArmorIncrement => 0.7;

		public override UnitType[] SpecTypes => new[] { UnitType.Dreadnought };

		public override UnitType BasicType => UnitType.Dreadnought;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA2Recipe(UnitType.UnstableDreadnought);

		public override Evolution Evolution => Evolution.DNA2;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new AnnihilationDreadnoughtBasicWeapon();
				yield return new AnnihilationDreadnaughtBasicAtkAOE();
			}
		}
	}
}
