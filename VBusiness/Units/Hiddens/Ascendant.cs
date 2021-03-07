using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: HighTemplarTaldarmin
	// WeaponData: AscendantWeapon
	// EffectData: AscendantWeaponDamage

	public class Ascendant : Unit
	{
		public Ascendant(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.Ascendant;

		protected override double BaseAttack => 25;

		protected override double BaseAttackSpeed => 1.4;

		public override double AttackCount => 1;

		protected override double BaseHealth => 500;

		protected override double BaseHealthArmor => 10;

		protected override double BaseHealthRegen => 2;

		protected override double BaseShields => 1000;

		protected override double BaseShieldsArmor => 10;

		protected override double BaseShieldsRegen => 10;

		protected override double HealthIncrement => 10;

		protected override double HealthRegenIncrement => 0.3007;

		protected override double ShieldIncrement => 20;

		protected override double ShieldRegenIncrement => 1;

		protected override double HealthArmorIncrement => 0.9;

		protected override double ShieldArmorIncrement => 0.9;

		protected override double AttackIncrement => 2;
	}
}
