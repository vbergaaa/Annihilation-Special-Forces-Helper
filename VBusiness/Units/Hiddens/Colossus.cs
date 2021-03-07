using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Colossus
	// WeaponData: ThermalLances
	// EffectData: ThermalLancesMU

	public class Colossus : Unit
	{
		public Colossus(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.Colossus;

		protected override double BaseAttack => 20;

		protected override double BaseAttackSpeed => 1.5;

		public override double AttackCount => 2;

		protected override double BaseHealth => 325;

		protected override double BaseHealthArmor => 7;

		protected override double BaseHealthRegen => 7;

		protected override double BaseShields => 400;

		protected override double BaseShieldsArmor => 7;

		protected override double BaseShieldsRegen => 7;

		protected override double HealthIncrement => 7;

		protected override double HealthRegenIncrement => 0.5;

		protected override double ShieldIncrement => 12;

		protected override double ShieldRegenIncrement => 1;

		protected override double HealthArmorIncrement => 0.7;

		protected override double ShieldArmorIncrement => 0.7;

		protected override double AttackIncrement => 2.2;
	}
}
