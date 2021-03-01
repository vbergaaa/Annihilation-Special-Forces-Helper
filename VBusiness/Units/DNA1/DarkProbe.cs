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
	}
}
