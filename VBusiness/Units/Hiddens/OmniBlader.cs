using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class OmniBlader : Unit
	{
		// UnitData: OmniBlader
		// WeaponData: OmniDance
		// EffectData: OmniDanceDamage

		public OmniBlader(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.OmniBlader;

		protected override double BaseAttack => 25;

		protected override double BaseAttackSpeed => 2;

		public override double AttackCount => 52;

		protected override double BaseHealth => 1000;

		protected override double BaseHealthArmor => 16;

		protected override double BaseHealthRegen => 15;

		protected override double BaseShields => 1500;

		protected override double BaseShieldsArmor => 16;

		protected override double BaseShieldsRegen => 30;

		protected override double HealthIncrement => 23;

		protected override double HealthRegenIncrement => 1.8007;

		protected override double ShieldIncrement => 32;

		protected override double ShieldRegenIncrement => 2.5;

		protected override double HealthArmorIncrement => 1.4;

		protected override double ShieldArmorIncrement => 1.4;

		protected override double AttackIncrement => 20;
	}
}
