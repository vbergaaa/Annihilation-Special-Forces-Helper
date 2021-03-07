using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ZealotPurifier
	// WeaponData: TerminatorBlades

	public class TerminatorWarpLord : Unit
	{
		public TerminatorWarpLord(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.TerminatorWarpLord;

		protected override double BaseAttack => 30;

		protected override double BaseAttackSpeed => 0.8;

		public override double AttackCount => 1;

		protected override double BaseHealth => 400;

		protected override double BaseHealthArmor => 6;

		protected override double BaseHealthRegen => 6;

		protected override double BaseShields => 625;

		protected override double BaseShieldsArmor => 6;

		protected override double BaseShieldsRegen => 10;

		protected override double HealthIncrement => 10;

		protected override double HealthRegenIncrement => 1;

		protected override double ShieldIncrement => 17;

		protected override double ShieldRegenIncrement => 1.3007;

		protected override double HealthArmorIncrement => 0.8;

		protected override double ShieldArmorIncrement => 0.8;

		protected override double AttackIncrement => 2.2;
	}
}
