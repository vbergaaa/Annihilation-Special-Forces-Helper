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

		protected override double BaseAttack => 65;

		protected override double BaseAttackSpeed => 1.1;

		public override double AttackCount => 1;

		protected override double BaseHealth => 60;

		protected override double BaseHealthArmor => 15;

		protected override double BaseHealthRegen => 4;

		protected override double BaseShields => 1600;

		protected override double BaseShieldsArmor => 15;

		protected override double BaseShieldsRegen => 10;

		protected override double HealthIncrement => 15;

		protected override double HealthRegenIncrement => 1.8007;

		protected override double ShieldIncrement => 40;

		protected override double ShieldRegenIncrement => 3;

		protected override double HealthArmorIncrement => 1.3;

		protected override double ShieldArmorIncrement => 1.3;

		protected override double AttackIncrement => 4.2;
	}
}
