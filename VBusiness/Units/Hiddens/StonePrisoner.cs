using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: StoneZealot
	// EffectData: EyeBeamsGround (NOT StoneZealot)

	public class StonePrisoner : Unit
	{
		public StonePrisoner(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.StonePrisoner;

		public override double BaseAttack => 25;

		public override double BaseAttackSpeed => 1.25;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 600;

		public override double BaseHealthArmor => 6;

		public override double BaseHealthRegen => 10;

		public override double BaseShields => 0;

		public override double BaseShieldArmor => 0;

		public override double BaseShieldRegen => 0;

		protected override double HealthIncrement => 12;

		protected override double HealthRegenIncrement => 1.1015;

		protected override double ShieldIncrement => 0;

		protected override double ShieldRegenIncrement => 0;

		protected override double HealthArmorIncrement => 0.7;

		protected override double ShieldArmorIncrement => 0;

		protected override double AttackIncrement => 1.8;
	}
}
