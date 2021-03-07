using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Reaver
	// EffectData: ScarabExplodeTargetDamage

	public class Reaver : Unit
	{
		public Reaver(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.Reaver;

		protected override double BaseAttack => 25;

		protected override double BaseAttackSpeed => 2;

		public override double AttackCount => 1;

		protected override double BaseHealth => 250;

		protected override double BaseHealthArmor => 6;

		protected override double BaseHealthRegen => 5;

		protected override double BaseShields => 325;

		protected override double BaseShieldsArmor => 6;

		protected override double BaseShieldsRegen => 5;

		protected override double HealthIncrement => 5;

		protected override double HealthRegenIncrement => 0.3007;

		protected override double ShieldIncrement => 10;

		protected override double ShieldRegenIncrement => 0.8007;

		protected override double HealthArmorIncrement => 0.6;

		protected override double ShieldArmorIncrement => 0.6;

		protected override double AttackIncrement => 2;
	}
}
