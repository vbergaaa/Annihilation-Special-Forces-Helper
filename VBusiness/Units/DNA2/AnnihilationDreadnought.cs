using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ImmortalShakuras
	// WeaponData: AnnihilatorParticleDisruptors
	// EffectData: AnnihilatorParticleDisruptors

	public class AnnihilationDreadnought : Unit
	{
		public AnnihilationDreadnought(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.AnnihilationDreadnought;

		protected override double BaseAttack => 40;

		protected override double BaseAttackSpeed => 1.4;

		public override double AttackCount => 1;

		protected override double BaseHealth => 425;

		protected override double BaseHealthArmor => 8;

		protected override double BaseHealthRegen => 8;

		protected override double BaseShields => 600;

		protected override double BaseShieldsArmor => 8;

		protected override double BaseShieldsRegen => 8;

		protected override double HealthIncrement => 11.8; // should be 11, but looks like a bug in the game code making health regen apply as health increment

		protected override double HealthRegenIncrement => 0; // should be 0.8;

		protected override double ShieldIncrement => 25;

		protected override double ShieldRegenIncrement => 2;

		protected override double HealthArmorIncrement => 0.7;

		protected override double ShieldArmorIncrement => 0.7;

		protected override double AttackIncrement => 2.5;
	}
}
