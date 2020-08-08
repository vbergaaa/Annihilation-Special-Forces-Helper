using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class TormentedSoul : Soul
	{
		public override SoulType Type => SoulType.Tormented;

		protected sealed override SoulType Rarity => SoulType.Tormented;

		protected override int MaxAttack => 35;

		protected override int MinAttack => 30;

		protected override int MaxAttackSpeed => 20;

		protected override int MinAttackSpeed => 15;

		protected override int MaxCriticalChance => 5;

		protected override int MinCriticalChance => 1;

		protected override int MaxCriticalDamage => 0;

		protected override int MinCriticalDamage => 0;

		protected override int MaxVitals => 20;

		protected override int MinVitals => 15;

		protected override int MaxArmor => 16;

		protected override int MinArmor => 10;

		protected override int MaxMinerals => 8000;

		protected override int MinMinerals => 6000;

		protected override int MaxKills => 800;

		protected override int MinKills => 600;
	}
}
