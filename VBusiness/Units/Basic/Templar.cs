using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Unit: HighTemplar
	// Weapon effect: HighTemplarWeaponDamage
	// Ability effect: PsiStormDamage && PsiStormDamageInitial

	public class Templar : Unit
	{
		public Templar(VLoadout loadout) : base(loadout)
		{
		}

		public override double BaseAttack => 20;

		public override double BaseAttackSpeed => 1;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 400;

		public override double BaseHealthArmor => 5;

		public override double BaseHealthRegen => 2;

		public override double BaseShields => 400;

		public override double BaseShieldArmor => 5;

		public override double BaseShieldRegen => 3;

		public override UnitType Type => UnitType.Templar;

		protected override double HealthIncrement => 6;

		protected override double HealthRegenIncrement => 0.5;

		protected override double ShieldIncrement => 6;

		protected override double ShieldRegenIncrement => 0.5;

		protected override double HealthArmorIncrement => 0.55;

		protected override double ShieldArmorIncrement => 0.55;

		protected override double AttackIncrement => 1;
	}
}
