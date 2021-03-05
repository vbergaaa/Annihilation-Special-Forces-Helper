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

		public override double BaseAttack => 25;

		public override double BaseAttackSpeed => 1.4;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 125;

		public override double BaseHealthArmor => 3;

		public override double BaseHealthRegen => 3;

		public override double BaseShields => 175;

		public override double BaseShieldArmor => 3;

		public override double BaseShieldRegen => 5;

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
