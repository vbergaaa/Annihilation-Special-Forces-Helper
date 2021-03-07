using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkArchon
	// WeaponData: DarkArchonWeapon
	// EffectData: DarkArchonWeaponDamage

	public class CrimsonArchon : Unit
	{
		public CrimsonArchon(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.CrimsonArchon;

		protected override double BaseAttack => 50;

		protected override double BaseAttackSpeed => 1.3;

		public override double AttackCount => 1;

		protected override double BaseHealth => 30;

		protected override double BaseHealthArmor => 12;

		protected override double BaseHealthRegen => 3;

		protected override double BaseShields => 1250;

		protected override double BaseShieldsArmor => 12;

		protected override double BaseShieldsRegen => 8;

		protected override double HealthIncrement => 3.5;

		protected override double HealthRegenIncrement => 0.4492;

		protected override double ShieldIncrement => 37;

		protected override double ShieldRegenIncrement => 2.3007;

		protected override double HealthArmorIncrement => 1.1;

		protected override double ShieldArmorIncrement => 1.1;

		protected override double AttackIncrement => 3.5;
	}
}
