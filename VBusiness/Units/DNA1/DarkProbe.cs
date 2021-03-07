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

		protected override double BaseAttack => 12;

		protected override double BaseAttackSpeed => 1.3;

		public override double AttackCount => 1;

		protected override double BaseHealth => 50;

		protected override double BaseHealthArmor => 4;

		protected override double BaseHealthRegen => 0;

		protected override double BaseShields => 100;

		protected override double BaseShieldsArmor => 4;

		protected override double BaseShieldsRegen => 5;

		protected override double HealthIncrement => 5;

		protected override double HealthRegenIncrement => 0.3007;

		protected override double ShieldIncrement => 8;

		protected override double ShieldRegenIncrement => 0.5;

		protected override double HealthArmorIncrement => 0.3;

		protected override double ShieldArmorIncrement => 0.3;

		protected override double AttackIncrement => 0.8;
	}
}
