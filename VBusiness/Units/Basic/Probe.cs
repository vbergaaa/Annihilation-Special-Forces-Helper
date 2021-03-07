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

		protected override double BaseAttack => 5;

		protected override double BaseAttackSpeed => 1.5;

		public override double AttackCount => 1;

		protected override double BaseHealth => 35;

		protected override double BaseHealthArmor => 2;

		protected override double BaseHealthRegen => 0.3007;

		protected override double BaseShields => 50;

		protected override double BaseShieldsArmor => 2;

		protected override double BaseShieldsRegen => 3;

		protected override double HealthIncrement => 3;

		protected override double HealthRegenIncrement => 0.1992;

		protected override double ShieldIncrement => 5;

		protected override double ShieldRegenIncrement => 0.3007;

		protected override double HealthArmorIncrement => 0.2;

		protected override double ShieldArmorIncrement => 0.2;

		protected override double AttackIncrement => 0.5;
	}
}
