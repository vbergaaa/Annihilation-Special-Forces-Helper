using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ZealotAiur
	// WeaponData: SolariteReaper
	
	public class BerserkerWarpLord : Unit
	{
		public BerserkerWarpLord(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.BerserkerWarpLord;

		protected override double BaseAttack => 16;

		protected override double BaseAttackSpeed => 1;

		public override double AttackCount => 2;

		protected override double BaseHealth => 225;

		protected override double BaseHealthArmor => 5;

		protected override double BaseHealthRegen => 4;

		protected override double BaseShields => 320;

		protected override double BaseShieldsArmor => 5;

		protected override double BaseShieldsRegen => 4;

		protected override double HealthIncrement => 7;

		protected override double HealthRegenIncrement => 0.3984;

		protected override double ShieldIncrement => 13;

		protected override double ShieldRegenIncrement => 1;

		protected override double HealthArmorIncrement => 0.6;

		protected override double ShieldArmorIncrement => 0.6;

		protected override double AttackIncrement => 1.2;
	}
}
