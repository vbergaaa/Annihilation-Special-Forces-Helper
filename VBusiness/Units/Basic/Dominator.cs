using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData name = HybridDominator
	// ASF Weapon name = Psi Blast (can't find in WeaponData)
	public class Dominator : Unit
	{
		public Dominator(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.Dominator;

		protected override double BaseAttack => 50;

		protected override double BaseAttackSpeed => 1.5;

		public override double AttackCount => 1;

		protected override double BaseHealth => 600;

		protected override double BaseHealthArmor => 6;

		protected override double BaseHealthRegen => 1;

		protected override double BaseShields => 600;

		protected override double BaseShieldsArmor => 6;

		protected override double BaseShieldsRegen => 2; // wasn't in data but seems to be correct from my testing

		protected override double HealthIncrement => 8;

		protected override double HealthRegenIncrement => 1;

		protected override double ShieldIncrement => 8;

		protected override double ShieldRegenIncrement => 2.0;

		protected override double HealthArmorIncrement => 0.6;

		protected override double ShieldArmorIncrement => 0.6;

		protected override double AttackIncrement => 2.5;
	}
}
