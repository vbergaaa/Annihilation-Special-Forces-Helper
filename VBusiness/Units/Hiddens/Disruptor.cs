using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitType: Disruptor
	// WeaponData: DisruptorBlast
	// EffectData: DisruptorWeaponDamage2

	public class Disruptor : Unit
	{
		public Disruptor(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.Disruptor;

		protected override double BaseAttack => 20;

		protected override double BaseAttackSpeed => 1.4;

		public override double AttackCount => 1;

		protected override double BaseHealth => 500;

		protected override double BaseHealthArmor => 7;

		protected override double BaseHealthRegen => 3;

		protected override double BaseShields => 650;

		protected override double BaseShieldsArmor => 7;

		protected override double BaseShieldsRegen => 10;

		protected override double HealthIncrement => 9;

		protected override double HealthRegenIncrement => 0.6992;

		protected override double ShieldIncrement => 22;

		protected override double ShieldRegenIncrement => 1.5;

		protected override double HealthArmorIncrement => 0.7;

		protected override double ShieldArmorIncrement => 0.7;

		protected override double AttackIncrement => 2;
	}
}
