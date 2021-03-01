using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Reaver
	// EffectData: ScarabExplodeTargetDamage

	public class Reaver : Unit
	{
		public Reaver(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.Reaver;

		public override double BaseAttack => 25;

		public override double BaseAttackSpeed => 2;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 250;

		public override double BaseHealthArmor => 6;

		public override double BaseHealthRegen => 5;

		public override double BaseShields => 325;

		public override double BaseShieldArmor => 6;

		public override double BaseShieldRegen => 5;
	}
}
