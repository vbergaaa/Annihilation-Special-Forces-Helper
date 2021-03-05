using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ZealotShakuras
	// Weapon: WarpBlades
	// Effect: WarpBladesDamage

	public class DarkWarpLord : Unit
	{
		public DarkWarpLord(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.DarkWarpLord;

		public override double BaseAttack => 15;

		public override double BaseAttackSpeed => 1.2; // Doesn't match weapon data for WarpBlades, tested in game

		public override double BaseAttackCount => 2;

		public override double BaseHealth => 150;

		public override double BaseHealthArmor => 3;

		public override double BaseHealthRegen => 3;

		public override double BaseShields => 200;

		public override double BaseShieldArmor => 3;

		public override double BaseShieldRegen => 5;

		protected override double HealthIncrement => 5;

		protected override double HealthRegenIncrement => 0.25;

		protected override double ShieldIncrement => 10;

		protected override double ShieldRegenIncrement => 0.8007;

		protected override double HealthArmorIncrement => 0.45;

		protected override double ShieldArmorIncrement => 0.45;

		protected override double AttackIncrement => 0.8;
	}
}
