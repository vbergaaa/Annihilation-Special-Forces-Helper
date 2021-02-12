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

		public override double BaseAttack => 15;

		public override double BaseAttackSpeed => 1.5;

		public override double BaseAttackCount => 2;

		public override double BaseHealth => 125;

		public override double BaseHealthArmor => 3;

		public override double BaseHealthRegen => 1;

		public override double BaseShields => 160;

		public override double BaseShieldArmor => 3;

		public override double BaseShieldRegen => 2;

		public override double BaseShieldRegenDelay => 2;

		public override double BaseAttackRange => 6;
	}
}
