using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ImmortalAiur
	// WeaponData: UnstableDisruptors
	// EffectData: ImmortalSplashSet2

	public class UnstableDreadnought : Unit
	{
		public UnstableDreadnought(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.UnstableDreadnought;

		public override double BaseAttack => 30;

		public override double BaseAttackSpeed => 1.7;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 350;

		public override double BaseHealthArmor => 7;

		public override double BaseHealthRegen => 7;

		public override double BaseShields => 500;

		public override double BaseShieldArmor => 7;

		public override double BaseShieldRegen => 7;

		protected override double HealthIncrement => 9;

		protected override double HealthRegenIncrement => 0.601;

		protected override double ShieldIncrement => 22;

		protected override double ShieldRegenIncrement => 1.5;

		protected override double HealthArmorIncrement => 0.55;

		protected override double ShieldArmorIncrement => 0.55;

		protected override double AttackIncrement => 2;
	}
}
