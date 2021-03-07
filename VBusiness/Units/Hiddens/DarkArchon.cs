using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkArchonR
	// WeaponData: DarkShockwave
	// EffectData: PsionicShockwaveDamage2

	public class DarkArchon : Unit
	{
		public DarkArchon(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.DarkArchon;

		protected override double BaseAttack => 30;

		protected override double BaseAttackSpeed => 1.4;

		public override double AttackCount => 1;

		protected override double BaseHealth => 20;

		protected override double BaseHealthArmor => 10;

		protected override double BaseHealthRegen => 2;

		protected override double BaseShields => 1000;

		protected override double BaseShieldsArmor => 10;

		protected override double BaseShieldsRegen => 6;

		protected override double HealthIncrement => 2;

		protected override double HealthRegenIncrement => 1;

		protected override double ShieldIncrement => 33;

		protected override double ShieldRegenIncrement => 1.6992;

		protected override double HealthArmorIncrement => 0.95;

		protected override double ShieldArmorIncrement => 0.95;

		protected override double AttackIncrement => 2.5;
	}
}
