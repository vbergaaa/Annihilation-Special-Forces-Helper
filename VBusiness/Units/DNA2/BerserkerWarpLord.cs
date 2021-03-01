﻿using System;
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

		public override double BaseAttack => 16;

		public override double BaseAttackSpeed => 1;

		public override double BaseAttackCount => 2;

		public override double BaseHealth => 225;

		public override double BaseHealthArmor => 5;

		public override double BaseHealthRegen => 4;

		public override double BaseShields => 320;

		public override double BaseShieldArmor => 5;

		public override double BaseShieldRegen => 4;
	}
}
