﻿using System;
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

		public override double BaseAttack => 25;

		public override double BaseAttackSpeed => 2;

		public override double BaseAttackCount => 52;

		public override double BaseHealth => 1000;

		public override double BaseHealthArmor => 16;

		public override double BaseHealthRegen => 15;

		public override double BaseShields => 1500;

		public override double BaseShieldArmor => 16;

		public override double BaseShieldRegen => 30;

		protected override double HealthIncrement => 23;

		protected override double HealthRegenIncrement => 1.8007;

		protected override double ShieldIncrement => 32;

		protected override double ShieldRegenIncrement => 2.5;

		protected override double HealthArmorIncrement => 1.4;

		protected override double ShieldArmorIncrement => 1.4;

		protected override double AttackIncrement => 20;
	}
}
