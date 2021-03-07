using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// Unit: Adept
	// Weapon: Adept
	// Effect: AdeptDamage
	public class LightAdept : Unit
	{
		public LightAdept(VLoadout loadout) : base(loadout)
		{
		}

		protected override double BaseAttack => 25;

		protected override double BaseAttackSpeed => 1.4;

		public override double AttackCount => 1;

		protected override double BaseHealth => 125;

		protected override double BaseHealthArmor => 3;

		protected override double BaseHealthRegen => 3;

		protected override double BaseShields => 175;

		protected override double BaseShieldsArmor => 3;

		protected override double BaseShieldsRegen => 5;

		public override UnitType Type => UnitType.LightAdept;

		protected override double HealthIncrement => 5;

		protected override double HealthRegenIncrement => 0.3007;

		protected override double ShieldIncrement => 7;

		protected override double ShieldRegenIncrement => 1;

		protected override double HealthArmorIncrement => 0.45;

		protected override double ShieldArmorIncrement => 0.45;

		protected override double AttackIncrement => 1.25;
	}
}
