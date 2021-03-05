using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: HighArchonTemplar
	// WeaponData: HighTemplarWeapon

	public class HighTemplar : Unit
	{
		public HighTemplar(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.HighTemplar;

		public override double BaseAttack => 20;

		public override double BaseAttackSpeed => 1.5;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 650;

		public override double BaseHealthArmor => 7;

		public override double BaseHealthRegen => 3;

		public override double BaseShields => 650;

		public override double BaseShieldArmor => 7;

		public override double BaseShieldRegen => 6;

		protected override double HealthIncrement => 8;

		protected override double HealthRegenIncrement => 0.6992;

		protected override double ShieldIncrement => 8;

		protected override double ShieldRegenIncrement => 0.6992;

		protected override double HealthArmorIncrement => 0.65;

		protected override double ShieldArmorIncrement => 0.65;

		protected override double AttackIncrement => 1;
	}
}
