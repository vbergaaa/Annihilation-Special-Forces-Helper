using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class EmptyUnit : Unit
	{
		public EmptyUnit(VLoadout loadout) : base(loadout)
		{
			loadout.Units.Remove(this);
			HasChanges = false;
		}

		public override UnitType Type => UnitType.None;

		protected override double BaseAttack => 0;

		protected override double BaseAttackSpeed => 0;

		public override double AttackCount => 0;

		protected override double BaseHealth => 0;

		protected override double BaseHealthArmor => 0;

		protected override double BaseHealthRegen => 0;

		protected override double BaseShields => 0;

		protected override double BaseShieldsArmor => 0;

		protected override double BaseShieldsRegen => 0;

		protected override double HealthIncrement => 0;

		protected override double HealthRegenIncrement => 0;

		protected override double ShieldIncrement => 0;

		protected override double ShieldRegenIncrement => 0;

		protected override double HealthArmorIncrement => 0;

		protected override double ShieldArmorIncrement => 0;

		protected override double AttackIncrement => 0;
	}
}
