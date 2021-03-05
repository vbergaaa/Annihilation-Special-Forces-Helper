using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ForgedAdept
	// WeaponData: DarkPurifierGlaive
	// EffectData: DarkAdeptDamage

	public class ForgedAdept : Unit
	{
		public ForgedAdept(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.ForgedAdept;

		public override double BaseAttack => 35;

		public override double BaseAttackSpeed => 1.3;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 160;

		public override double BaseHealthArmor => 4.5;

		public override double BaseHealthRegen => 4;

		public override double BaseShields => 250;

		public override double BaseShieldArmor => 4.5;

		public override double BaseShieldRegen => 6;

		protected override double HealthIncrement => 7;

		protected override double HealthRegenIncrement => 0.5;

		protected override double ShieldIncrement => 9;

		protected override double ShieldRegenIncrement => 1;

		protected override double HealthArmorIncrement => 0.6;

		protected override double ShieldArmorIncrement => 0.6;

		protected override double AttackIncrement => 1.6;
	}
}
