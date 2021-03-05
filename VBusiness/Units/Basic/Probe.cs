using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData name = Probe
	// WeaponData name = ParticleBeam

	public class Probe : Unit
	{
		public Probe(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.Probe;

		public override double BaseAttack => 5;

		public override double BaseAttackSpeed => 1.5;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 35;

		public override double BaseHealthArmor => 2;

		public override double BaseHealthRegen => 0.3007;

		public override double BaseShields => 50;

		public override double BaseShieldArmor => 2;

		public override double BaseShieldRegen => 3;

		protected override double HealthIncrement => 3;

		protected override double HealthRegenIncrement => 0.1992;

		protected override double ShieldIncrement => 5;

		protected override double ShieldRegenIncrement => 0.3007;

		protected override double HealthArmorIncrement => 0.2;

		protected override double ShieldArmorIncrement => 0.2;

		protected override double AttackIncrement => 0.5;
	}
}
