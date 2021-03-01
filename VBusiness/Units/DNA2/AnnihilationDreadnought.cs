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
	}
}
