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

		public override double BaseAttack => 15;

		public override double BaseAttackSpeed => 2.3;

		public override double BaseAttackCount => 20;

		public override double BaseHealth => 700;

		public override double BaseHealthArmor => 12;

		public override double BaseHealthRegen => 12;

		public override double BaseShields => 1000;

		public override double BaseShieldArmor => 12;

		public override double BaseShieldRegen => 22;

		protected override double HealthIncrement => 16;

		protected override double HealthRegenIncrement => 1.3984;

		protected override double ShieldIncrement => 24;

		protected override double ShieldRegenIncrement => 2;

		protected override double HealthArmorIncrement => 1.1;

		protected override double ShieldArmorIncrement => 1.1;

		protected override double AttackIncrement => 1.5;
	}
}
