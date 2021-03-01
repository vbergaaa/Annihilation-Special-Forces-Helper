using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class EvolutionProbe : Unit
	{
		// UnitData: EvolutionProbe
		// WeaponData: EvolutionParticleBeam
		// EffectData: DarkParticleBeam2

		public EvolutionProbe(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.EvolutionProbe;

		public override double BaseAttack => 22;

		public override double BaseAttackSpeed => 1;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 100;

		public override double BaseHealthArmor => 6;

		public override double BaseHealthRegen => 0;

		public override double BaseShields => 200;

		public override double BaseShieldArmor => 6;

		public override double BaseShieldRegen => 5;
	}
}
