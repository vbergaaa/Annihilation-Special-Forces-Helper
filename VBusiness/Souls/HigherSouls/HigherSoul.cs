using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class HigherSoul : Soul
	{
		public HigherSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Higher;

		protected sealed override SoulType Rarity => SoulType.Higher;

		protected override int MaxAttack => 20;

		protected override int MinAttack => 10;

		protected override int MaxAttackSpeed => 15;

		protected override int MinAttackSpeed => 10;

		protected override int MaxCriticalChance => 0;

		protected override int MinCriticalChance => 0;

		protected override int MaxCriticalDamage => 0;

		protected override int MinCriticalDamage => 0;

		protected override int MaxVitals => 12;

		protected override int MinVitals => 10;

		protected override int MaxArmor => 10;

		protected override int MinArmor => 5;

		protected override int MaxMinerals => 3000;

		protected override int MinMinerals => 2000;

		protected override int MaxKills => 200;

		protected override int MinKills => 200;
	}
}
