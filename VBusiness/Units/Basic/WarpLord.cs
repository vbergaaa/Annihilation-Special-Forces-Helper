using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Loadouts;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	/// Unit: Zealot
	/// Weapon: Psi Blades
	public class WarpLord : Unit
	{
		public WarpLord(VLoadout loadout) : base(loadout)
		{
		}

		public override double BaseAttack => 11;

		public override double BaseAttackSpeed => 1.5;

		public override double BaseAttackCount => 2;

		public override double BaseHealth => 100;

		public override double BaseHealthArmor => 2;

		public override double BaseHealthRegen => 2;

		public override double BaseShields => 150;

		public override double BaseShieldArmor => 2;

		public override double BaseShieldRegen => 3;

		public override UnitType Type => UnitType.WarpLord;
	}
}
