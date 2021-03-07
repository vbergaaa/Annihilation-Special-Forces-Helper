using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkTemplarAiur
	// WeaponData: AvengerWeapon

	public class DarkAvenger : Unit
	{
		public DarkAvenger(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.DarkAvenger;

		protected override double BaseAttack => 30;

		protected override double BaseAttackSpeed => 0.9;

		public override double AttackCount => 1;

		protected override double BaseHealth => 15;

		protected override double BaseHealthArmor => 4;

		protected override double BaseHealthRegen => 6;

		protected override double BaseShields => 325;

		protected override double BaseShieldsArmor => 4;

		protected override double BaseShieldsRegen => 6;

		protected override double HealthIncrement => 1.5;

		protected override double HealthRegenIncrement => 0.3984;

		protected override double ShieldIncrement => 13;

		protected override double ShieldRegenIncrement => 1.5;

		protected override double HealthArmorIncrement => 0.4;

		protected override double ShieldArmorIncrement => 0.4;

		protected override double AttackIncrement => 2;
	}
}
