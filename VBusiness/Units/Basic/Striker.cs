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
