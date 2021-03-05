using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	//UnitData = DarkProbe
	//WeaponData = DarkParticleBeam
	public class DarkProbe : Unit
	{
		public DarkProbe(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.DarkProbe;

		public override double BaseAttack => 12;

		public override double BaseAttackSpeed => 1.3;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 50;

		public override double BaseHealthArmor => 4;

		public override double BaseHealthRegen => 0;

		public override double BaseShields => 100;

		public override double BaseShieldArmor => 4;

		public override double BaseShieldRegen => 5;

		protected override double HealthIncrement => 5;

		protected override double HealthRegenIncrement => 0.3007;

		protected override double ShieldIncrement => 8;

		protected override double ShieldRegenIncrement => 0.5;

		protected override double HealthArmorIncrement => 0.3;

		protected override double ShieldArmorIncrement => 0.3;

		protected override double AttackIncrement => 0.8;
	}
}
