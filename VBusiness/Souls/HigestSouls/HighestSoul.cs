using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class HighestSoul : Soul
	{
		public HighestSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Highest;

		protected sealed override SoulType Rarity => SoulType.Highest;

		public override int MaxAttack => 30;

		public override int MinAttack => 20;

		public override int MaxAttackSpeed => 17;

		public override int MinAttackSpeed => 15;

		public override int MaxCriticalChance => 0;

		public override int MinCriticalChance => 0;

		public override int MaxCriticalDamage => 0;

		public override int MinCriticalDamage => 0;

		public override int MaxVitals => 20;

		public override int MinVitals => 15;

		public override int MaxArmor => 15;

		public override int MinArmor => 10;

		public override int MaxMinerals => 4000;

		public override int MinMinerals => 3000;

		public override int MaxKills => 300;

		public override int MinKills => 200;

		public override int Cost => 900; // sell 80
	}
}
