using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class LowerSoul : Soul
	{
		public override SoulType Type => SoulType.Lower;

		protected sealed override SoulType Rarity => SoulType.Lower;

		protected override int MaxAttack => 15;

		protected override int MinAttack => 5;

		protected override int MaxAttackSpeed => 7;

		protected override int MinAttackSpeed => 5;

		protected override int MaxCriticalChance => 0;

		protected override int MinCriticalChance => 0;

		protected override int MaxCriticalDamage => 0;

		protected override int MinCriticalDamage => 0;

		protected override int MaxVitals => 0;

		protected override int MinVitals => 0;

		protected override int MaxArmor => 0;

		protected override int MinArmor => 0;

		protected override int MaxMinerals => 0;

		protected override int MinMinerals => 0;

		protected override int MaxKills => 0;

		protected override int MinKills => 0;
	}
}
