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

		public override double BaseAttack => 30;

		public override double BaseAttackSpeed => 0.8;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 400;

		public override double BaseHealthArmor => 6;

		public override double BaseHealthRegen => 6;

		public override double BaseShields => 625;

		public override double BaseShieldArmor => 6;

		public override double BaseShieldRegen => 10;

		protected override double HealthIncrement => 10;

		protected override double HealthRegenIncrement => 1;

		protected override double ShieldIncrement => 17;

		protected override double ShieldRegenIncrement => 1.3007;

		protected override double HealthArmorIncrement => 0.8;

		protected override double ShieldArmorIncrement => 0.8;

		protected override double AttackIncrement => 2.2;
	}
}
