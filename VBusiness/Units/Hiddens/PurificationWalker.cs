using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class PurificationWalker : Unit
	{
		// UnitData: ColossusPurifier
		// WeaponData: ColossusPurifierThermalLances
		// EffectData: ColossusPurifierThermalLancesDamage

		public PurificationWalker(VLoadout loadout) : base(loadout)
		{
		}

		public override UnitType Type => UnitType.PurificationWalker;

		protected override double BaseAttack => 30;

		protected override double BaseAttackSpeed => 1.4;

		public override double AttackCount => 2;

		protected override double BaseHealth => 600;

		protected override double BaseHealthArmor => 8;

		protected override double BaseHealthRegen => 5;

		protected override double BaseShields => 850;

		protected override double BaseShieldsArmor => 8;

		protected override double BaseShieldsRegen => 5;

		protected override double HealthIncrement => 12;

		protected override double HealthRegenIncrement => 1;

		protected override double ShieldIncrement => 18;

		protected override double ShieldRegenIncrement => 1.5;

		protected override double HealthArmorIncrement => 1.1;

		protected override double ShieldArmorIncrement => 1.1;

		protected override double AttackIncrement => 2.5;
	}
}
