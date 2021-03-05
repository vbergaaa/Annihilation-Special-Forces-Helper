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

		public override double BaseAttack => 20;

		public override double BaseAttackSpeed => 1.4;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 500;

		public override double BaseHealthArmor => 7;

		public override double BaseHealthRegen => 3;

		public override double BaseShields => 650;

		public override double BaseShieldArmor => 7;

		public override double BaseShieldRegen => 10;

		protected override double HealthIncrement => 9;

		protected override double HealthRegenIncrement => 0.6992;

		protected override double ShieldIncrement => 22;

		protected override double ShieldRegenIncrement => 1.5;

		protected override double HealthArmorIncrement => 0.7;

		protected override double ShieldArmorIncrement => 0.7;

		protected override double AttackIncrement => 2;
	}
}
