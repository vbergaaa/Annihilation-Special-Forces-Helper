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

		protected override double BaseAttack => 25;

		protected override double BaseAttackSpeed => 1.25;

		public override double AttackCount => 1;

		protected override double BaseHealth => 600;

		protected override double BaseHealthArmor => 6;

		protected override double BaseHealthRegen => 10;

		protected override double BaseShields => 0;

		protected override double BaseShieldsArmor => 0;

		protected override double BaseShieldsRegen => 0;

		protected override double HealthIncrement => 12;

		protected override double HealthRegenIncrement => 1.1015;

		protected override double ShieldIncrement => 0;

		protected override double ShieldRegenIncrement => 0;

		protected override double HealthArmorIncrement => 0.7;

		protected override double ShieldArmorIncrement => 0;

		protected override double AttackIncrement => 1.8;
	}
}
