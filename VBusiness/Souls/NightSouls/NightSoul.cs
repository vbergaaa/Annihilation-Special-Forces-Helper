using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class NightSoul : Soul
	{
		public override SoulType Type => SoulType.Night;

		protected sealed override SoulType Rarity => SoulType.Night;

		protected override int MaxAttack => 35;

		protected override int MinAttack => 25;

		protected override int MaxAttackSpeed => 20;

		protected override int MinAttackSpeed => 15;

		protected override int MaxCriticalChance => 0;

		protected override int MinCriticalChance => 0;

		protected override int MaxCriticalDamage => 0;

		protected override int MinCriticalDamage => 0;

		protected override int MaxVitals => 20;

		protected override int MinVitals => 15;

		protected override int MaxArmor => 15;

		protected override int MinArmor => 10;

		protected override int MaxMinerals => 6000;

		protected override int MinMinerals => 4000;

		protected override int MaxKills => 600;

		protected override int MinKills => 400;
	}
}
