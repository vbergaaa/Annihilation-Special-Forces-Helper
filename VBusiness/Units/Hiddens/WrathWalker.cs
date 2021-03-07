using System;
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

		protected override double BaseAttack => 35;

		protected override double BaseAttackSpeed => 1.2;

		public override double AttackCount => 1; // 3, but on 3 separate targets

		protected override double BaseHealth => 325;

		protected override double BaseHealthArmor => 7;

		protected override double BaseHealthRegen => 7;

		protected override double BaseShields => 400;

		protected override double BaseShieldsArmor => 7;

		protected override double BaseShieldsRegen => 7;

		protected override double HealthIncrement => 7;

		protected override double HealthRegenIncrement => 0.5;

		protected override double ShieldIncrement => 12;

		protected override double ShieldRegenIncrement => 1;

		protected override double HealthArmorIncrement => 0.7;

		protected override double ShieldArmorIncrement => 0.7;

		protected override double AttackIncrement => 2;
	}
}
