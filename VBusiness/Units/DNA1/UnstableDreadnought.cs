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

		protected override double BaseAttack => 30;

		protected override double BaseAttackSpeed => 1.7;

		public override double AttackCount => 1;

		protected override double BaseHealth => 350;

		protected override double BaseHealthArmor => 7;

		protected override double BaseHealthRegen => 7;

		protected override double BaseShields => 500;

		protected override double BaseShieldsArmor => 7;

		protected override double BaseShieldsRegen => 7;

		protected override double HealthIncrement => 9;

		protected override double HealthRegenIncrement => 0.601;

		protected override double ShieldIncrement => 22;

		protected override double ShieldRegenIncrement => 1.5;

		protected override double HealthArmorIncrement => 0.55;

		protected override double ShieldArmorIncrement => 0.55;

		protected override double AttackIncrement => 2;
	}
}
