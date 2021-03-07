using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Stalker
	// ParticleDisruptor / ParticleDisruptorU

	public class Striker : Unit
	{
		public Striker(VLoadout loadout) : base(loadout)
		{
		}

		protected override double BaseAttack => 15;

		protected override double BaseAttackSpeed => 1.5;

		public override double AttackCount => 2;

		protected override double BaseHealth => 125;

		protected override double BaseHealthArmor => 3;

		protected override double BaseHealthRegen => 1;

		protected override double BaseShields => 160;

		protected override double BaseShieldsArmor => 3;

		protected override double BaseShieldsRegen => 2;

		public override UnitType Type => UnitType.Striker;

		protected override double HealthIncrement => 4;

		protected override double HealthRegenIncrement => 0.3007;

		protected override double ShieldIncrement => 6;

		protected override double ShieldRegenIncrement => 0.5;

		protected override double HealthArmorIncrement => 0.4;

		protected override double ShieldArmorIncrement => 0.4;

		protected override double AttackIncrement => 1;
	}
}
