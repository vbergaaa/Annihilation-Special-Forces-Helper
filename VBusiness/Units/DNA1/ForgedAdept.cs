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

		protected override double BaseAttack => 35;

		protected override double BaseAttackSpeed => 1.3;

		public override double AttackCount => 1;

		protected override double BaseHealth => 160;

		protected override double BaseHealthArmor => 4.5;

		protected override double BaseHealthRegen => 4;

		protected override double BaseShields => 250;

		protected override double BaseShieldsArmor => 4.5;

		protected override double BaseShieldsRegen => 6;

		protected override double HealthIncrement => 7;

		protected override double HealthRegenIncrement => 0.5;

		protected override double ShieldIncrement => 9;

		protected override double ShieldRegenIncrement => 1;

		protected override double HealthArmorIncrement => 0.6;

		protected override double ShieldArmorIncrement => 0.6;

		protected override double AttackIncrement => 1.6;
	}
}
