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

		protected override double BaseAttack => 22;

		protected override double BaseAttackSpeed => 1;

		public override double AttackCount => 1;

		protected override double BaseHealth => 100;

		protected override double BaseHealthArmor => 6;

		protected override double BaseHealthRegen => 0;

		protected override double BaseShields => 200;

		protected override double BaseShieldsArmor => 6;

		protected override double BaseShieldsRegen => 5;

		protected override double HealthIncrement => 10;

		protected override double HealthRegenIncrement => 0.6015;

		protected override double ShieldIncrement => 16;

		protected override double ShieldRegenIncrement => 1;

		protected override double HealthArmorIncrement => 0.6;

		protected override double ShieldArmorIncrement => 0.6;

		protected override double AttackIncrement => 1.2;
	}
}
