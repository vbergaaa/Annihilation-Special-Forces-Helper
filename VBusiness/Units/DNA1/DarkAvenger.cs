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

		public override double BaseAttack => 30;

		public override double BaseAttackSpeed => 0.9;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 15;

		public override double BaseHealthArmor => 4;

		public override double BaseHealthRegen => 6;

		public override double BaseShields => 325;

		public override double BaseShieldArmor => 4;

		public override double BaseShieldRegen => 6;

		protected override double HealthIncrement => 1.5;

		protected override double HealthRegenIncrement => 0.3984;

		protected override double ShieldIncrement => 13;

		protected override double ShieldRegenIncrement => 1.5;

		protected override double HealthArmorIncrement => 0.4;

		protected override double ShieldArmorIncrement => 0.4;

		protected override double AttackIncrement => 2;
	}
}
