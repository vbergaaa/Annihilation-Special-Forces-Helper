using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: DarkArchon
	// WeaponData: WingedTorrent
	// EffectData: WingedArchonWeaponDamage

	public class WingedArchon : Unit
	{
		public WingedArchon(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.WingedArchon;

		public override double BaseAttack => 65;

		public override double BaseAttackSpeed => 1.1;

		public override double BaseAttackCount => 1;

		public override double BaseHealth => 60;

		public override double BaseHealthArmor => 15;

		public override double BaseHealthRegen => 4;

		public override double BaseShields => 1600;

		public override double BaseShieldArmor => 15;

		public override double BaseShieldRegen => 10;
	}
}
