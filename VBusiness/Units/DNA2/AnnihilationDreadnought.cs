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

		public override double BaseAttack => 40;

		public override double BaseAttackSpeed => 1.4;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 425;

		public override double BaseHealthArmor => 8;

		public override double BaseHealthRegen => 8;

		public override double BaseShields => 600;

		public override double BaseShieldArmor => 8;

		public override double BaseShieldRegen => 8;

		protected override double HealthIncrement => 11.8; // should be 11, but looks like a bug in the game code making health regen apply as health increment

		protected override double HealthRegenIncrement => 0; // should be 0.8;

		protected override double ShieldIncrement => 25;

		protected override double ShieldRegenIncrement => 2;

		protected override double HealthArmorIncrement => 0.7;

		protected override double ShieldArmorIncrement => 0.7;

		protected override double AttackIncrement => 2.5;
	}
}
