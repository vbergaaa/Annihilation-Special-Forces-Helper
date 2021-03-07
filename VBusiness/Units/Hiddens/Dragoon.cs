using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Dragoon
	// WeaponData: Dragoon
	// EffectData: DragoonDamage

	public class Dragoon : Unit
	{
		public Dragoon(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.Dragoon;

		protected override double BaseAttack => 15;

		protected override double BaseAttackSpeed => 1.3;

		public override double AttackCount => 1;

		protected override double BaseHealth => 250;

		protected override double BaseHealthArmor => 6;

		protected override double BaseHealthRegen => 5;

		protected override double BaseShields => 325;

		protected override double BaseShieldsArmor => 6;

		protected override double BaseShieldsRegen => 5;

		protected override double HealthIncrement => 5;

		protected override double HealthRegenIncrement => 0.3007;

		protected override double ShieldIncrement => 10;

		protected override double ShieldRegenIncrement => 0.8007;

		protected override double HealthArmorIncrement => 0.6;

		protected override double ShieldArmorIncrement => 0.6;

		protected override double AttackIncrement => 1;
	}
}
