using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: HybridDominatorVoid
	//

	public class ArchDominator : Unit
	{
		public ArchDominator(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.ArchDominator;

		public override double BaseAttack => 60;

		public override double BaseAttackSpeed => 1.4;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 1000;

		public override double BaseHealthArmor => 10;

		public override double BaseHealthRegen => 2.5;

		public override double BaseShields => 1000;

		public override double BaseShieldArmor => 10;

		public override double BaseShieldRegen => 5;

		protected override double HealthIncrement => 11;

		protected override double HealthRegenIncrement => 1.5;

		protected override double ShieldIncrement => 11;

		protected override double ShieldRegenIncrement => 3;

		protected override double HealthArmorIncrement => 0.75;

		protected override double ShieldArmorIncrement => 0.75;

		protected override double AttackIncrement => 3.5;
	}
}
