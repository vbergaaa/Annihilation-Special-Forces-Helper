using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: MasterDance

	public class BladeMaster : Unit
	{
		public BladeMaster(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.BladeMaster;

		protected override double BaseAttack => 15;

		protected override double BaseAttackSpeed => 2.3;

		public override double AttackCount => 20;

		protected override double BaseHealth => 700;

		protected override double BaseHealthArmor => 12;

		protected override double BaseHealthRegen => 12;

		protected override double BaseShields => 1000;

		protected override double BaseShieldsArmor => 12;

		protected override double BaseShieldsRegen => 22;

		protected override double HealthIncrement => 16;

		protected override double HealthRegenIncrement => 1.3984;

		protected override double ShieldIncrement => 24;

		protected override double ShieldRegenIncrement => 2;

		protected override double HealthArmorIncrement => 1.1;

		protected override double ShieldArmorIncrement => 1.1;

		protected override double AttackIncrement => 1.5;
	}
}
