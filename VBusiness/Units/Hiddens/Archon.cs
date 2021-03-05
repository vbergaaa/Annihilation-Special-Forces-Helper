using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Archon
	// WeaponData: PsionicShockwave
	// EffectData: PsionicShockwaveDamage

	public class Archon : Unit
	{
		public Archon(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.Archon;

		public override double BaseAttack => 25;

		public override double BaseAttackSpeed => 1.4;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 10;

		public override double BaseHealthArmor => 7;

		public override double BaseHealthRegen => 1;

		public override double BaseShields => 700;

		public override double BaseShieldArmor => 7;

		public override double BaseShieldRegen => 4;

		protected override double HealthIncrement => 1;

		protected override double HealthRegenIncrement => 0.1992;

		protected override double ShieldIncrement => 27;

		protected override double ShieldRegenIncrement => 1.3007;

		protected override double HealthArmorIncrement => 0.7;

		protected override double ShieldArmorIncrement => 0.7;

		protected override double AttackIncrement => 1.3;
	}
}
