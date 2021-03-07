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

		protected override double BaseAttack => 20;

		protected override double BaseAttackSpeed => 1;

		public override double AttackCount => 1;

		protected override double BaseHealth => 400;

		protected override double BaseHealthArmor => 5;

		protected override double BaseHealthRegen => 2;

		protected override double BaseShields => 400;

		protected override double BaseShieldsArmor => 5;

		protected override double BaseShieldsRegen => 3;

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
