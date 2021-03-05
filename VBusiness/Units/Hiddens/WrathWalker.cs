﻿using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ColossusTaldarim
	// WeaponData: ColossusTaldarimChargedBeam
	// EffectData: ColossusTaldarminDamage

	public class WrathWalker : Unit
	{
		public WrathWalker(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.WrathWalker;

		public override double BaseAttack => 35;

		public override double BaseAttackSpeed => 1.2;

		public override double BaseAttackCount => 1; // 3, but on 3 separate targets

		public override double BaseHealth => 325;

		public override double BaseHealthArmor => 7;

		public override double BaseHealthRegen => 7;

		public override double BaseShields => 400;

		public override double BaseShieldArmor => 7;

		public override double BaseShieldRegen => 7;

		protected override double HealthIncrement => 7;

		protected override double HealthRegenIncrement => 0.5;

		protected override double ShieldIncrement => 12;

		protected override double ShieldRegenIncrement => 1;

		protected override double HealthArmorIncrement => 0.7;

		protected override double ShieldArmorIncrement => 0.7;

		protected override double AttackIncrement => 2;
	}
}
