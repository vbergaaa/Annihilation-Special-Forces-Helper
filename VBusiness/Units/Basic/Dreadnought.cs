using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Unit: Immortal
	// Main Effect: PhaseDisruptors
	// Splash Effect: ImmortalSplashDamage

	public class Dreadnought : Unit
	{
		public Dreadnought(VLoadout loadout) : base(loadout)
		{
		}

		protected override double BaseAttack => 25;

		protected override double BaseAttackSpeed => 2;

		public override double AttackCount => 1;

		protected override double BaseHealth => 300;

		protected override double BaseHealthArmor => 6;

		protected override double BaseHealthRegen => 5;

		protected override double BaseShields => 450;

		protected override double BaseShieldsArmor => 6;

		protected override double BaseShieldsRegen => 5;

		public override UnitType Type => UnitType.Dreadnought;

		protected override double HealthIncrement => 7;

		protected override double HealthRegenIncrement => 0.5;

		protected override double ShieldIncrement => 18;

		protected override double ShieldRegenIncrement => 1.1992;

		protected override double HealthArmorIncrement => 0.45;

		protected override double ShieldArmorIncrement => 0.45;

		protected override double AttackIncrement => 1.5;
	}
}
